using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }
        public int Email { get; set; }
        public int Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Usuario pode ter Nenhum ou n pedidos 
        /// </summary>

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
