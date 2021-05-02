using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Models;

namespace Projeto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Teste",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyyy"),
                Local = "Apucaraba",
                ImagemURL = "",
                Lote = "01",
                QtdPessoas = 200 
            },
            new Evento(){
                EventoId = 2,
                Tema = "Testfdfdfdfe",
                DataEvento = DateTime.Now.AddDays(10).ToString("dd/MM/yyyyy"),
                Local = "Apucaraba",
                ImagemURL = "",
                Lote = "01",
                QtdPessoas = 200
            }
        };


    public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
            
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
            
        }
    }
}
