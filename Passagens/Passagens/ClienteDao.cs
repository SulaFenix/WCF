using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    public class ClienteDao
    {
        //private List<Cliente> clientes = new List<Cliente>(); -> Para não perder ela a cada requisição, foi acrescentado o static

        private static List<Cliente> clientes = new List<Cliente>();

        public void Add (Cliente c)
        {
            //this.clientes.Add(c); -> para deixar claro que ela é estática, você acessa utilizando o nome da classe.
            ClienteDao.clientes.Add(c);
        }

        public Cliente Buscar (string nome)
        {
            //var resultado = from c in clientes
            //                where c.Nome.Equals(nome)
            //                select c; -> pode retornar mais de um dado

            var resultado = ClienteDao.clientes
                                      .Where(c => c.Nome.Equals(nome))
                                      .FirstOrDefault();

            return (Cliente)resultado;
        }
    }
}
