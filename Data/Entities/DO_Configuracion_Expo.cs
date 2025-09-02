using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DO_Configuracion_Expo")]
public partial class DO_Configuracion_Expo
{
    [Key]
    public int idConfiguracion { get; set; }

    public int? Consecutivo { get; set; }

    public int? idSedeOperativa { get; set; }

    public bool? ModeloTotal { get; set; }

    public byte? ano { get; set; }
}
