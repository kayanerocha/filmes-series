using System;

namespace FilmesSeries
{
    public class Filme : EntidadeBase
    {
        private string Duracao {get; set;}

        public Filme(int id, string titulo, Genero genero, int classificacao, int ano, string duracao){
            this.Id = id;
            this.Titulo = titulo;
            this.Genero = genero;
            this.Classificacao = classificacao;
            this.Ano = ano;
            this.Excluido = false;
            this.Duracao = duracao;
        }

        public override string ToString(){
            string retorno = "";
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Classificação: " + this.Classificacao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Duração: " + this.Duracao + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo(){
            return this.Titulo;
        }

        public int retornaId(){
            return this.Id;
        }

        public bool retornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}