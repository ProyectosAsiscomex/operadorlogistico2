using AsiscomexOperadorLogistico.Components;
using AsiscomexOperadorLogistico.Data;
using AsiscomexOperadorLogistico.Services;
using AsiscomexOperadorLogistico.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios para MudBlazor con opciones de resiliencia para SignalR
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Configurar Server-Side Blazor con opciones de resiliencia
builder.Services.AddServerSideBlazor(options =>
{
    // Mostrar errores detallados solo en desarrollo
    options.DetailedErrors = builder.Environment.IsDevelopment();

    // Tiempo que se mantiene un circuito desconectado antes de eliminarlo (3 minutos)
    options.DisconnectedCircuitRetentionPeriod = TimeSpan.FromMinutes(3);

    // Número máximo de circuitos desconectados a retener
    options.DisconnectedCircuitMaxRetained = 100;

    // Timeout para llamadas JavaScript (1 minuto)
    options.JSInteropDefaultCallTimeout = TimeSpan.FromMinutes(1);

    // Número máximo de batches de renderizado no reconocidos
    options.MaxBufferedUnacknowledgedRenderBatches = 10;
});

// Agregar MudBlazor - Servicios de UI
builder.Services.AddMudServices();

// Agregar LocalStorage para manejo de sesión con configuración
builder.Services.AddBlazoredLocalStorage(config =>
{
    config.JsonSerializerOptions.WriteIndented = true;
    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

// Configuración de Entity Framework Core con opciones de resiliencia
builder.Services.AddDbContext<AcexGestionContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("IMSAConnectionString"),
        sqlServerOptionsAction: sqlOptions =>
        {
            // Habilitar reintentos automáticos en caso de fallos transitorios
            sqlOptions.EnableRetryOnFailure(
                maxRetryCount: 5,                              // Número máximo de reintentos
                maxRetryDelay: TimeSpan.FromSeconds(30),       // Delay máximo entre reintentos
                errorNumbersToAdd: null                        // Números de error adicionales a considerar como transitorios
            );

            // Timeout de comandos (30 segundos)
            sqlOptions.CommandTimeout(30);

            // Habilitar múltiples conjuntos de resultados activos
            // Útil para consultas paralelas
            // sqlOptions.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        }
    );

    // Configuraciones adicionales de Entity Framework
    if (builder.Environment.IsDevelopment())
    {
        // En desarrollo, habilitar logging detallado y datos sensibles
        options.EnableSensitiveDataLogging();
        options.EnableDetailedErrors();
    }

    // Configurar el comportamiento de tracking
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

    // Configurar el pool de conexiones
    options.ConfigureWarnings(warnings =>
    {
        // Puedes configurar advertencias específicas aquí si es necesario
        // warnings.Ignore(RelationalEventId.AmbientTransactionWarning);
    });
});

// Registrar servicios y repositorios con configuración de ciclo de vida apropiado
builder.Services.AddScoped<IDOService, DOService>();
builder.Services.AddScoped<IExportadorService, ExportadorService>();
builder.Services.AddScoped<IParametrosService, ParametrosService>();
builder.Services.AddScoped<IStorageService, LocalStorageService>();
builder.Services.AddScoped<IEmailService, EmailService>();

// Agregar HttpClient con políticas de resiliencia
builder.Services.AddHttpClient("default", client =>
{
    client.Timeout = TimeSpan.FromSeconds(30);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

// Configurar políticas de HttpClient con Polly (opcional - requiere Microsoft.Extensions.Http.Polly)
// builder.Services.AddHttpClient<IEmailService, EmailService>()
//     .AddPolicyHandler(GetRetryPolicy())
//     .AddPolicyHandler(GetCircuitBreakerPolicy());

// Agregar soporte para controladores API con opciones
builder.Services.AddControllers(options =>
{
    // Configurar el tamaño máximo del modelo
    options.MaxModelBindingCollectionSize = 1000;

    // Configurar el comportamiento de validación del modelo
    options.SuppressAsyncSuffixInActionNames = false;
});

// Configurar los servicios de autorización si es necesario
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();

// Configurar CORS si es necesario para APIs
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Configurar compresión de respuestas para mejor rendimiento
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});

// Configurar el logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
if (builder.Environment.IsDevelopment())
{
    builder.Logging.AddDebug();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

    // HSTS (HTTP Strict Transport Security) con configuración personalizada
    app.UseHsts();
}
else
{
    // En desarrollo, usar página de excepción para desarrolladores
    app.UseDeveloperExceptionPage();
}

// Middleware de redirección HTTPS
app.UseHttpsRedirection();

// Middleware de compresión de respuestas
app.UseResponseCompression();

// Servir archivos estáticos
app.UseStaticFiles();

// Middleware antiforgery para protección CSRF
app.UseAntiforgery();

// CORS si es necesario
if (builder.Environment.IsDevelopment())
{
    app.UseCors("AllowAll");
}

// Autenticación y autorización si están configuradas
app.UseAuthentication();
app.UseAuthorization();

// Mapear controladores API si es necesario
app.MapControllers();

// Mapear componentes Razor con modo de renderizado interactivo del servidor
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Verificar la conexión a la base de datos al inicio (opcional)
using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<AcexGestionContext>();

        // Verificar si la base de datos puede conectarse
        if (context.Database.CanConnect())
        {
            app.Logger.LogInformation("✅ Conexión a la base de datos establecida correctamente");

            // Aplicar migraciones pendientes automáticamente (solo en desarrollo)
            if (app.Environment.IsDevelopment())
            {
                // context.Database.Migrate(); // Descomentar si quieres aplicar migraciones automáticamente
            }
        }
        else
        {
            app.Logger.LogError("❌ No se pudo establecer conexión con la base de datos");
        }
    }
    catch (Exception ex)
    {
        app.Logger.LogError(ex, "❌ Error al verificar la conexión a la base de datos");
    }
}

app.Logger.LogInformation("🚀 Aplicación iniciada correctamente");

app.Run();