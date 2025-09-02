using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("subpartidaib")]
public partial class subpartidaib
{
    [Key]
    public int idsubpartidaib { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? subpartida { get; set; }

    [Unicode(false)]
    public string? descripcion { get; set; }

    [Unicode(false)]
    public string? unidaddian { get; set; }

    public int? idunidaddian { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? arancel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? iva { get; set; }
}
