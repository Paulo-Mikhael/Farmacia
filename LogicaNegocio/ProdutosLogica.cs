using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ProdutosLogica
    {
		private void ValidaDados(string codigoBarras, string nome, string categoria, string estoqueAtual, string estoqueMinimo,
            string valorCompra, string valorVenda)
		{
            string numeroCompra = valorCompra.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
            string numeroVenda = valorVenda.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();

            if (codigoBarras == "" || codigoBarras.Length > 10)
			{
				throw new Exception("Defina um código de barras válido");
			}

			if (nome == "")
			{
                throw new Exception("O campo Nome não pode ser vazio");
            }

            if (categoria == "" || categoria == "0")
            {
                throw new Exception("Defina uma categoria");
            }

            if (estoqueAtual.Length > 10)
            {
                throw new Exception("Valor do estoque atual muito alto");
            }
            else if (estoqueAtual == "" || int.TryParse(estoqueAtual, out _) == false)
            {
                throw new Exception("Defina o estoque atual");
            }

            if (estoqueMinimo.Length > 10 || estoqueMinimo.Length > estoqueAtual.Length)
            {
                throw new Exception("Valor do estoque mínimo muito alto");
            }
            else if (estoqueMinimo == "" || int.TryParse(estoqueMinimo, out _) == false)
            {
                throw new Exception("Defina o estoque mínimo");
            }

            if (numeroCompra.Length > 9)
            {
                throw new Exception("Valor de custo muito alto");
            }
            else if (numeroCompra == "" || decimal.TryParse(numeroCompra, out _) == false)
            {
                throw new Exception("Defina o custo do produto");
            }

            if (numeroVenda.Length > 9)
            {
                throw new Exception("Valor de venda muito alto");
            }
            if (numeroVenda == "" || decimal.TryParse(numeroVenda, out _) == false)
            {
                throw new Exception("Defina preço de venda do produto");
            }
        }

        public DataTable ListarProdutos()
        {
			try
			{
				var tabela = new DataTable();
				var produtoAcesso = new ProdutosAcessoDados();

				tabela = produtoAcesso.ListarProdutos(); ;
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
        }

        public DataTable ListarProdutosEstoqueBaixo()
        {
            try
            {
                var tabela = new DataTable();
                var produtoAcesso = new ProdutosAcessoDados();

                tabela = produtoAcesso.ListarProdutosEstoqueBaixo();
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

		public void Salvar(string codigoBarras, string nome, string detalhes, string categoria, string estoqueAtual, string estoqueMinimo,
            string valorCompra, string valorVenda, DateTime dataCadastro)
		{
            ValidaDados(codigoBarras, nome, categoria, estoqueAtual, estoqueMinimo, valorCompra, valorVenda);

            string numeroCompra = valorCompra.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
            string numeroVenda = valorVenda.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();

            var produtosAcesso = new ProdutosAcessoDados();
			produtosAcesso.Salvar(codigoBarras, nome, detalhes, categoria, estoqueAtual, estoqueMinimo, Convert.ToDecimal(numeroCompra),
                Convert.ToDecimal(numeroVenda), dataCadastro);
		}

        public void Excluir(int idProduto)
        {
            var produtoAcesso = new ProdutosAcessoDados();
            produtoAcesso.Excluir(idProduto);
        }

        public void Atualizar(int idProduto, string codigoBarras, string nome, string detalhes, string categoria, string estoqueAtual, string estoqueMinimo,
            string valorCompra, string valorVenda, DateTime dataCadastro)
        {
            ValidaDados(codigoBarras, nome, categoria, estoqueAtual, estoqueMinimo, valorCompra, valorVenda);

            string numeroCompra = valorCompra.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();
            string numeroVenda = valorVenda.Replace("R", "").Replace("$", "").Replace(" ", "").Trim();

            var produtoAcesso = new ProdutosAcessoDados();
            produtoAcesso.Atualizar(idProduto, codigoBarras, nome, detalhes, categoria, estoqueAtual, estoqueMinimo, Convert.ToDecimal(numeroCompra),
                Convert.ToDecimal(numeroVenda), dataCadastro);
        }

        public DataTable RetornaProdutosPorNome(string nome)
        {
            try
            {
                var tabela = new DataTable();
                var produtoAcesso = new ProdutosAcessoDados();

                tabela = produtoAcesso.RetornaProdutosPorNome(nome);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornaProdutosPorCategoria(string categoria)
        {
            try
            {
                var tabela = new DataTable();
                var produtoAcesso = new ProdutosAcessoDados();

                tabela = produtoAcesso.RetornaProdutosPorCategoria(categoria);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable RetornaProdutosPorCodigoBarras(string codigoBarras, string apenasCod = "")
        {
            try
            {
                var tabela = new DataTable();
                var produtoAcesso = new ProdutosAcessoDados();

                tabela = produtoAcesso.RetornaProdutosPorCodigoBarras(codigoBarras, apenasCod);
                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AtualizaEstoque(string idProduto, string estoqueAtual)
        {
            try
            {
                var produtoAcesso = new ProdutosAcessoDados();
                produtoAcesso.AtualizaEstoque(Convert.ToInt32(idProduto), Convert.ToInt32(estoqueAtual));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
