using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
[Table("variableDocumentoImpresora")]
public partial class variableDocumentoImpresora
{
    /// <summary>
    /// Número unico que identifica la variable para una impresora y documento especificos
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Número unico que identifica la impresora
    /// </summary>
    public byte idImpresora { get; set; }

    /// <summary>
    /// Número unico que identifica al documento
    /// </summary>
    public short idDocumento { get; set; }

    [ForeignKey("idDocumento")]
    public virtual documento idDocumentoNavigation { get; set; } = null!;
}
