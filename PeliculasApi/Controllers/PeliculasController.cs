using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeliculasApi.Models;
using PeliculasApi.Controllers;
using Microsoft.EntityFrameworkCore;

namespace PeliculasApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly PeliculasContext contexto;
        

        public PeliculasController(PeliculasContext _contexto)
        {
            contexto = _contexto;
        }

        [HttpGet]
        [Route("films")]
        public async Task<IQueryable<Pelicula>> GetAll()
        {
            var query = await contexto.Peliculas.AsQueryable<Pelicula>().AsNoTracking().ToListAsync();
            return query.AsQueryable();
        }


        [HttpGet]
        [Route("films/{id:int}")]
        public async Task<Pelicula> ObtenerporID(int id)
        {
            var query = await contexto.Peliculas.FirstOrDefaultAsync(x => x.Idpeliculas == id);
            return query;
        }
        

        
        



    }

}
