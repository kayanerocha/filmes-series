namespace FilmesSeries
{
    public abstract class EntidadeBase
    {
        public int Id {get; protected set;}
        public string Titulo {get; set;}
        public Genero Genero {get; set;}
        public int Classificacao {get; set;}
        public int Ano {get; set;}
        public bool Excluido {get; set;}
    }
}