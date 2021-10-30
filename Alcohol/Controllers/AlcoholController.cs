using System.Net;
using Microsoft.AspNetCore.Mvc;
using Alcohol.Domain.Entities;

namespace AlcoholController.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AlcoholController : ControllerBase
    {
        
        [HttpGet]
        [Route("Controller/{cantidad}/{bebida}/{peso}")]
        
        public IActionResult Getalcohol(int cantidad, string bebida,int peso)
        {
            
            var resultado = new Operaciones();
            resultado.PrimerDato(cantidad,bebida);
            resultado.SegundoDato(peso);
            resultado.DatosTotales();
            return Ok(resultado.DatosTotales());
        }
    }
}