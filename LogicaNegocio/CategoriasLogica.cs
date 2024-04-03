using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CategoriasLogica
    {
        public void Validar(string nome)
        {
            if (nome == "")
            {
                throw new Exception("O campo Nome não pode ser vazio");
            }
        }

        public DataTable ListarCategorias()
        {
            try
            {
                var tabela = new DataTable();
                var categoriaAcesso = new CategoriasAcessoDados();

                tabela = categoriaAcesso.ListarCategorias();
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Salvar(string nome, string descricao)
        {
            try
            {
                Validar(nome);
                var categoriaAcesso = new CategoriasAcessoDados();
                categoriaAcesso.Salvar(nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Excluir(string idCategoria)
        {
            try
            {
                var categoriaAcesso = new CategoriasAcessoDados();
                categoriaAcesso.Excluir(Convert.ToInt32(idCategoria));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(string idCategoria, string nome, string descricao)
        {
            try
            {
                var categoriaAcesso = new CategoriasAcessoDados();
                categoriaAcesso.Atualizar(Convert.ToInt32(idCategoria), nome, descricao);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirProdutosPorCategorias(string idCategoria)
        {
            try
            {
                var categoriaAcesso = new CategoriasAcessoDados();
                categoriaAcesso.ExcluirProdutosPorCategoria(Convert.ToInt32(idCategoria));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int RetornaNumeroProdutosCategoria(string idCategoria)
        {
            try
            {
                var categoriaAcesso = new CategoriasAcessoDados();

                int numeroProdutos = categoriaAcesso.RetornaNumeroProdutosCategoria(Convert.ToInt32(idCategoria));
                return numeroProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
