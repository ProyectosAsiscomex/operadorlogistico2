using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("SucesosLectura")]
public partial class SucesosLectura
{
    [Key]
    public int idSucesosLectura { get; set; }

    public int? idSuceso { get; set; }

    public int? idusuario { get; set; }

    public int? idexportador { get; set; }
}
