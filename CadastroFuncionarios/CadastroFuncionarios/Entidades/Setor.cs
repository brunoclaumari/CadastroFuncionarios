﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Entidades
{
    public class Setor : GenericClass
    {

        public long Id { get; set; }

        public string Descricao { get; set; }

        public Setor()
        {
        }
    }
}
