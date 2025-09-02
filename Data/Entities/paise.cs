using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class paise
{
    [Key]
    public int idpais { get; set; }

    [StringLength(10)]
    public string? codigo { get; set; }

    [StringLength(50)]
    public string? nombre { get; set; }

    [StringLength(5)]
    public string? abreviatura { get; set; }

    [StringLength(4)]
    public string? CodigoDeclaracion { get; set; }

    [StringLength(10)]
    public string? CodigoImportaciones { get; set; }

    [StringLength(30)]
    public string? CodigoImpresion { get; set; }

    [InverseProperty("idPaisNavigation")]
    public virtual ICollection<Banco> Bancos { get; set; } = new List<Banco>();

    [InverseProperty("idPaisNavigation")]
    public virtual ICollection<CiudadesAduanimex> CiudadesAduanimexes { get; set; } = new List<CiudadesAduanimex>();
}
