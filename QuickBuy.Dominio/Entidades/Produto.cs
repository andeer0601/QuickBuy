namespace QuickBuy.Dominio.Entidades
{
    class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto é inválido");

            if (Preco <= 0)
                AdicionarCritica("Preço do produto é inválido");
        }
    }
}
