using AsiscomexOperadorLogistico.Services.Interfaces;
using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace AsiscomexOperadorLogistico.Services
{
    /// <summary>
    /// Servicio para manejo de almacenamiento local del navegador
    /// Reemplaza el uso de Session del WebForm
    /// </summary>
    public class LocalStorageService : IStorageService
    {
        private readonly ILocalStorageService _localStorage;

        // Constantes para las llaves de almacenamiento
        private const string USER_ID_KEY = "userId";
        private const string DO_GLOBAL_KEY = "DOglobal";
        private const string TIPO_DO_KEY = "TipoDO";
        private const string ID_DO_GLOBAL_KEY = "idDOglobal";

        public LocalStorageService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        /// <summary>
        /// Obtiene un item del almacenamiento local
        /// </summary>
        public async Task<T> GetItemAsync<T>(string key)
        {
            return await _localStorage.GetItemAsync<T>(key);
        }

        /// <summary>
        /// Guarda un item en el almacenamiento local
        /// </summary>
        public async Task SetItemAsync<T>(string key, T value)
        {
            await _localStorage.SetItemAsync(key, value);
        }

        /// <summary>
        /// Elimina un item del almacenamiento local
        /// </summary>
        public async Task RemoveItemAsync(string key)
        {
            await _localStorage.RemoveItemAsync(key);
        }

        /// <summary>
        /// Limpia todo el almacenamiento local
        /// </summary>
        public async Task ClearAsync()
        {
            await _localStorage.ClearAsync();
        }

        /// <summary>
        /// Verifica si existe una llave en el almacenamiento
        /// </summary>
        public async Task<bool> ContainKeyAsync(string key)
        {
            return await _localStorage.ContainKeyAsync(key);
        }

        // Métodos específicos para sesión (compatibilidad con WebForm)

        /// <summary>
        /// Obtiene el ID del usuario actual
        /// </summary>
        public async Task<string> GetUserIdAsync()
        {
            return await GetItemAsync<string>(USER_ID_KEY) ?? string.Empty;
        }

        /// <summary>
        /// Establece el ID del usuario actual
        /// </summary>
        public async Task SetUserIdAsync(string userId)
        {
            await SetItemAsync(USER_ID_KEY, userId);
        }

        /// <summary>
        /// Obtiene el DO global de la sesión
        /// </summary>
        public async Task<string> GetDOGlobalAsync()
        {
            return await GetItemAsync<string>(DO_GLOBAL_KEY) ?? string.Empty;
        }

        /// <summary>
        /// Establece el DO global en la sesión
        /// </summary>
        public async Task SetDOGlobalAsync(string doGlobal)
        {
            await SetItemAsync(DO_GLOBAL_KEY, doGlobal);
        }

        /// <summary>
        /// Obtiene el tipo de DO de la sesión
        /// </summary>
        public async Task<string> GetTipoDOAsync()
        {
            return await GetItemAsync<string>(TIPO_DO_KEY) ?? "IMPO";
        }

        /// <summary>
        /// Establece el tipo de DO en la sesión
        /// </summary>
        public async Task SetTipoDOAsync(string tipoDO)
        {
            await SetItemAsync(TIPO_DO_KEY, tipoDO);
        }
    }
}