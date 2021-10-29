using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesMatematicas
{
    public class Calculadora
    {
        public int Calcular(string valoresParaCalculo)
        {
            int resultado = 0;

            var tratar = valoresParaCalculo.Trim();
            var valoresTratados = tratar.Replace(" ","");

            var index = valoresParaCalculo.IndexOf("(") + 1;
            var lastIndex = valoresParaCalculo.IndexOf(")");
            
            if (index > 0)
            {
                var valorEmParenteses = valoresParaCalculo.Substring(index, lastIndex - index);
                var foraDeParenteses = valoresParaCalculo.Remove(index - 1, (lastIndex - index) + 2);
            }
            List<int> valores = new List<int>();
            List<char> operadores = new List<char>();

            foreach (var valor in valoresTratados)
            {
                if (valor == '+')
                {
                    operadores.Add(valor);
                }
                else if (valor == '-')
                {
                    operadores.Add(valor);
                }
                else
                {
                    valores.Add(Convert.ToInt32(valor.ToString()));
                }
            }

            foreach (var operador in operadores)
            {
                if(operador == '+')
                {
                    foreach(var item in valores)
                    {
                        resultado += item;
                    }
                }
                if(operador == '-')
                {
                    foreach (var item in valores)
                    {
                        resultado -= item;
                    }
                }

                //valores.Clear();

                //switch (operador)
                //{
                //    case '+':
                //        resultado = valores[0] + valores[1] + valores[2];
                //        valores.RemoveAt(2);
                //        valores.RemoveAt(1);
                //        valores.RemoveAt(0);
                //        operadores.Clear();
                //        break;
                //    //case "-":
                //    //    resultado = Math.Round(valor1 - valor2, 4);
                //    //    Console.WriteLine($"{ valor1 } {'-'} { valor2 } = {resultado}");
                //    //    break;
                //    //case "*":
                //    //    resultado = Math.Round(valor1 * valor2, 4);
                //    //    Console.WriteLine($"{ valor1 } {'*'} { valor2 } = {resultado}");
                //    //    break;
                //    //case "/":
                //    //    resultado = Math.Round(valor1 / valor2, 4);
                //    //    Console.WriteLine($"{ valor1 } {'/'} { valor2 } = {resultado}");
                //    //    break;
                //    //case "%":
                //    //    resultado = Math.Round(valor1 % valor2, 4);
                //    //    Console.WriteLine($"{ valor1 } {'%'} { valor2 } = {resultado}");
                //    //    break;
                   
                //}
            }

            return resultado;
        }
    }
}
