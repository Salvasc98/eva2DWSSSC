using System;
using System.Collections.Generic;

namespace DAL.Modelo;


//Constructor de la tabla que contiene la informacion sobre las evaluaciones


public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string? DescEvaluacion { get; set; }

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
