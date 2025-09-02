using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class v_documentodetalle
{
    public int idDocumentoDetalle { get; set; }

    public short idDocumento { get; set; }

    [StringLength(200)]
    public string descripcion { get; set; } = null!;

    public string query { get; set; } = null!;

    public byte filasPorPagina { get; set; }

    public byte tipoPagina { get; set; }

    public byte numeroPagina { get; set; }

    public short? incrementoFilaDetalle { get; set; }
}
