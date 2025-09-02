using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleResponsablesDO")]
public partial class DetalleResponsablesDO
{
    [Key]
    public int idDetalleResponsablesDO { get; set; }

    public int? idDo { get; set; }

    public int? idComercial { get; set; }

    public int? idOperativo { get; set; }
}
