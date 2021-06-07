using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REstApi.Models
{
    public class ValidaCampoViewModelOutput
    {
        public IEnumerable<String> Erros { get; private set; }

        public ValidaCampoViewModelOutput(IEnumerable<String> erros)
        {
            Erros = erros;
        }
    }
}
