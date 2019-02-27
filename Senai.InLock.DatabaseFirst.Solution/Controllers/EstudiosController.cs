using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Senai.InLock.DatabaseFirst.Solution.Domains;

namespace Senai.InLock.DatabaseFirst.Solution.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiosController : ControllerBase
    {

        //SqlConnetion + SqlCommand
        [HttpGet("estudioComJogos")]
        public IActionResult Get()
        {
            try
            {
                //Dentro do InLock, há tudo oq precisamos - string, dominios, etc
                using (InLockContext ctx = new InLockContext())
                {
                    return Ok(ctx.Estudios.Include("Jogos").ToList());
                }
            }
            catch(System.Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(Estudios estudio)
        {
            try
            {
                using (InLockContext ctx = new InLockContext())
                {
                    ctx.Estudios.Add(estudio);//Adiciona um estudio recebido ao database de Estudios
                    ctx.SaveChanges();//Salva as alterações registradas
                    return Ok();
                }
            }
            catch(System.Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        
    }
}