using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AsiscomexOperadorLogistico.Data.Entities;

[Keyless]
public partial class ReportesColumna
{
    /// <summary>
    /// Numero unico que identifica el registro dentro de la tabla
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Numero del reporte al cual pertenecen las columnas
    /// </summary>
    public int IdReporte { get; set; }

    /// <summary>
    /// Nombre de la columna en la tabla o vista
    /// </summary>
    [StringLength(50)]
    public string Columna { get; set; } = null!;

    /// <summary>
    /// Titulo a ser mostrado en el resultado de la consulta
    /// </summary>
    [StringLength(50)]
    public string Titulo { get; set; } = null!;

    /// <summary>
    /// alineacion de la columna en el reporte (izq, der, centro)
    /// </summary>
    [StringLength(10)]
    public string Alineacion { get; set; } = null!;

    /// <summary>
    /// Orden en que deben aparecer los campos en el reporte
    /// </summary>
    public short Orden { get; set; }

    /// <summary>
    /// Si tiene un 1, sera el campo con el vinculo para la edicion del registro
    /// </summary>
    public short VinculoEditar { get; set; }

    /// <summary>
    /// SÃ­ tiene el valor de uno el campo que identifica al registro para su edicion o eliminacion o modificacion
    /// </summary>
    public short Identificador { get; set; }

    /// <summary>
    /// Porcentaje del ancho de la columna
    /// </summary>
    public short Ancho { get; set; }
}
