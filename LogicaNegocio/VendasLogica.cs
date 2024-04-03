using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
	public class VendasLogica
	{
		public DataTable ListarDetalhesDaVenda()
		{
			try
			{
				var tabela = new DataTable();
				var vendasAcesso = new VendasAcessoDados();
				tabela = vendasAcesso.ListarDetalhesDaVenda();
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void AdicionarDetalhesVenda(string idProduto, string quantidade)
		{
			try
			{
				var vendasAcesso = new VendasAcessoDados();
				vendasAcesso.AdicionarDetalhesVenda(Convert.ToInt32(idProduto), Convert.ToInt32(quantidade));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void AtualizaDetalhesDaVendaQuantidade(string idProduto, string quantidade)
		{
			try
			{
				var vendasAcesso = new VendasAcessoDados();
				vendasAcesso.AtualizaDetalhesDaVendaQuantidade(idProduto, Convert.ToInt32(quantidade));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void AtualizaDetalhesDaVendaIdVenda(string idVenda)
		{
			try
			{
				var vendasAcesso = new VendasAcessoDados();
				vendasAcesso.AtualizaDetalhesDaVendaIdVenda(Convert.ToInt32(idVenda));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void RemoverDetalheDaVenda(string idProduto)
		{
			try
			{
				var vendasAcesso = new VendasAcessoDados();
				vendasAcesso.RemoverDetalheDaVenda(Convert.ToInt32(idProduto));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public DataTable ListarVendas()
		{
			try
			{
				var tabela = new DataTable();
				var vendasAcesso = new VendasAcessoDados();
				tabela = vendasAcesso.ListarVendas();
				return tabela;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void AdicionarVenda(int idUsuario, int idCliente, DateTime dataVenda, string situacao, string total)
		{
			try
			{
				var vendasAcesso = new VendasAcessoDados();
				vendasAcesso.AdicionarVenda(idUsuario, idCliente, dataVenda, situacao, Convert.ToDecimal(total));
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
