using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("regimenprecedente")]
public partial class regimenprecedente
{
    [Key]
    public int idregimenprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? aduanaprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nrodeclaracionprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? añoaceptacion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codregprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codmodprecedente { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nroserieprecedente { get; set; }
}
