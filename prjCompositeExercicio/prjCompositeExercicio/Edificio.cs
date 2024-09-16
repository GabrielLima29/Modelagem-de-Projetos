using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCompositeExercicio
{
    public class Edificio : Componente
    {
        private List<Componente> itens = new List<Componente>();

        public Edificio(string nome) : base(nome)
        {

        }

        public override void Exibir()
        {
            Console.WriteLine($"Edificio: {nome}");
            foreach (var item in itens)
            {
                item.Exibir();
            }
        }

        public void Adicionar(Componente componente)
        {
            itens.Add(componente);
        }

        public void Remover(Componente componente)
        {
            itens.Remove(componente);
        }
    }
}
