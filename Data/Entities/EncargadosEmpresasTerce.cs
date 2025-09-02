using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EncargadosEmpresasTerce")]
public partial class EncargadosEmpresasTerce
{
    [Key]
    public int Idencargado { get; set; }

    public int? idtercero { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NombresEncargado { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Cargo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? TelefonoDirecto { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Celular { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ContactoAbreviado { get; set; }
}
