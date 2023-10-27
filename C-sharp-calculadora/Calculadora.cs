using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_calculadora
{
    public class Calculadora
    {
        public List<float> Historico { get; set; }

        public Calculadora()
        {
            Historico = new List<float>();
        }

        public float Somar(float var01, float var02)
        {
            float result = var01 + var02;
            Historico.Add(result);
            return result;
        }

        public float Subtrair(float var01, float var02)
        {
            float result = var01 - var02;
            Historico.Add(result);
            return result;
        }

        public float Dividir(float var01, float var02)
        {
            if (var02 == 0) throw new DivideByZeroException();
            float result = var01 / var02;
            Historico.Add(result);
            return result;
        }

        public float Multiplicar(float var01, float var02)
        {
            float result = var01 * var02;
            Historico.Add(result);
            return result;
        }
    }

}
