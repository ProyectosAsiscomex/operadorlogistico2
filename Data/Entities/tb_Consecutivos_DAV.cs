using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_Consecutivos_DAV")]
public partial class tb_Consecutivos_DAV
{
    [Key]
    public int id_consecutivo { get; set; }

    public int? codDeclarante { get; set; }

    public int? consecutivo { get; set; }

    public int? idaduana { get; set; }
}
