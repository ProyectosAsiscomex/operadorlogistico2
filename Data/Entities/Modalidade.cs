using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Modalidade
{
    [Key]
    public int idmodalidad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? codigomodalidad { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? nombremodalidad { get; set; }
}
