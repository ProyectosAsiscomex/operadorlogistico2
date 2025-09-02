using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("F560-2009-Frente")]
public partial class F560_2009_Frente
{
    /// <summary>
    /// Número unico que identifica al registro dentro de la tabla
    /// </summary>
    [Key]
    public int id { get; set; }

    /// <summary>
    /// Año de presentación del documento
    /// </summary>
    [StringLength(4)]
    public string? anno { get; set; }

    /// <summary>
    /// Número unico asignado por el sistema
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? numeroFormulario { get; set; }

    /// <summary>
    /// Numero de identificación tributaria del importador
    /// </summary>
    [StringLength(15)]
    public string? ImportadorNIT { get; set; }

    /// <summary>
    /// Digito de verificación del NIT del importador
    /// </summary>
    [StringLength(1)]
    public string? ImportadorDV { get; set; }

    /// <summary>
    /// Primer apellido del importador
    /// </summary>
    [StringLength(30)]
    public string? ImportadorPrimerApellido { get; set; }

    /// <summary>
    /// Segundo apellido del importador
    /// </summary>
    [StringLength(30)]
    public string? ImportadorSegundoApellido { get; set; }

    /// <summary>
    /// Primer nombre del importador
    /// </summary>
    [StringLength(30)]
    public string? ImportadorPrimerNombre { get; set; }

    /// <summary>
    /// Los demas nombre compuestos del importador
    /// </summary>
    [StringLength(50)]
    public string? ImportadorOtrosNombres { get; set; }

    /// <summary>
    /// Nombre de la razón social del importador tal como este registrada en el RUT
    /// </summary>
    [StringLength(200)]
    public string? ImportadorRazonSocial { get; set; }

    /// <summary>
    /// Código de la dirección seccioinal de aduanas
    /// </summary>
    [StringLength(50)]
    public string? DG_CodigoSeccional { get; set; }

    /// <summary>
    /// Número de aceptación asignado a la declaración de importación
    /// </summary>
    [StringLength(20)]
    public string? DG_NumeroDeclarcionImp { get; set; }

    /// <summary>
    /// Fecha de presentación y aceptación registrada en la declaración de importación
    /// </summary>
    [StringLength(10)]
    public string? DG_FechaDeclaraciónImp { get; set; }

    /// <summary>
    /// Código del tipo de declaración de importación así: 1. Inicial 2. Legalización 3. Anticipada 4. Correción 5. Modificación
    /// </summary>
    public byte? DG_TipoDeclaracionImp { get; set; }

    /// <summary>
    /// Código de la posición comercial del comprador en el mercado nacional de acuerdo a la siguiente clasificación: 1. Mayorista. 2. Minorista. 3. Usuario final. 4. Otro.
    /// </summary>
    public byte? DG_CodigoNivelComercialComprador { get; set; }

    /// <summary>
    /// Indique el nivel comercial del comprador en el caso en que en la casilla 28 se haya consignado el código 4 &quot;Otro&quot;.
    /// </summary>
    [StringLength(50)]
    public string? DG_Especifique_CNCC { get; set; }

    /// <summary>
    /// Código de la condición del vendedor, que hace referencia a la forma como actúa, de acuerdo a la siguiente clasificación: 1. Fabricante. 2. Distribuidor (Dealer). 3. Otro.
    /// </summary>
    [StringLength(2)]
    public string? DG_CodigoCondicionVendedor { get; set; }

    /// <summary>
    /// Indique la condición del vendedor en el caso en que en la casilla 30 se haya respondido el código 3, &quot;Otro&quot;.
    /// </summary>
    [StringLength(50)]
    public string? DG_Especifique_CCV { get; set; }

    /// <summary>
    /// Número de la resolución expedida por la autoridad aduanera
    /// </summary>
    [StringLength(20)]
    public string? DG_ResolucionNumero { get; set; }

    /// <summary>
    /// Año, mes y día en que fue expedida la resolución
    /// </summary>
    [StringLength(10)]
    public string? DG_ResolucionFecha { get; set; }

    /// <summary>
    /// Concepto por el cual se expidió la resolución conforme a lo siguiente: 1. Ajuste de valor permanente. 2. Declaración simplificada.
    /// </summary>
    [StringLength(1)]
    public string? DG_CodigoTipoResolucion { get; set; }

    /// <summary>
    /// Indica el código que mejor refleje las
    /// condiciones en las que se efectuó la negociación, se adquirió la mercancía o la razón
    /// por la que se realiza la importación, según la siguiente tabla:
    /// 11.	 Compraventa a precio firme para exportación a Colombia.
    /// 12.	 Compraventa a precio revisable para exportación a Colombia.
    /// 13.	 Compraventa para uso en el exterior y posterior exportación.
    /// 14.	 Suministros gratuitos (Regalos, muestras, material publicitario).
    /// 15.	 Reparación o transformación.
    /// 16.	 Importación de mercancías efectuada por sucursales, provenientes directa o
    /// indirectamente de su casa principal.
    /// 17.	 Entrega bajo consignación, para la venta a la vista o a prueba.
    /// 18.	 Intercambio compensado.
    /// 19.	 Arrendamiento financiero (Alquiler con opción de compra o leasing).
    /// 20.	 Alquiler simple, arrendamiento operativo.
    /// 21.	 Sustitución de mercancías devueltas.
    /// 22.	 Sustitución de mercancías no devueltas (Bajo garantía).
    /// 23. 	 Mercancías suministradas en el marco de programas de ayuda, promovidos o
    /// financiados total o parcialmente por la Comunidad Andina.
    /// 24.	 Otras ayudas gubernamentales.
    /// 25.	 Otras ayudas (Privadas, organizaciones no gubernamentales).
    /// 26.	 Operaciones en el marco de programas intergubernamentales de fabricación
    /// conjunta.
    /// 27.	 Suministros parciales de materiales y/o maquinaria en el marco de un contrato
    /// general de construcción (envíos parciales)
    /// 28.	 Préstamo, comodato.
    /// 29.	 Otras transacciones (Especifique).
    /// Cuando la negociación corresponda a códigos diferentes a 11 ó 12, no podrá valorarse
    /// con el Método del Valor de Transacción; en consecuencia, no se diligenciarán las
    /// casillas 56 a 66 y 78 a 136. Si la negociación es una compraventa pero no cumple
    /// con todos los requisitos para valorar con el primer método se diligencian las casillas
    /// 1 a 92.
    /// </summary>
    public byte? DG_CodigoNaturalezaTransaccion { get; set; }

    /// <summary>
    /// Indica si la mercancía declarada corresponde a un envío
    /// único o fraccionado y/o a un valor total o fraccionado, de acuerdo con la siguiente
    /// codificación:	
    /// 1.	 Envío único o total y valor total.	
    /// 2. 	 Envío único o total y valor fraccionado.	
    /// 3. 	 Envío fraccionado y valor total.	
    /// 4. 	 Envío fraccionado y valor fraccionado.
    /// </summary>
    public byte? DG_CodigoFormaEnvio { get; set; }

    /// <summary>
    /// Indica las condiciones de entrega según
    /// los códigos que se relacionan a continuación:
    /// EXW	 En fábrica
    /// FCA 	 Franco transportista
    /// FAS 	 Franco al costado del buque
    /// FOB 	 Franco a bordo
    /// CFR 	 Coste y flete
    /// CIF 	 Coste, seguro y flete
    /// CPT 	 Coste y flete
    /// CIP 	 Coste, seguro y flete
    /// DAF 	 Lugar de entrega convenido en la frontera
    /// DES 	 Entregada sobre buque
    /// DEQ 	 Franco sobre muelle
    /// DDU	 Entregada con derechos no pagados
    /// DDP 	 Entregada con derechos pagados	
    /// En caso de negociar en una condición de entrega diferente a las anteriores, indique
    /// la que corresponda.
    /// </summary>
    [StringLength(3)]
    public string? DG_CondicionEntrega { get; set; }

    /// <summary>
    /// Indica el nombre del sitio, lugar, puerto o aeropuerto, pactado para la entrega de las mercancías.
    /// </summary>
    [StringLength(100)]
    public string? DG_Lugar { get; set; }

    /// <summary>
    /// Indica el código del país en donde se embarcó la mercancía para su exportación a Colombia.
    /// </summary>
    [StringLength(3)]
    public string? DG_CodigoPaisProcedencia { get; set; }

    /// <summary>
    /// Indica el número de la factura comercial expedida por el vendedor o proveedor, como soporte de la negociación y que contiene los pagos efectuados o por efectuar por el comprador al vendedor.
    /// </summary>
    [StringLength(50)]
    public string? DG_FacturaNumero { get; set; }

    /// <summary>
    /// Registro del año, mes y día en que fue expedida la factura
    /// </summary>
    [StringLength(10)]
    public string? DG_FacturaFecha { get; set; }

    /// <summary>
    /// Si existe contrato o documento que registre o de cuenta de la transacción y los términos de la negociación, indíquelo.
    /// Por ejemplo:
    /// Compraventa (Verbal o escrito), leasing, arrendamiento simple, etc..
    /// </summary>
    [StringLength(50)]
    public string? DG_ContratoTipo { get; set; }

    /// <summary>
    /// Número del contrato o documento indicado en la casilla 42, en caso de existir.
    /// </summary>
    [StringLength(50)]
    public string? DG_ContratoNumero { get; set; }

    /// <summary>
    /// Año mes y día correspondiente a la fecha del contrato u otro documento
    /// </summary>
    [StringLength(10)]
    public string? DG_ContratoFecha { get; set; }

    /// <summary>
    /// Es el valor total del contrato o documento citado en la moneda y términos de negociación.
    /// </summary>
    public long? DG_ContratoValor { get; set; }

    /// <summary>
    /// Registre en la moneda de negociación el valor total de la transacción en términos FOB Si la negociación se cumplió en un término diferente a éste, realice los ajustes a que haya lugar para llevarlo a FOB.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DG_ValorFOB { get; set; }

    /// <summary>
    /// Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.
    /// </summary>
    [StringLength(3)]
    public string? DG_CodigoMoneda1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DG_TipoCambio1 { get; set; }

    /// <summary>
    /// Corresponde a la fecha del tipo de cambio utilizado
    /// </summary>
    [StringLength(10)]
    public string? DG_FechaTipoCambio1 { get; set; }

    /// <summary>
    /// Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.
    /// </summary>
    [StringLength(3)]
    public string? DG_CodigoMoneda2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DG_TipoCambio2 { get; set; }

    /// <summary>
    /// Corresponde a la fecha del tipo de cambio utilizado
    /// </summary>
    [StringLength(10)]
    public string? DG_FechaTipoCambio2 { get; set; }

    /// <summary>
    /// Indica el código de la moneda en la que se realizó la negociación de la mercancía, según factura comercial o documento que refleje la negociación.
    /// </summary>
    [StringLength(3)]
    public string? DG_CodigoMoneda3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DG_TipoCambio3 { get; set; }

    /// <summary>
    /// Corresponde a la fecha del tipo de cambio utilizado
    /// </summary>
    [StringLength(10)]
    public string? DG_FechaTipoCambio3 { get; set; }

    /// <summary>
    /// Indica si la transacción se realizó con participación de algún intermediario denominado también agente, comisionista u otro.
    /// Consignar “S” si la respuesta es afirmativa o “N” si es negativa.
    /// </summary>
    [StringLength(1)]
    public string? IM_ExisteIntermediación { get; set; }

    /// <summary>
    /// Si la respuesta es afirmativa, señale la clase de intermediación utilizando los códigos de la tabla siguiente:
    /// 1. Agente de venta.
    /// 2. Agente de compra.
    /// 3. Corredor (Broker).
    /// 4. Otros tipos de intermediación.
    /// </summary>
    [StringLength(1)]
    public string? IM_CodigoTipoIntermediario { get; set; }

    /// <summary>
    /// Sí en la casilla anterior consignó el código correspondiente a “Otros tipos de intermediación”, indique cuál.
    /// </summary>
    [StringLength(100)]
    public string? IM_Especifique { get; set; }

    /// <summary>
    /// Registre el primer apellido del intermediario.
    /// </summary>
    [StringLength(30)]
    public string? IM_PrimerApellido { get; set; }

    /// <summary>
    /// Registre el segundo apellido del intermediario.
    /// </summary>
    [StringLength(30)]
    public string? IM_SegundoApellido { get; set; }

    /// <summary>
    /// Registre el primer nombre del intermediario.
    /// </summary>
    [StringLength(30)]
    public string? IM_PrimerNombre { get; set; }

    /// <summary>
    /// En caso de tener nombres compuestos registre los demás nombres.
    /// </summary>
    [StringLength(50)]
    public string? IM_OtrosNombres { get; set; }

    /// <summary>
    /// Razón social del intermediario.
    /// </summary>
    [StringLength(200)]
    public string? IM_RazonSocial { get; set; }

    /// <summary>
    /// Dirección domiciliaria del intermediario.
    /// </summary>
    [StringLength(200)]
    public string? IM_Direccion { get; set; }

    /// <summary>
    /// Nombre de la localidad o lugar donde se encuentra domiciliado el intermediario.
    /// </summary>
    [StringLength(100)]
    public string? IM_Ciudad { get; set; }

    /// <summary>
    /// Código del país correspondiente a la ciudad del domicilio del intermediario.
    /// </summary>
    [StringLength(3)]
    public string? IM_CodigoPais { get; set; }

    /// <summary>
    /// Indica si existen restricciones para la cesión o utilización de las mercancías por el comprador después de su importación, de conformidad con lo señalado en el artículo 10 del Reglamento Comunitario, adoptado por la Resolución Andina 846. Responda afirmativamente registrando una “S” cuando existan limitaciones para la cesión o utilización de las mercancías, como por ejemplo: Prohibición de vender las mercancías: exigencia de utilizarlas sólo como muestra o con fines publicitarios. En caso contrario registre “N”.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExistenRestricciones { get; set; }

    /// <summary>
    /// Código que identifica el tipo de restricción pactado en la negociación de la mercancía importada.
    /// Cód	 Restricción
    /// 01	 Impuestas o exigidas por la ley o las autoridades colombianas.
    /// 02	 Limitan el territorio geográfico donde puedan revenderse las mercancías.
    /// 03	 No afectan sustancialmente el valor de las mercancías.
    /// 04	 Otro tipo de restricciones.
    /// </summary>
    [StringLength(2)]
    public string? RQ_CodigoTipoRestricción { get; set; }

    /// <summary>
    /// Registre “S” si la venta o el precio de la mercancía dependen de alguna exigencia especial impuesta por el vendedor; por ejemplo, asumir obligaciones adicionales en relación con la forma pago del precio de la mercancía (Regalías, repartos de beneficios, pagos indirectos, pagos anticipados), obligaciones adicionales (Compra de la mercancía y otra) o aquellas que resultan de obligaciones recíprocas (Relacionadas con la producción o comercialización de la mercancía). En caso contrario, registre “N”.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExistenCondiciones { get; set; }

    /// <summary>
    /// código del tipo de condición o contraprestación según la tabla contenida en la descripción de la casilla 82 de la DAV en la cartilla de instrucciones de la Declaración de Importación y Andina del Valor
    /// </summary>
    [StringLength(50)]
    public string? RQ_CodigoTipoCondicion { get; set; }

    /// <summary>
    /// Si en la casilla anterior registró el código 09 Otro tipo de condiciones
    /// </summary>
    [StringLength(100)]
    public string? RQ_Especifique { get; set; }

    /// <summary>
    /// Indica si puede determinarse el importe de las prestaciones o contraprestaciones, registrando “S” si puede determinarse o “N” en caso contrario. Si la respuesta es afirmativa y éstas correspondan a pagos indirectos o condiciones o contraprestaciones diferentes a cánones y reversiones, registre el importe en la casilla 95 si la moneda de facturación  es diferente al dólar o en la casilla 96 si está negociada en esta moneda
    /// </summary>
    [StringLength(1)]
    public string? RQ_PuedeDeterminarseElValorCondicion { get; set; }

    /// <summary>
    /// Registre “S” si el comprador debe pagar directa o indirectamente a su vendedor un canon (Regalía) por el derecho de utilizar un procedimiento industrial patentado y/o una marca extranjera de fábrica o de comercio. Es preciso que esta obligación se haya establecido como condición de venta y esté relacionada con las mercancías importadas. En caso positivo indique su importe en la casilla 110 y/o 111 dependiendo de la moneda de facturación.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExistenCanones { get; set; }

    /// <summary>
    /// Indique “S” si existe un pacto según el cual el comprador está obligado a revertir al vendedor, directa o indirectamente, parte del producto de la reventa, cesión o utilización posterior de las mercancías. En caso contrario registre “N”. Si la respuesta es afirmativa, indique su importe en la casilla 112 si la moneda de facturación es diferente al dólar o 113 si está negociada en esta moneda.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExistenReversiones { get; set; }

    /// <summary>
    /// Consigne “S” si existe vinculación entre el comprador y el vendedor y “N” en caso contrario.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExisteVinculacion { get; set; }

    /// <summary>
    /// Registre el código que corresponda según una de las siguientes situaciones:
    /// 1. Si una de estas personas ocupa cargos de responsabilidad o dirección en una empresa de la otra;
    /// 2. Si están legalmente reconocidas como asociadas en negocios;
    /// 3. Si están en relación de empleador y empleado;
    /// 4. Si una persona tiene directa o indirectamente la propiedad, el control o la posesión del 5% o más de las acciones o títulos en circulación y con derecho a voto;
    /// 5. Si una de ellas controla directa o indirectamente a la otra;
    /// 6. Si ambas personas están controladas directa o indirectamente por una tercera;
    /// 7. Si juntas controlan directa o indirectamente a una tercera persona; ú,
    /// 8. Si son marido y mujer, hijos, padres, hermanos, nietos, abuelos, tío o tía y sobrino o sobrina, suegros y yerno o nuera, cuñados y cuñadas.
    /// </summary>
    public byte? RQ_CodigoTipoVinculación { get; set; }

    /// <summary>
    /// Consigne “S” si la vinculación influyó en el precio de las mercancías y “N” en caso contrario.
    /// </summary>
    [StringLength(1)]
    public string? RQ_InfluyeVinculacionPrecioMercancia { get; set; }

    /// <summary>
    /// Si la respuesta en la casilla anterior es “N” y conoce la existencia de valores criterio puede optar por contestar esta pregunta, que aunque es potestativa el aporte de la información permitirá decidir sobre la determinación del valor en aduana por el primer método de valoración (Art.15, del Reglamento Comunitario). Nota: Si decide no responder esta casilla anúlela con un guión, en cuyo caso las casillas 91 y 92 deberán ser también anuladas.
    /// </summary>
    [StringLength(1)]
    public string? RQ_ExistenValoresCriterio { get; set; }

    /// <summary>
    /// Registre el número de aceptación de la declaración de importación que refleja el valor criterio.
    /// </summary>
    [StringLength(20)]
    public string? RQ_DeclaracionImportacionNumero { get; set; }

    /// <summary>
    /// Indica la fecha de la declaración de importación citada en la casilla anterior.
    /// </summary>
    [StringLength(10)]
    public string? RQ_DeclaracionImportacionFecha { get; set; }

    /// <summary>
    /// Indique el importe neto, en la moneda de negociación,para la mercancía a declarar, que aparece en la factura comercial o documento que haga sus veces, expresado en el término de entrega en que se ha efectuado la transacción según la casilla 37. Si la declaración corresponde a parte de la mercancía que ampara la factura, y ha sufrido un descuento, el precio neto por la  cantidad que se declara debe incluir el valor de los descuentos que proporcionalmente correspondan.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrecioNetoSegunFactura { get; set; }

    /// <summary>
    /// Indique el importe neto, en la moneda de negociación,para la mercancía a declarar, que aparece en la factura comercial o documento que haga sus veces, expresado en el término de entrega en que se ha efectuado la transacción según la casilla 37. Si la declaración corresponde a parte de la mercancía que ampara la factura, y ha sufrido un descuento, el precio neto por la  cantidad que se declara debe incluir el valor de los descuentos que proporcionalmente correspondan.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrecioNetoSegunFacturaUSD { get; set; }

    /// <summary>
    /// Indica el importe de los pagos indirectos, descuentos retroactivos, descuentos que no cumplan los requisitos señalados en la norma o los pagos anticipados que no figuran en la factura comercial.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PagosIndirectosDescuentosRetroactivosUOtros { get; set; }

    /// <summary>
    /// Indica el importe de los pagos indirectos, descuentos retroactivos, descuentos que no cumplan los requisitos señalados en la norma o los pagos anticipados que no figuran en la factura comercial.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PagosIndirectosDescuentosRetroactivosUOtrosUSD { get; set; }

    /// <summary>
    /// Corresponde a la sumatoria de las casillas 94 y 96
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrecioPagadoOPorPagarUSD { get; set; }

    /// <summary>
    /// Indica el importe de las comisiones de venta, pagadas por el comprador al agente o representante del vendedor extranjero y/o los gastos de corretaje, siempre que no estén incluidas en el precio pagado o por pagar por las mercancías importadas. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_ComisionesCorretajes { get; set; }

    /// <summary>
    /// Indica el importe de las comisiones de venta, pagadas por el comprador al agente o representante del vendedor extranjero y/o los gastos de corretaje, siempre que no estén incluidas en el precio pagado o por pagar por las mercancías importadas. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_ComisionesCorretajesUSD { get; set; }

    /// <summary>
    /// Indica el valor pagado por los continentes interiores (envases) y exteriores (embalajes) destinados a preparar las mercancías para su transporte. Incorpora el valor pagado por concepto de los recipientes que la contienen de manera definitiva o temporal; el material utilizado, la mano de obra empleada y demás gastos necesarios para efectuar dichas operaciones, siempre que tales valores no estén incluidos en el precio facturado por dichas mercancías.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_EnvasesEmbalajes { get; set; }

    /// <summary>
    /// Indica el valor pagado por los continentes interiores (envases) y exteriores (embalajes) destinados a preparar las mercancías para su transporte. Incorpora el valor pagado por concepto de los recipientes que la contienen de manera definitiva o temporal; el material utilizado, la mano de obra empleada y demás gastos necesarios para efectuar dichas operaciones, siempre que tales valores no estén incluidos en el precio facturado por dichas mercancías.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_EnvasesEmbalajesUSD { get; set; }

    /// <summary>
    /// Indique el valor de los materiales, piezas y elementos, partes y artículos análogos incorporados a las mercancías importadas, suministradas directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesMateriasPrimas { get; set; }

    /// <summary>
    /// Indique el valor de los materiales, piezas y elementos, partes y artículos análogos incorporados a las mercancías importadas, suministradas directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesMateriasPrimasUSD { get; set; }

    /// <summary>
    /// Indica el valor de las herramientas, matrices, moldes y elementos análogos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesHerramientasMatricesMoldes { get; set; }

    /// <summary>
    /// Indica el valor de las herramientas, matrices, moldes y elementos análogos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesHerramientasMatricesMoldesUSD { get; set; }

    /// <summary>
    /// Indique el valor de los materiales e insumos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar. Estos materiales se consumen en la producción.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesIinsumos { get; set; }

    /// <summary>
    /// Indique el valor de los materiales e insumos utilizados para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar. Estos materiales se consumen en la producción.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesIinsumosUSD { get; set; }

    /// <summary>
    /// Indica el valor de los trabajos de ingeniería, creación y perfeccionamiento, planos, diseños, croquis y otros que se realicen fuera del país de importación y necesarios para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesIngenieriaCreacionPlanos { get; set; }

    /// <summary>
    /// Indica el valor de los trabajos de ingeniería, creación y perfeccionamiento, planos, diseños, croquis y otros que se realicen fuera del país de importación y necesarios para la producción de las mercancías importadas, suministrados directa o indirectamente por el importador al vendedor, siempre que dicho valor no esté incluido en el precio realmente pagado o por pagar.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_PrestacionesIngenieriaCreacionPlanosUSD { get; set; }

    /// <summary>
    /// Si contestó afirmativamente la casilla 85, registre el importe de los cánones o derechos de licencia. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_CanonesDerechosLicencia { get; set; }

    /// <summary>
    /// Si contestó afirmativamente la casilla 85, registre el importe de los cánones o derechos de licencia. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_CanonesDerechosLicenciaUSD { get; set; }

    /// <summary>
    /// Si contestó afirmativamente la casilla 86, registre el importe de la parte que revierte al proveedor extranjero como producto de
    /// la reventa, cesión o utilización de la mercancía. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_ProductoReventaCesionUtilización { get; set; }

    /// <summary>
    /// Si contestó afirmativamente la casilla 86, registre el importe de la parte que revierte al proveedor extranjero como producto de
    /// la reventa, cesión o utilización de la mercancía. Si este valor es estimado indíquelo en la casilla 136.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_ProductoReventaCesionUtilizaciónUSD { get; set; }

    /// <summary>
    /// En las casillas contiguas al número 20 preimpreso, indique
    /// el código del lugar de importación, entendiéndose como tal la primera Dirección Seccional de Aduanas, Impuestos y Aduanas o Delegada del territorio nacional en la que la mercancía deba ser sometida a las primeras formalidades aduaneras. El código será tomado de los registrados en las tablas ubicadas al final de la cartilla Declaración de Importación y Andina del Valor.
    /// </summary>
    [StringLength(2)]
    public string? VA_LugarImportacion { get; set; }

    /// <summary>
    /// Indique el importe correspondiente a los gastos en que incurrió o que fueron certificados de acuerdo con las tarifas normalmente aplicables, ocasionados por el traslado, manejo y entrega de la mercancía desde el lugar de entrega en el exterior hasta el lugar de embarque.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosTransporteManejoEntregaExterior { get; set; }

    /// <summary>
    /// Indique el importe correspondiente a los gastos en que incurrió o que fueron certificados de acuerdo con las tarifas normalmente aplicables, ocasionados por el traslado, manejo y entrega de la mercancía desde el lugar de entrega en el exterior hasta el lugar de embarque.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosTransporteManejoEntregaExteriorUSD { get; set; }

    /// <summary>
    /// Indica el importe de los fletes y de otros gastos pagados relacionados con el traslado de la mercancía desde el lugar de embarque hasta el lugar de importación, o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosTransporteDesdeElLugarEmbarque { get; set; }

    /// <summary>
    /// Indica el importe de los fletes y de otros gastos pagados relacionados con el traslado de la mercancía desde el lugar de embarque hasta el lugar de importación, o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosTransporteDesdeElLugarEmbarqueUSD { get; set; }

    /// <summary>
    /// Indica el importe de los gastos de carga, descarga y manipulación pagados y necesarios para colocar o retirar la mercancía del medio de transporte. Los gastos ocasionados por estos servicios, que
    /// hayan sido prestados en el lugar de importación y no figuren en el documento de transporte o en la factura no se registrarán en esta casilla.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosCargaDescargaManipulación { get; set; }

    /// <summary>
    /// Indica el importe de los gastos de carga, descarga y manipulación pagados y necesarios para colocar o retirar la mercancía del medio de transporte. Los gastos ocasionados por estos servicios, que
    /// hayan sido prestados en el lugar de importación y no figuren en el documento de transporte o en la factura no se registrarán en esta casilla.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosCargaDescargaManipulaciónUSD { get; set; }

    /// <summary>
    /// Indica el importe correspondiente al costo de seguro, desde el lugar de entrega de la mercancía hasta el puerto o lugar de importación de acuerdo con los documentos soporte o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_Seguro { get; set; }

    /// <summary>
    /// Indica el importe correspondiente al costo de seguro, desde el lugar de entrega de la mercancía hasta el puerto o lugar de importación de acuerdo con los documentos soporte o cuando corresponda, a los que fueron certificados de acuerdo con las tarifas normalmente aplicables, teniendo en cuenta lo señalado en el artículo 28.3 del Reglamento Comunitario adoptado por la Resolución Andina 846.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_SeguroUSD { get; set; }

    /// <summary>
    /// Corresponde a la sumatoria de los valores registrados en las casillas 99 a 122, columna &quot;USD&quot;.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_TotalAdiciones { get; set; }

    /// <summary>
    /// Indica los gastos de entrega de las mercancías que se ocasionen después del lugar de importación.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosEntregaPosterioresIimportacion { get; set; }

    /// <summary>
    /// Indica los gastos de entrega de las mercancías que se ocasionen después del lugar de importación.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosEntregaPosterioresIimportacionUSD { get; set; }

    /// <summary>
    /// Indique los gastos realizados después de la importación en relación con construcción, armado, instalación, montaje, mantenimiento y asistencia técnica de las mercancías importadas. Este rubro deberá tomarse en cuenta, entre otros casos, cuando se trate de maquinarias o equipos industriales.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosConstruccionArmadoInstalacionMontajeMantenimiento { get; set; }

    /// <summary>
    /// Indique los gastos realizados después de la importación en relación con construcción, armado, instalación, montaje, mantenimiento y asistencia técnica de las mercancías importadas. Este rubro deberá tomarse en cuenta, entre otros casos, cuando se trate de maquinarias o equipos industriales.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_GastosConstruccionArmadoInstalacionMontajeMantenimientoUSD { get; set; }

    /// <summary>
    /// Indica el importe de los derechos e impuestos causados con la importación, en el caso de haber negociado la mercancía con una condición de entrega según la cual el precio incluye en su totalidad o en parte los tributos aduaneros.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_DerechosAduanaOtrosImpuestos { get; set; }

    /// <summary>
    /// Indica el importe de los derechos e impuestos causados con la importación, en el caso de haber negociado la mercancía con una condición de entrega según la cual el precio incluye en su totalidad o en parte los tributos aduaneros.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_DerechosAduanaOtrosImpuestosUSD { get; set; }

    /// <summary>
    /// Indica el importe de los intereses que deben ser pagados, en virtud de un acuerdo de financiación concertado por el importador con el proveedor, relativos a la compra de las mercancías importadas siempre que se distingan del precio de la mercancía, estén incluidos en el precio pagado o por pagar por ellas y el tipo de interés reclamado no exceda del nivel aplicado a este tipo de transacciones en Colombia.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_Intereses { get; set; }

    /// <summary>
    /// Indica el importe de los intereses que deben ser pagados, en virtud de un acuerdo de financiación concertado por el importador con el proveedor, relativos a la compra de las mercancías importadas siempre que se distingan del precio de la mercancía, estén incluidos en el precio pagado o por pagar por ellas y el tipo de interés reclamado no exceda del nivel aplicado a este tipo de transacciones en Colombia.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_InteresesUSD { get; set; }

    /// <summary>
    /// Indique el importe de otros gastos que conforme a las normas de valoración no se consideran parte del valor en aduana y que se encuentren incluidos en el precio pagado o por pagar. (Artículo 31 del Reglamento Comunitario).
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_OtrosGastos { get; set; }

    /// <summary>
    /// Indique el importe de otros gastos que conforme a las normas de valoración no se consideran parte del valor en aduana y que se encuentren incluidos en el precio pagado o por pagar. (Artículo 31 del Reglamento Comunitario).
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_OtrosGastosUSD { get; set; }

    /// <summary>
    /// Corresponde a la sumatoria de los valores registrados en las casillas 125 a 133, columna &quot;USD&quot;.
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_TotalDeducciones { get; set; }

    /// <summary>
    /// Es el valor en aduana que declara el importador y que constituye la base gravable de las mercancías importadas.
    /// Se calcula de la siguiente manera:
    /// Valor de transacción declarado = Precio Pagado o por Pagar (97) + Adiciones (123) - Deducciones (134)
    /// </summary>
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? VA_ValorTransaccionDeclarado { get; set; }

    /// <summary>
    /// Indica “S” si en la presente Declaración, el importe consignado por Comisiones, &quot;Cánones y derechos de licencia&quot; o por cualquier producto de la reventa, cesión o utilización posterior de las mercancías que revierten directa o indirectamente al vendedor extranjero es provisional en caso contrario registre “N”.
    /// </summary>
    [StringLength(1)]
    public string? VA_TieneCaracterProvisional { get; set; }

    /// <summary>
    /// Escriba el Número de Identificación Tributaria, sin el dígito de verificación, asignado por la DIAN a quien firma la declaración 	
    /// y está obligado a tenerlo. 
    /// </summary>
    [StringLength(15)]
    public string? SN_NIT { get; set; }

    /// <summary>
    /// Escriba el número que en el NIT se encuentra separado llamado “Dígito de Verificación” (DV).
    /// </summary>
    [StringLength(1)]
    public string? SN_DV { get; set; }

    /// <summary>
    /// Registre el primer apellido de quien firma la declaración
    /// </summary>
    [StringLength(30)]
    public string? SN_PrimerApellido { get; set; }

    /// <summary>
    /// Registre el segundo apellido de quien firma la declaración.
    /// </summary>
    [StringLength(30)]
    public string? SN_SegundoApellido { get; set; }

    /// <summary>
    /// Registre el primer nombre de quien firma la declaración.
    /// </summary>
    [StringLength(30)]
    public string? SN_PrimerNombre { get; set; }

    /// <summary>
    /// En caso de tener nombres compuestos registre los demás.
    /// </summary>
    [StringLength(50)]
    public string? SN_OtrosNombres { get; set; }

    [StringLength(50)]
    public string? fechaExpedicion { get; set; }
}
