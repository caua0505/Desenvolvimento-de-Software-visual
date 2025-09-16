namespace API.Models
{
    public class Produto
    {
        public Produto()
        {
            // Se você preferir manter como string, convertendo o Guid para string
            Id = Guid.NewGuid().ToString();
            CriadoEm = DateTime.Now;
        }

        // Deixe Id como string se preferir
        public string Id { get; set; }

        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}
