﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingApp.Model
{
    class ClassificacaoModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string IdadeMaxima { get; set; }
        public string Descricao { get; set; }
    }
}
