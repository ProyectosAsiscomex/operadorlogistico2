using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class unidade
{
    [Key]
    public int idunidad { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(30)]
    public string? abreviatura { get; set; }

    [StringLength(100)]
    public string? descripcion { get; set; }
}
