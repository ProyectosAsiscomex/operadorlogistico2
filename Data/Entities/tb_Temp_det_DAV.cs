using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_Temp_det_DAV")]
public partial class tb_Temp_det_DAV
{
    [Key]
    public int idtemp { get; set; }

    public int? idusuario { get; set; }

    public int? iddetalleDAV { get; set; }
}
