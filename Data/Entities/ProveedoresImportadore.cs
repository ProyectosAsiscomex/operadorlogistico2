using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class ProveedoresImportadore
{
    [Key]
    public int idProveeImpo { get; set; }

    public int? idimportador { get; set; }

    public int? idproveedor { get; set; }

    public int? idproducto { get; set; }
}
