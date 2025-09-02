using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("AMX")]
public partial class AMX
{
    [Key]
    public int idTransmision { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? campo1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? campo2 { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? campo3 { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? campo4 { get; set; }

    [StringLength(22)]
    [Unicode(false)]
    public string? campo5 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? campo6 { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? campo7 { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? campo8 { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? campo9 { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? campo10 { get; set; }

    [StringLength(17)]
    [Unicode(false)]
    public string? campo11 { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? nrodo { get; set; }
}
