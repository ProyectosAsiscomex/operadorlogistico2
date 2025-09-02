using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class sellosykit
{
    [Key]
    public int idselloykit { get; set; }

    public int? idtipo { get; set; }

    public int? idciudad { get; set; }

    public int? idmarca { get; set; }

    public int? iddo { get; set; }

    public int? idimportador { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? numero { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? nrodo { get; set; }
}
