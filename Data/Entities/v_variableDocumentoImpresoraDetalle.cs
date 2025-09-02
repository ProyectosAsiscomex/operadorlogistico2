using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class v_variableDocumentoImpresoraDetalle
{
    public int id { get; set; }

    public short? numeroVariable { get; set; }

    [StringLength(200)]
    public string? nombreVariable { get; set; }

    public short? posicionX { get; set; }

    public short? posicionY { get; set; }

    [StringLength(200)]
    public string nombreSeccion { get; set; } = null!;

    [StringLength(200)]
    public string? nombreCampo { get; set; }

    public short? anchoMaximo { get; set; }

    public short? idDocumento { get; set; }

    public int? idDocumentoDetalle { get; set; }

    public int idVariableDocumentoImpresora { get; set; }

    public short? anchoCasilla { get; set; }

    public short? alto { get; set; }

    [StringLength(50)]
    public string? alineacion { get; set; }
}
