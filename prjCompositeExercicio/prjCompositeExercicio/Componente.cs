using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeExercicio
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(string nome)
        {
            this.nome = nome;
        }

        public abstract void Exibir();

    }
}
