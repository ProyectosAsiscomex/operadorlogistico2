using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class VistosBuenosXSubpartidum
{
    [Key]
    public int idVistoSub { get; set; }

    public int? IdSubpartida { get; set; }

    public int? IdVistoBueno { get; set; }

    public bool? chk { get; set; }
}
