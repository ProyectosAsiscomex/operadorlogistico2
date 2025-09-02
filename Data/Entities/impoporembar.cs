using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class impoporembar
{
    [StringLength(200)]
    public string? embarcador { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? transportador { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? modotransporte { get; set; }

    [StringLength(50)]
    public string? paisorigen { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorfobusd { get; set; }

    [Column(TypeName = "money")]
    public decimal? valorflete { get; set; }

    public int? meslevante { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? empresa { get; set; }
}
