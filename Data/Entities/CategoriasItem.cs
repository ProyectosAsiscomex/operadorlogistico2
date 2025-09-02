using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("CategoriasItem")]
public partial class CategoriasItem
{
    [Key]
    public int idcategoriaitem { get; set; }

    public int? idcategoria { get; set; }

    public int? idestado { get; set; }

    public int? diasduracion { get; set; }

    [StringLength(100)]
    public string? presencia { get; set; }

    public int? posicion { get; set; }

    public bool? Importacion_Aduanas { get; set; }

    public bool? Exportacion_Aduanas { get; set; }

    public bool? contenedores { get; set; }

    public bool? trafico { get; set; }

    public bool? inventario { get; set; }

    public bool? logistica_Impo { get; set; }

    public bool? logistica_Expo { get; set; }

    public bool? todos { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? agrupacion { get; set; }
}
