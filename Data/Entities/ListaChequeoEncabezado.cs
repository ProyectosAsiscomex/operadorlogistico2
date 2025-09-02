using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("ListaChequeoEncabezado")]
public partial class ListaChequeoEncabezado
{
    [Key]
    public int idListaChequeoEncabezado { get; set; }

    public int? idImportador { get; set; }

    public int? idAsesor { get; set; }

    public int? idAuxiliar { get; set; }

    public int? idTipoCarga { get; set; }

    [Unicode(false)]
    public string? MercaciaEn { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Fecha { get; set; }

    public int? idusuarioapertura { get; set; }

    public string? Observaciones { get; set; }

    [StringLength(250)]
    public string? Sellos { get; set; }

    public int? IdDO { get; set; }

    [InverseProperty("idListaChequeoEncabezadoNavigation")]
    public virtual ICollection<ActividadesListaChequeo> ActividadesListaChequeos { get; set; } = new List<ActividadesListaChequeo>();

    [InverseProperty("idListaChequeoEncabezadoNavigation")]
    public virtual ICollection<ChequeoEspesial> ChequeoEspesials { get; set; } = new List<ChequeoEspesial>();

    [InverseProperty("idListaChequeoEncabezadoNavigation")]
    public virtual ICollection<DocumentosListaChequeo> DocumentosListaChequeos { get; set; } = new List<DocumentosListaChequeo>();

    [ForeignKey("idAsesor")]
    [InverseProperty("ListaChequeoEncabezadoidAsesorNavigations")]
    public virtual usuario? idAsesorNavigation { get; set; }

    [ForeignKey("idAuxiliar")]
    [InverseProperty("ListaChequeoEncabezadoidAuxiliarNavigations")]
    public virtual usuario? idAuxiliarNavigation { get; set; }

    [ForeignKey("idTipoCarga")]
    [InverseProperty("ListaChequeoEncabezados")]
    public virtual tipocarga? idTipoCargaNavigation { get; set; }
}
