using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Signatario
{
    [Key]
    public int idsignatario { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? cedula { get; set; }

    public int? iddeclarante { get; set; }
}
