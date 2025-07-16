using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderServiceApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de pedidos
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para atualiação de pedidos. 
        /// </summary> 
        [HttpPut]
        public async Task<IActionResult> Put()
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para exclusão / inativação de pedidos. 
        /// </summary>
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para consulta de pedidos. 
        /// </summary> 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
