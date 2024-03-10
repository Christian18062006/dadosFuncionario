using System;
using System.Collections.Generic;
using System.Text;

namespace DadosFuncionários
{
    class DadosFuncionario
    {
        public string nome = string.Empty;
        public double salarioBruto;
        public double imposto;
        public double salarioLiquido()
        {
            double salarioLiquido = salarioBruto - (salarioBruto * imposto / 100);
            return (salarioLiquido);
        }
    }

    }
}
