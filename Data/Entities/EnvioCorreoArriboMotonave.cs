using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Table("EnvioCorreoArriboMotonave")]
public partial class EnvioCorreoArriboMotonave
{
    [Key]
    public int idenviocorreoarribomotonave { get; set; }

    public int? idusuario { get; set; }

    [StringLength(1000)]
    public string? correo { get; set; }

    public bool? checkarribomotonave { get; set; }

    public bool? checklist { get; set; }

    public bool? checkinstrucciones { get; set; }

    public bool? checkioc { get; set; }
}
