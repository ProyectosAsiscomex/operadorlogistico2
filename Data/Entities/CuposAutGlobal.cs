using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CuposAutGlobal")]
public partial class CuposAutGlobal
{
    [Key]
    public int idCupoGlobal { get; set; }

    public int? idexportador { get; set; }

    public int? idsubpartida { get; set; }

    public int? idautorizacionembarque { get; set; }

    public int? iddatoserie { get; set; }

    [StringLength(40)]
    public string? NroAutGlobal { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? CantidadUnidadFisica { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? CantidadUsada { get; set; }

    [Column(TypeName = "decimal(20, 6)")]
    public decimal? CantidadDisponible { get; set; }

    [StringLength(5)]
    public string? Grupo { get; set; }

    public int? idunidadcomercial { get; set; }

    public int? iddestinatario { get; set; }
}
