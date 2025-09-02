using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Documentos_Subpartidum
{
    [Key]
    public int idDocumentosubpartida { get; set; }

    public int idsubpartida { get; set; }

    public int idtipodocumentosoporte { get; set; }
}
