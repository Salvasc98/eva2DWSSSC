using System;
using System.Collections.Generic;

namespace DAL.Modelo;


//Constructor de la tabla que contiene las notas de los alumnos en cada evaluacion



public partial class EvaTchNotasEvaluacion
{
    public string? MdUuid { get; set; }

    public DateTime? MdFch { get; set; }

    public long IdNotaEvaluacion { get; set; }

    public string? CodAlumno { get; set; }

    public long? NotaEvaluacion { get; set; }

    public string? CodEvaluacion { get; set; }

    public virtual EvaCatEvaluacion? CodEvaluacionNavigation { get; set; }
}
