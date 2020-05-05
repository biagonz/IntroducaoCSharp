using System;
namespace IntroducaoBaltaIO
{
    public class Loop_Iteracao
    {
        public Loop_Iteracao()
        {
            var numeros = new int[] { 1, 2, 3, 4 };
            //Initializer; Condition; Update
            for (var i = 0; i <= numeros.Length; i++)
            {
                Console.WriteLine(i);
            }

            var temp = 0;
            while (temp <= numeros.Length)
            {
                Console.WriteLine(temp);
                temp++;
            }

            //itera os números (Type in Colletion)
            //pega o valor inicial da colletion e atribui a j
            //e realiza a iteração automática até o fim da colletion (bom para impressão)
            foreach (var j in numeros)
            {
                Console.WriteLine(j);
            }
        }
    }
}
