using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("DetalleArancelDO")]
public partial class DetalleArancelDO
{
    [Key]
    public int idDetalleArancelDo { get; set; }

    public int? idDo { get; set; }

    public int? idArancel { get; set; }
}
