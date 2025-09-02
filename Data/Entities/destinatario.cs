using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("destinatario")]
public partial class destinatario
{
    [Key]
    public int iddestinatario { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? tipodocumento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? identificacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primerapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? segundoapellido { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? primernombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? otrosnombres { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? razonsocial { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string? domicilio { get; set; }

    public int? idpais { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ciudad { get; set; }

    public int? idexportador { get; set; }

    public int? calidadesaduaneras { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? contacto { get; set; }

    public bool? habilitarexpo { get; set; }
}
