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
                else if (valor == '*')
                {
                    operadores.Add(valor);
                }
                else
                {
                    valores.Add(Convert.ToInt32(valor.ToString()));
                }
            }

            bool apenasTemOperadorDeSoma = operadores.Contains('+') && !operadores.Contains('-') && !operadores.Contains('/') && !operadores.Contains('*');
            if (apenasTemOperadorDeSoma)
            {
                foreach (var item in valores)
                {
                    resultado += item;
                }
            }

            bool apenasTemOperadorDeSubtracao = !operadores.Contains('+') && operadores.Contains('-') && !operadores.Contains('/') && !operadores.Contains('*');
            if (apenasTemOperadorDeSubtracao)
            {
                foreach (var item in valores)
                {
                    resultado -= item;
                }
            }

            bool apenasTemOperadorDeMultiplicacao = !operadores.Contains('+') && !operadores.Contains('-') && !operadores.Contains('/') && operadores.Contains('*');
            if (apenasTemOperadorDeMultiplicacao)
            {           
                foreach (var item in valores)
                {
                    if (valores[0] == item)
                    {
                        resultado = item * valores[1];
                    }
                    else
                    {
                        resultado *= item;
                    }
                    
                }
            }

            bool apenasTemOperadorDeMultiplicacao = !operadores.Contains('+') && !operadores.Contains('-') && !operadores.Contains('/') && operadores.Contains('*');
            if (apenasTemOperadorDeMultiplicacao)
            {
                foreach (var item in valores)
                {
                    if (valores[0] == item)
                    {
                        resultado = item * valores[1];
                    }
                    else
                    {
                        resultado *= item;
                    }

                }
            }


            return resultado;
        }
    }
}

