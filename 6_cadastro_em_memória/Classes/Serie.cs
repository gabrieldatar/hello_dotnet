using System;

namespace _6_cadastro_em_memória
{
    public class Serie:EntidadeBase
    {

        // Construtor
        /*
        public void Init(int id,Genero genero, string titulo, string descricao, int ano)
        {
            new Serie(id, genero, titulo, descricao, ano);
        }
        */

        public Serie(int id,Genero genero, string titulo, string descricao, int ano)
        {
            this.Id=id;
            this.Genero=genero;
            this.Titulo=titulo;
            this.Descricao=descricao;
            this.Ano=ano;
            this.Excluido=false;
        }

        // Atributos
        private Genero Genero
        {
            get;
            set;
        }

        private string Titulo
        {
            get;
            set;
        }

        private string Descricao
        {
            get;
            set;
        }

        private int Ano
        {
            get;
            set;
        }

        private bool Excluido
        {
            get;
            set;
        }

        // Métodos
        public override string ToString()
        {
            string retorno="";
            retorno+="Gênero: "+this.Genero+Environment.NewLine;
            retorno+="Título: "+this.Titulo+Environment.NewLine;
            retorno+="Descrição: "+this.Descricao+Environment.NewLine;
            retorno+="Ano de Início: "+this.Ano+Environment.NewLine;
            retorno+="Excluido: "+this.Excluido;
            return retorno;
        }

        public string getTitulo()
        {
            return this.Titulo;
        }

        public int getId()
        {
            return this.Id;
        }

        public bool getExcluido()
        {
            return this.Excluido;
        }

        public void setExcluir()
        {
            this.Excluido=true;
        }
    }
}