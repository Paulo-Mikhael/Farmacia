using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Conexao
    {
        private static string conexao = "[----]";
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
