using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class MessageBoxes
    {
        public void VerificaLinhas(DataGridView tabela)
        {
            if (tabela.Rows.Count <= 0)
            {
                throw new Exception("Sem dados para trabalhar");

            }
        }
        public DialogResult MboxConfirmacao(string conteudo, string titulo = "")
        {
            if (titulo == "")
            {
                titulo = "Confirmação";
            }

            var confirmacao = MessageBox.Show(conteudo, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacao == DialogResult.Yes)
            {
                return DialogResult.Yes;
            }

            return DialogResult.No;
        }

        public void MboxInfo(string conteudo, string titulo = "")
        {
            if (titulo == "")
            {
                titulo = "Sucesso";
            }

            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MboxErro(string conteudo, string titulo = "")
        {
            if (titulo == "")
            {
                titulo = "Erro";
            }

            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MboxAviso(string conteudo, string titulo = "")
        {
            if (titulo == "")
            {
                titulo = "Aviso!";
            }

            MessageBox.Show(conteudo, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
