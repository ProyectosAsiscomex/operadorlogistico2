using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class vPlaneadorExportacione
{
    [StringLength(150)]
    [Unicode(false)]
    public string? pedido { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? numdoc { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechazarpe { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? fechafactura { get; set; }

    [StringLength(4000)]
    [Unicode(false)]
    public string? facturas { get; set; }
}
