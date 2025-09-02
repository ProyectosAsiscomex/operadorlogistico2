using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Actividade
{
    [Key]
    public int idActividades { get; set; }

    public int? Orden { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Unicode(false)]
    public string? DescripcionActividad { get; set; }

    public int? Documento { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? presencia { get; set; }

    public bool? tieneDetalle { get; set; }

    public bool? tieneObservacion { get; set; }

    public bool? tienePendiente { get; set; }

    [StringLength(10)]
    public string? abreviatura { get; set; }

    [InverseProperty("idActividadNavigation")]
    public virtual ICollection<ActividadesListaChequeo> ActividadesListaChequeos { get; set; } = new List<ActividadesListaChequeo>();

    [ForeignKey("Documento")]
    [InverseProperty("Actividades")]
    public virtual TipoDocumento? DocumentoNavigation { get; set; }
}
