using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("consignatario")]
public partial class consignatario
{
    [Key]
    public int idconsignatario { get; set; }

    [StringLength(500)]
    public string? descripcion { get; set; }

    [StringLength(50)]
    public string? codigo { get; set; }
}
