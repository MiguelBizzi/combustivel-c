using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combustivel
{
    class Classe
    {
        public string QualAbastecer(double gasolina, double etanol)
        {
            if (etanol < gasolina * 0.7)
            {
                return "Abasteca em etanol!";
            }
            else
            {
                return "Abasteca em gasolina!";
            }
        }

    }
}
