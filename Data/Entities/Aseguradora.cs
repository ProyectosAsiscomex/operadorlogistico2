using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Aseguradora
{
    [Key]
    public int idaseguradora { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }

    [StringLength(200)]
    public string? nombre { get; set; }

    [StringLength(200)]
    public string? direccion { get; set; }

    [StringLength(100)]
    public string? telefono { get; set; }

    [StringLength(150)]
    public string? ciudad { get; set; }

    [StringLength(100)]
    public string? email { get; set; }

    [StringLength(100)]
    public string? contacto { get; set; }
}
