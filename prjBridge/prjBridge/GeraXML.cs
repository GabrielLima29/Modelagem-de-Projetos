using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prjBridge
{
    public class GeraXML : IGeraArquivo
    {
        private string nomeArquivo = "SalarioFuncionario.xml";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Funcionarios));
        private FileStream fileStream;

        public void GravaArquivo(Funcionarios funcionarios)
        {
            fileStream = new FileStream(nomeArquivo, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, funcionarios);

            Console.WriteLine($"Salario para o Funcionario : {funcionarios.Nome} " +
                $"gerado com sucesso em : {nomeArquivo}\n");
        }
    }
}
