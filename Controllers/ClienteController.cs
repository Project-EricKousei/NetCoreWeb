using Microsoft.AspNetCore.Mvc;
using NetCoreWeb.Models;

namespace NetCoreWeb.Controllers
{
    [ApiController]
    [Route("cliente")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        [Route ("listar")]
        public dynamic listarCliente()
        {
            //Codigo 
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    correo = "aorus24@gmail.com",
                    edad = "24",
                    nombre = "Pedro Perez"

                },
                new Cliente
                {
                    id = "2",
                    correo = "ryzen35@gmail.com",
                    edad = "30",
                    nombre = "Cristian Callapino"

                }



            };
            return clientes;
         

        }
        [HttpGet]
        [Route("listarxid")]
        public dynamic listarClientexid(int codigo)
        {
            //Obtenemos el cliente de la base de datos
           return new Cliente
            {
              
               
                    id = codigo.ToString(),
                    correo = "nvidia32@gmail.com",
                    edad = "30",
                    nombre = "Cristian Correa"


            };
           


        }

        [HttpPost]
        [Route("guardar")]
        public dynamic guardarCliente(Cliente cliente)

        {
            cliente.id="3";
            return new
            {
                sucess = true,
                message = "cliente registrado",
                result = cliente


            };
        }

        [HttpPost]
        [Route("eliminar")]
        public dynamic eliminarCliente(Cliente cliente)

        {
            string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
            //Eliminar en la base  de datos
            if(token != "eric123.")
            {
                return new
                {
                    sucess = false,
                    message = "token incorrecto",
                    result = ""
                };
            }



            return new
            {
                sucess = true,
                message = "cliente eliminado",
                result = cliente


            };
        }


    }
}
