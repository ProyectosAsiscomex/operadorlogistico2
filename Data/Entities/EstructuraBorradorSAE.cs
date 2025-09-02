using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EstructuraBorradorSAE")]
public partial class EstructuraBorradorSAE
{
    [StringLength(50)]
    [Unicode(false)]
    public string? Auxiliar { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Factura { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodComp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodProd { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Posicion { get; set; }

    [StringLength(50)]
    public string? Cip { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Cantidad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Valorfob { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Flete { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Seguro { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Gastos { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PesoNeto { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Producto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Coduni { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Nombrecomp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Pais { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? Direcci { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CantCuadro { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UdeMCAM { get; set; }

    public int? idexportador { get; set; }

    [Key]
    public int Codigo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pesobruto { get; set; }

    public int? idfactura { get; set; }
}
