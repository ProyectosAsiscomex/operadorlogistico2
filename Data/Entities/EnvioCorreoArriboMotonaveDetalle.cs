using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EnvioCorreoArriboMotonaveDetalle")]
public partial class EnvioCorreoArriboMotonaveDetalle
{
    [Key]
    public int idenvioCorreoarribomotonavedetalle { get; set; }

    public int? idenviocorreoarribomotonave { get; set; }

    public int? idexportador { get; set; }
}
