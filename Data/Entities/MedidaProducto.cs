using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class MedidaProducto
{
    public double? NIT { get; set; }

    [StringLength(255)]
    public string? REFERENCIA { get; set; }

    [StringLength(255)]
    public string? UNIDAD_COMERCIAL { get; set; }

    [StringLength(255)]
    public string? UNIDAD_CLIENTE { get; set; }

    public double? LARGO { get; set; }

    public double? ANCHO { get; set; }

    public double? ESPESOR { get; set; }

    public double? PESO { get; set; }

    [StringLength(255)]
    public string? FECHA_CREACION { get; set; }

    public int idmedida { get; set; }

    [Key]
    public int idmedidaprod { get; set; }
}
