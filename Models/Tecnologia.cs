namespace projetomvc.Models
{
    public class Tecnologia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public Tecnologia()
        {
            
        }
        public Tecnologia(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
    }
}