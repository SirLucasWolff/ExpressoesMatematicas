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
            var index = valoresParaCalculo.IndexOf("(") + 1;
            var lastIndex = valoresParaCalculo.IndexOf(")");
            
            var valorEmParenteses = valoresParaCalculo.Substring(index, lastIndex - index);
            var foraDeParenteses = valoresParaCalculo.Remove(index -1, (lastIndex - index) +2);

            return 1;


            //double valor1 = 0, valor2 = 0, resultado, numero;
            //string operador, valorDigitado;           

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


        }
    }
}
