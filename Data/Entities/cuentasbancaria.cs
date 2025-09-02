using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class cuentasbancaria
{
    [Key]
    public int idcuenta { get; set; }

    [StringLength(200)]
    public string? nrocuenta { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? idtipocuenta { get; set; }

    public int? idbanco { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? nit { get; set; }

    public int? solicito { get; set; }

    public int? aprobo { get; set; }

    public int? modifico { get; set; }

    public int? idempresa { get; set; }
}
