using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("TempoCartera")]
public partial class TempoCartera
{
    public double? ccodi { get; set; }

    [StringLength(255)]
    public string? cnomb { get; set; }

    public double? tercero { get; set; }

    [StringLength(255)]
    public string? nomb_ter { get; set; }

    public double? ctele { get; set; }

    [StringLength(255)]
    public string? ffech { get; set; }

    [StringLength(255)]
    public string? prefijo { get; set; }

    public double? ffact { get; set; }

    public double? fvalo { get; set; }

    public double? fpago { get; set; }

    public double? frete_iva { get; set; }

    public double? fretefuen { get; set; }

    public double? valorreal { get; set; }

    public double? valorrealp { get; set; }

    public double? valorrealn { get; set; }

    public double? terceros { get; set; }

    [StringLength(255)]
    public string? cartera { get; set; }

    public double? val_dolar { get; set; }

    public int? idcliente { get; set; }

    public int? iddo { get; set; }

    [StringLength(50)]
    public string? nrodo { get; set; }

    public int? idimportador { get; set; }
}
