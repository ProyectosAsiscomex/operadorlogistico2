using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class importadore
{
    [Key]
    public int idimportador { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? codigo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? nit { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? nombre { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? telefono { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? fax { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? direccion { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? correo { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? departamento { get; set; }

    [StringLength(100)]
    public string? representante { get; set; }

    [StringLength(50)]
    public string? cedula { get; set; }
}
