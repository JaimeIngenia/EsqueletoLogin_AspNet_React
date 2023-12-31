﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaComfamaVs5.Models
{
    public partial class Pelicula
    {
        public Pelicula()
        {
            Horarios = new HashSet<Horario>();
        }

        public int IdPelicula { get; set; }
        public string? Titulo { get; set; }
        public string? ImagenPromocional { get; set; }
        public int? Duracion { get; set; }
        public double? Valor { get; set; }
        public string? Sinopsis { get; set; }
        public int? IdGenero { get; set; }
        public int? IdFormato { get; set; }
        [JsonIgnore]
        public virtual Formato? oGenero { get; set; }
        [JsonIgnore]
        public virtual Genero? oFormato { get; set; }
        public virtual ICollection<Horario> Horarios { get; set; }
    }
}
