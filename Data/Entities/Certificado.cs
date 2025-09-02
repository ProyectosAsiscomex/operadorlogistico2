using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

public partial class Certificado
{
    [Key]
    public int idcertificado { get; set; }

    public int? idpaisexpo { get; set; }

    public int? idpaisimpo { get; set; }

    public int? idimportador { get; set; }

    public int? IdExportador { get; set; }

    public int? IdProductor { get; set; }

    [StringLength(60)]
    public string? Ciudad { get; set; }

    [StringLength(80)]
    public string? FechaFirma { get; set; }

    public int? IdAcuerdo { get; set; }

    public int? IdRegional { get; set; }

    public byte? HojasAnexas { get; set; }

    [StringLength(100)]
    public string? MedioTransporte { get; set; }

    public short? Forma { get; set; }
}
