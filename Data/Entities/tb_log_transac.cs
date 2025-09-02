using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_log_transac")]
public partial class tb_log_transac
{
    [Key]
    public long idlog_transac { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? fecha_transac { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? accion_transac { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? mensaje_transac { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? usuario_transac { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? tabla_transac { get; set; }
}
