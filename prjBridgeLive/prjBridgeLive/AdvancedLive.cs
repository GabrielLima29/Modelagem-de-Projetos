using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridgeLive
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlataform plataform) : base(plataform) { }

        public void Subtitles()
        {
            Console.WriteLine("Adicionando legenda a live\n");
        }

        public void Comments()
        {
            Console.WriteLine("Fazendo um comentário na live\n");
        }
    }
}
