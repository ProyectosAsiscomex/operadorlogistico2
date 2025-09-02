using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class CheckDocumento
{
    [Key]
    public int idCheckDocumentos { get; set; }

    public int? idimportador { get; set; }

    public int? idorden { get; set; }
}
