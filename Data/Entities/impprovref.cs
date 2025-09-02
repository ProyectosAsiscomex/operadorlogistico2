using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("impprovref")]
public partial class impprovref
{
    [Key]
    public int idrel { get; set; }

    public int? importador { get; set; }

    [Column("ref")]
    [StringLength(500)]
    [Unicode(false)]
    public string? _ref { get; set; }

    public int? idproducto { get; set; }

    [Unicode(false)]
    public string? codigoprov { get; set; }

    [Unicode(false)]
    public string? idimportador { get; set; }

    public int? idexportador { get; set; }
}
