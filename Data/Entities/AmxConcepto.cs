using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class AmxConcepto
{
    [Key]
    public int IdAmxConcepto { get; set; }

    public int? IdGastoConcepto { get; set; }

    [StringLength(200)]
    public string? Concepto { get; set; }
}
