using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("OperacionesDO")]
public partial class OperacionesDO
{
    [Key]
    public int idOperacionDO { get; set; }

    public int? idDO { get; set; }

    public int? idregimenaduanero { get; set; }

    public int? idtipoembarque { get; set; }

    public int? idtipodatos { get; set; }

    public int? idtiposolicitud { get; set; }

    public int? idincoterm { get; set; }

    public int? idmodotransporte { get; set; }

    public bool? sistemasespeciales { get; set; }

    public int? idautorizacionembarque { get; set; }

    public bool? creado { get; set; }
}
