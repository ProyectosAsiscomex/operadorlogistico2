using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Municipio
{
    [Key]
    public int idMunicipio { get; set; }

    [StringLength(100)]
    public string? CodMunicipio { get; set; }

    [StringLength(500)]
    public string? NombreMunicipio { get; set; }

    [StringLength(100)]
    public string? CodDepartamento { get; set; }

    [StringLength(500)]
    public string? NombreDepartamento { get; set; }
}
