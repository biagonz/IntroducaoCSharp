using System;
namespace IntroducaoBaltaIO
{
    public class parte01
    {
        public parte01()
        {
            string nome = "Yan";
            int idade = 0;

            //é possível usar o var e o tipo é definido na complilação
            var name = "Beatriz";
            var age = 25;

            //bool
            var maiorDeIdade = idade > 18;

            //proteção de claúsula do código para possíveis erros
            //tratamento de exception
            try
            {
                //se for feito um if após o outro, os dois serão executados
                //throw new Exception dispara uma mensagem de erro (log)
                if (idade == 0)
                    throw new Exception("Idade Inválida!");

                //mudança de fluxo é uma tomada de decisão
                if (maiorDeIdade)
                    Console.WriteLine(nome + " é maior de idade.");
                else Console.WriteLine(nome + " não é maior de idade.");
            }
            catch (Exception e)
            {
                //é possível guardar o log do erro para eventual consulta
                Console.WriteLine("Ocorreu um erro no sitema: " + e.Message);
            }



            Console.WriteLine(name + " tem " + age + " anos.");
            Console.WriteLine(nome + " tem " + idade + " anos. " + maiorDeIdade);
        }
    }
}
