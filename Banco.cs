namespace CaixaEletronico
{
    public class Banco
    {
        public List<TitularCartao> titularesCartao;

        public Banco()
        {
            titularesCartao = new List<TitularCartao>
        {
            new TitularCartao("5572096890324397", 1234, "Gabriela", "Silva", 4598.31),
            new TitularCartao("4084007130021262", 1234, "Rafael", "Souza", 210.43),
            new TitularCartao("5552302721676165", 1234, "Julia", "Pereira", 1023.56),
            new TitularCartao("4024007190705357", 1234, "Lucas", "Oliveira", 7500.00),
            new TitularCartao("5299406269141087", 1234, "Mariana", "Santos", 15.75),
            new TitularCartao("5168756196701991", 1234, "Isabela", "Ferreira", 503.00)
        };
        }

        public TitularCartao? ObterTitularCartao(string numeroCartao)
        {
            return titularesCartao.FirstOrDefault(a => a.NumeroCartao == numeroCartao) as TitularCartao;
        }
    }

}