﻿using Pagamento2Net.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento2.Net.Contratos
{
    public interface ICriarArquivoRemessa
    {
        string GerarArquivoRemessa(Pagamento documents);
    }
}
