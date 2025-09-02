using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("variableDocumentoImpresoraDetalle")]
public partial class variableDocumentoImpresoraDetalle
{
    /// <summary>
    /// Número unico que identifica el detalle para una impresora y documento especificos dentro la tabla variableDocumentoImpresora
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Número unico que identifica la variable para una impresora y documento especificos dentro la tabla variableDocumentoImpresora
    /// </summary>
    public int idVariableDocumentoImpresora { get; set; }

    public short? idDocumento { get; set; }

    /// <summary>
    /// Identificador del registro dentro de la tabla de documento detalle
    /// </summary>
    public int? idDocumentoDetalle { get; set; }

    /// <summary>
    /// Nombre de la etiqueta imprimir que tiene el documento o formulario
    /// </summary>
    [StringLength(200)]
    public string? nombreVariable { get; set; }

    /// <summary>
    /// Número de la posición de la variable en documento o formulario
    /// </summary>
    public short? numeroVariable { get; set; }

    /// <summary>
    /// Distancia en milimitros para el eje X de la variable
    /// </summary>
    public short? posicionX { get; set; }

    /// <summary>
    /// Distancia en milimitros para el eje Y de la variable
    /// </summary>
    public short? posicionY { get; set; }

    /// <summary>
    /// Nombre del campo, el cual va contener la información extraida de la BD y el procedimiento almacenado relacionado en tabla docuemto
    /// </summary>
    [StringLength(200)]
    public string? nombreCampo { get; set; }

    public short? anchoMaximo { get; set; }

    public short? anchoCasilla { get; set; }

    public short? alto { get; set; }

    [StringLength(50)]
    public string? alineacion { get; set; }

    [ForeignKey("idDocumentoDetalle")]
    public virtual documentoDetalle? idDocumentoDetalleNavigation { get; set; }
}
