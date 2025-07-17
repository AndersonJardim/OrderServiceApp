using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceAPP.Application.Dtos
{
    /// <summary> 
    /// Modelo de dados DTO para Pedidos 
    /// </summary> 
    public class OrderDto
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Descricao { get; set; }
        public Prioridade? Propriedade { get; set; }
        public Status? Status { get; set; }
    }

    /// <summary> 
    /// Enumerador para prioridade da Pedidos 
    /// </summary> 
    public enum Prioridade
    {
        Baixa = 1,
        Media = 2,
        Alta = 3
    }

    /// <summary> 
    /// Enumerador para prioridade da Pedidos 
    /// </summary> 
    public enum Status
    {
        Prepracao = 1,
        Finalizada = 2
    }
}