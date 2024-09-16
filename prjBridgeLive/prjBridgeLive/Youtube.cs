using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridgeLive
{
    public class Youtube : IPlataform
    {
        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão Iniciada\n");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando a apliação\n");
        }

        public void ConfigureRMTP( )
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP\n");
        }
    }
}
