using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            GeraSalario calculaSalario = new GeraSalario(new GeraXML());

            Funcionarios funcionarios = new Funcionarios { 
                Id = 101,
                Nome = "Gabriel",
                SalarioBase = 3000,
                Incentivo = 2000 };
            calculaSalario.ProcessaSalarioFuncionario(funcionarios);

            funcionarios.Incentivo = 2500;

            calculaSalario = new GeraSalario(new GeraJSON());
            calculaSalario.ProcessaSalarioFuncionario(funcionarios);
            Console.ReadLine();
        }
    }
}
