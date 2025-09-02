using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("exportadornegociacion")]
public partial class exportadornegociacion
{
    [Key]
    public int idnegociacion { get; set; }

    public int? identificacion { get; set; }

    public int? idexportador { get; set; }

    public bool? importaciones { get; set; }

    public bool? exportaciones { get; set; }

    public bool? transitosaduanero { get; set; }

    public bool? anticipoParagastos { get; set; }

    public bool? anticipoparaimpuestos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? formaPagoimpuestos { get; set; }
}
