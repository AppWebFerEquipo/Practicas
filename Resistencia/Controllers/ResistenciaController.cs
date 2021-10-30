namespace Name.Controllers
{
    using System;
    using Resistencia.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ControllerController : ControllerBase
    {
        [HttpGet]
        [Route("Calcular/{Banda1}/{Banda2}/{Banda3}/{Banda4}")]
        public IActionResult Getop(string Banda1,string Banda2,string Banda3,string Banda4)
        {
            var resultado = new Result();
            resultado.Banda_1(Banda1);
            resultado.Banda_2(Banda2);
            resultado.Banda_3(Banda3);
            resultado.Banda_gold(Banda4);
            resultado.operacion();
            return Ok(resultado.operacion());
        }
    }
}