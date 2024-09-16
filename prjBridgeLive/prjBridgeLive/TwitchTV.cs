using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridgeLive
{
    public class TwitchTV : IPlataform
    {
        public TwitchTV()
        {
            ConfigureRMTP();
            Console.WriteLine("TwitchTV: Transmissão Iniciada\n");
        }
        public void AuthToken()
        {
            Console.WriteLine("TwitchTV: Autorizando a apliação\n");
        }

        public void ConfigureRMTP( )
        {
            AuthToken();
            Console.WriteLine("TwitchTV: Configurando servidor RMTP\n");
        }
    }
}
