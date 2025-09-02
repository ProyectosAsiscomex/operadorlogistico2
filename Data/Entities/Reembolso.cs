using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Reembolso
{
    [Key]
    public int idreembolzo { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? formareembolzo { get; set; }

    [StringLength(500)]
    public string? descripcionregistro { get; set; }
}
