using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServiceAPP.Application.Commands;
using OrderServiceAPP.Application.Dtos;

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
        [ProducesResponseType(typeof(OrderDto), 200)]
        public async Task<IActionResult> Post(OrderCreateCommand command)
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para atualiação de pedidos. 
        /// </summary> 
        [HttpPut]
        public async Task<IActionResult> Put(OrderUpdateCommand command)
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para exclusão / inativação de pedidos. 
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(OrderDto), 200)]
        public async Task<IActionResult> Delete(OrderDeleteCommand command)
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para consulta de pedidos. 
        /// </summary> 
        [HttpGet]
        [ProducesResponseType(typeof(List<OrderDto>), 200)]
        public async Task<IActionResult> GetAll() //
        {
            return Ok();
        }

        /// <summary> 
        /// Serviço para consulta de pedidos por id. 
        /// </summary> 
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(OrderDto), 200)]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok();
        }
    }
}
