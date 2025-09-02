using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("tb_tempProductoImpo")]
public partial class tb_tempProductoImpo
{
    [Key]
    public int id { get; set; }

    public string? query { get; set; }

    public int? idusuario { get; set; }
}
