using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridgeLive
{
    public abstract class Live
    {
        protected IPlataform plataform;

        public Live(IPlataform plataform)
        {
            this.plataform = plataform;
        }

        public virtual void Broadcasting()
        {
            Console.WriteLine($"Iniciando a live na plataforma: {plataform}\n");
        }

        public virtual void Result()
        {
            Console.WriteLine("*******LIVE NO AR*******\n");
        }
    }
}
