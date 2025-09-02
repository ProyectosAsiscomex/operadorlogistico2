using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleContenedoresDO")]
public partial class DetalleContenedoresDO
{
    [Key]
    public int idDetalleContenedores { get; set; }

    public int? idDetalleConte { get; set; }

    public int? idDo { get; set; }

    public int? NroConte { get; set; }

    public int? idTamanoConetenedor { get; set; }

    public int? idTipoEquipo { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? NroContenedor { get; set; }
}
