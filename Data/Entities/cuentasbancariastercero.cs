using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class cuentasbancariastercero
{
    [Key]
    public int idcuenta { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nrocuenta { get; set; }

    public int? idtipocuenta { get; set; }

    public int? idbanco { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nit { get; set; }

    public int? idtercero { get; set; }

    public int? idempresa { get; set; }
}
