using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("message")]
public partial class message
{
    [Key]
    public int message_id { get; set; }

    public int chat_id { get; set; }

    public int user_id { get; set; }

    [StringLength(64)]
    public string user_name { get; set; } = null!;

    [Column("message", TypeName = "ntext")]
    public string message1 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime post_time { get; set; }

    public int? idusuariosend { get; set; }

    public int? idusuarioreceive { get; set; }

    public bool? leido { get; set; }
}
