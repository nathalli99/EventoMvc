using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EventoMvc.Models.Enuns;


namespace EventoMvc.Models
{
    public class EventoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Local { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public EventoEnum Classe { get; set;}
    }
}