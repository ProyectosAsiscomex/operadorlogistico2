using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("documentoDetalle")]
public partial class documentoDetalle
{
    [Key]
    public int id { get; set; }

    /// <summary>
    /// Identificador dentro de la tabla documento
    /// </summary>
    public short idDocumento { get; set; }

    /// <summary>
    /// Nombre de la sección que compone el documento
    /// </summary>
    [StringLength(200)]
    public string descripcion { get; set; } = null!;

    /// <summary>
    /// Consulta SQL para recuperar la informacion de la seccion de la pagina
    /// </summary>
    public string query { get; set; } = null!;

    /// <summary>
    /// Cantidad de veces que aparece el dato dentro de la pagina
    /// </summary>
    public byte filasPorPagina { get; set; }

    /// <summary>
    /// tipo pagina esta entre los valores Frente o Dorso
    /// </summary>
    public byte tipoPagina { get; set; }

    /// <summary>
    /// Es la pagina en la que se encuentra la variable
    /// </summary>
    public byte numeroPagina { get; set; }

    public short? incrementoFilaDetalle { get; set; }

    [ForeignKey("idDocumento")]
    [InverseProperty("documentoDetalles")]
    public virtual documento idDocumentoNavigation { get; set; } = null!;
}
