using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("documento")]
public partial class documento
{
    /// <summary>
    /// Número unico que identifica el documento
    /// </summary>
    [Key]
    public short id { get; set; }

    /// <summary>
    /// Nombre del documento o formulario
    /// </summary>
    [StringLength(500)]
    public string nombre { get; set; } = null!;

    /// <summary>
    /// Nombre del procedimiento almacenado dentro de la base datos
    /// </summary>
    [StringLength(50)]
    public string campoFiltro { get; set; } = null!;

    /// <summary>
    /// Cantidad de paginas que conforman el documento o formulario
    /// </summary>
    public byte numeroPaginas { get; set; }

    [StringLength(50)]
    public string nombrePagina { get; set; } = null!;

    [InverseProperty("idDocumentoNavigation")]
    public virtual ICollection<documentoDetalle> documentoDetalles { get; set; } = new List<documentoDetalle>();
}
