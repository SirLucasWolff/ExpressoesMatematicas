using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesMatematicas
{
    public class Calculadora
    {
        public double Calcular(string valoresParaCalculo)
        {
            var tratar = valoresParaCalculo.Trim();
            var valoresTratados = tratar.Replace(" ","");

            var index = valoresParaCalculo.IndexOf("(") + 1;
            var lastIndex = valoresParaCalculo.IndexOf(")");
            
            if (index > 0)
            {
                var valorEmParenteses = valoresParaCalculo.Substring(index, lastIndex - index);
                var foraDeParenteses = valoresParaCalculo.Remove(index - 1, (lastIndex - index) + 2);
            }
            
            double valor1 = Convert.ToDouble(valoresTratados[0]);
            double valor2 = Convert.ToDouble(valoresTratados[2]);
            
            foreach (var Caracter in valoresParaCalculo)
            {
                switch (Caracter)
                {
                   //case 
                }
            }

            string operador, valorDigitado;

            //switch (operador)
            //{
            //    case "+":
            //        resultado = Math.Round(valor1 + valor2, 4);
            //        Console.WriteLine($"{ valor1 } {'+'} { valor2 } = {resultado}");
            //        break;
            //    case "-":
            //        resultado = Math.Round(valor1 - valor2, 4);
            //        Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
            //        break;
            //    case "*":
            //        resultado = Math.Round(valor1 * valor2, 4);
            //        Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
            //        break;
            //    case "/":
            //        resultado = Math.Round(valor1 / valor2, 4);
            //        Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
            //        break;
            //    case "%":
            //        resultado = Math.Round(valor1 % valor2, 4);
            //        Console.WriteLine($"{ valor1 } {'%'} { valor2 } = {resultado}");
            //        break;
            //    default:
            //        Console.WriteLine("Digite uma operação válida");
            //        break;
            //}

            return 10;
        }
    }
}
