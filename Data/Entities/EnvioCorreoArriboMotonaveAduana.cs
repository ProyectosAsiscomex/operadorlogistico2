using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EnvioCorreoArriboMotonaveAduana")]
public partial class EnvioCorreoArriboMotonaveAduana
{
    [Key]
    public int idenvioaduana { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? idaduana { get; set; }

    public byte? idenviocorreoarribomotonave { get; set; }
}
