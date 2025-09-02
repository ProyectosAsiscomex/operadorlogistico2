using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class acuerdos_subpartida
{
    [Key]
    public int idacuerdossubpartida { get; set; }

    public int? ID_ACUERDO_SUBPARTIDA { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CODIGO_ACUERDO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CODIGO_POSICION { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PORCENTAJE_IVA { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PORCENTAJE_ARANCEL { get; set; }

    public int? id_acuerdo { get; set; }
}
