using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class PagosChequeAutorizacione
{
    [Key]
    public int idautorizado { get; set; }

    [StringLength(3)]
    public string? sucursal { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    [StringLength(50)]
    public string? cedula { get; set; }

    [StringLength(100)]
    public string? ciudad { get; set; }
}
