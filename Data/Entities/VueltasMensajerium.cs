using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class VueltasMensajerium
{
    [Key]
    public int idVuelta { get; set; }

    public int? idCliente { get; set; }

    public int? idTercero { get; set; }

    [StringLength(2000)]
    public string? FechaYhora { get; set; }

    public bool? Entrega { get; set; }

    public bool? Recoger { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    public bool? Documentos { get; set; }

    public bool? Cheque { get; set; }

    public bool? Otros { get; set; }

    [StringLength(3000)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? EmpresaEntidad { get; set; }

    [StringLength(2000)]
    [Unicode(false)]
    public string? DireccionYtelefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? fechaFinalizacion { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? horaFinalizacion { get; set; }
}
