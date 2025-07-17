using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPP.Application.Commands
{
    /// <summary>
    /// Modelo de dados COMMAND para exclusão de pedido 
    /// </summary>
    public class OrderDeleteCommand
    {
        public Guid? Id { get; set; }
    }
}
