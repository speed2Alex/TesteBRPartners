using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp.Model
{
    class StreamingModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public DateTime Lancamento { get; set; }
        public int Nota { get; set; }
        public string Descricao { get; set; }
        public int CodigoClassificacao { get; set; }
        public int CodigoGenero { get; set; }
        public int CodigoTipoStreaming { get; set; }

    }
}
