namespace DIO.Quadrinhos
{
    public class Quadrinho : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Categoria { get; set; }
        private int Ano { get; set; }

        public Quadrinho (int id, Genero genero, string titulo, string categoria, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Categoria = categoria;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Categoria: " + this.Categoria + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}