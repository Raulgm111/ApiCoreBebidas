using ApiCoreBebidas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCoreBebidas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BebidasController : ControllerBase
    {
        List<Bebida> bebidas;

        public BebidasController()
        {
            this.bebidas = new List<Bebida>
            {
                new Bebida {IdBebida=1,Nombre="CocaCola",Precio="1€"},
                new Bebida {IdBebida=2,Nombre="Fanta",Precio="0,80€"},
                new Bebida {IdBebida=3,Nombre="Nestea",Precio="1,20€"},
                new Bebida {IdBebida=4,Nombre="Casera",Precio="1€"},
            };
        }

        [HttpGet]
        public ActionResult<List<Bebida>> Get()
        {
            return this.bebidas;
        }

        [HttpGet("{id}")]

        public ActionResult<Bebida> FindBebida(int id)
        {
            return this.bebidas.FirstOrDefault(x => x.IdBebida == id);
        }


    }
}
