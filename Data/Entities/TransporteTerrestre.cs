using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("TransporteTerrestre")]
public partial class TransporteTerrestre
{
    [Key]
    public int idtransporteterrestre { get; set; }

    public int? idexportador { get; set; }

    public int? idpedido { get; set; }

    public int? idconsignatario { get; set; }

    public int? idtransportador { get; set; }

    public int? idvia { get; set; }

    public int? iddestino { get; set; }
}
