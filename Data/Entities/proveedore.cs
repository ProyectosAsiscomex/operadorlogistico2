using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class proveedore
{
    [Key]
    public int idproveedor { get; set; }

    [StringLength(200)]
    public string? codigo { get; set; }

    public string? nombre { get; set; }

    public string? direccion { get; set; }

    [StringLength(300)]
    public string? telefono { get; set; }

    [StringLength(300)]
    public string? fax { get; set; }

    public int? idmoneda { get; set; }

    public int? idpais { get; set; }

    [StringLength(300)]
    public string? CIUDAD { get; set; }

    [StringLength(300)]
    public string? correo { get; set; }

    [StringLength(300)]
    public string? contacto { get; set; }

    public int? idincoterm { get; set; }

    public int? idlugarembarque { get; set; }

    public int? terminosdenegociacion { get; set; }

    public int? idimportador { get; set; }

    public int? tipodocumento { get; set; }

    [StringLength(30)]
    public string? identificacion { get; set; }

    public int? DV { get; set; }

    [StringLength(50)]
    public string? Primernombre { get; set; }

    [StringLength(50)]
    public string? otrosnombres { get; set; }

    [StringLength(50)]
    public string? Primerapellido { get; set; }

    [StringLength(50)]
    public string? Segundoapellido { get; set; }

    public bool? habilitado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? CondicionProveedor { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Especifique { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? NombreContacto { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cargo { get; set; }

    public string? sigla { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? BD { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? idbd { get; set; }
}
