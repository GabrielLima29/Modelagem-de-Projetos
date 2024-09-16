using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace prjBridge
{
    public abstract class AbstracaoGeraArquivo
    {
        protected IGeraArquivo geraArquivo;

        protected AbstracaoGeraArquivo(IGeraArquivo geraArquivo)
        {
            this.geraArquivo = geraArquivo;
        }

        public virtual void GravarArquivo(Funcionarios funcionarios)
        {
            geraArquivo.GravaArquivo(funcionarios);
        }
    }
}
