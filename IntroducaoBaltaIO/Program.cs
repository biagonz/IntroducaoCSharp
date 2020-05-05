using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoBaltaIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = ColecaoNumeros();
            //Iteracao(numeros);
            //Numeros();
            //Datas();
            //Strings();
            Colecoes();
            //DicionarioDeValores();
        }

        //Método é feito para dividir responsabilidades
        //Esse método é void e não retorna nada
        private static void Iteracao(int[] numeros)
        {
            foreach (var temp in numeros)
            {
                Console.WriteLine(temp);
            }
        }

        //Esse retorna um valor
        private static int[] ColecaoNumeros()
        {
            return new int[] { 1, 2, 3, 4 };
        }

        private static void Numeros()
        {
            int a = 1; //inteiro 16bits 32bits 64bits

            // números do tipo "quebrados" com diferentes capacidades de tamanho
            float b = 3.12341234f * 2; // usar f ao final de float | 7 digitos de precisão
            double c = 3.123412341234d * 2; // usar d ao final de double | 16 digitos de precisão
            decimal d = 3.1234123412341234m * 2; // usar m ao final de decimal | usar decimal para precisão de valores monetários

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

        }

        private static void Datas()
        {
            //DateTime é o tipo data
            //new DateTime() imprime o valor 01/01/0001 00:00:00
            DateTime data = new DateTime(2020, 09, 10);

            //Existem vários métodos para aplicar na data
            Console.WriteLine(data.ToLongDateString());
            Console.WriteLine(data.ToString("dd . yyyy . MM - hh:mm:ss"));

            //Datas do dia
            Console.WriteLine(DateTime.Now);//data e hora atual
            Console.WriteLine(DateTime.Today); //data atual

            Console.WriteLine(DateTime.Today.AddDays(2)); //adiantar dois dias a partir do dia atual
            Console.WriteLine(DateTime.Today.AddDays(-2)); //volta dois dias a partir do dia atual

            Console.WriteLine(DateTime.Today - new DateTime(2015, 1, 1)); //faz a conta em horas
            Console.WriteLine((DateTime.Today - new DateTime(1994, 11, 10)).Days); //faz a conta em dias

            //dois DateTime viram um TimeSpan
            var calculo = DateTime.Today - new DateTime(2020, 1, 1);
            var resultadoEmDias = calculo.Days;
            Console.WriteLine(resultadoEmDias);

            var calculo2 = DateTime.Today - TimeSpan.FromDays(2);
            Console.WriteLine(calculo2);

            //Estudar a estrutura DateTime no msdn

        }

        private static void Strings()
        {
            object[] parametros = { "Natal", 2015, 800000, 10000000000 };

            string result = string.Format("{0} em {1}: população {2:N0}, Área {3:N1} m2", parametros);
            Console.WriteLine(result);


        }

        private static void Colecoes()
        {
            //[,] representa um array de 2 dimensões - matriz
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }; //padrão da criação de array

            var nomes = new string[]
            {
                "Ana", "João", "Pedro", "Paulo", "Maria", "Beatriz"
            };
            foreach (var nome in nomes)
            {
                //Console.WriteLine(nome);
            }

            var cidades = new List<string>
            {
                "São Paulo",
                "Natal",
                "Rio de Janeiro",
                "Brasília",
            };

            cidades.Add("Curitiba"); //adiciona um item a coleção
            //cidades.AddRange("Teste");//adiciona uma nova coleção dentro da lista atual
            //existem vários métodos que podem ser aplicados a uma coleção, pesquisar nos colletions

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            };

            var filtradas = cidades.Where(x => x.Contains("i")); //101 Examples com Linq
            foreach(var filter in filtradas)
            {
                Console.WriteLine(filter);

            }
        }

        private static void DicionarioDeValores()
        {
            //é possível atribuir qlqr tipo de variável ao Dictionary
            var EstadoCidades = new Dictionary<string, List<string>>();
            EstadoCidades.Add("RN", new List<string> { "Natal", "Parnamirim", "Mosoró" });
            var citys = EstadoCidades["RN"];
            foreach (var city in citys)
            {
                Console.WriteLine(city);
            }

            //o array inicializado
            var capitais = new Dictionary<string, string>
            {
                { "RN", "Rio Grande do Norte" },
                { "RS", "Rio Grande do Sul" },
                { "SP", "São Paulo" },
                { "RJ", "Rio de Janeiro" }
            };


            //Imprime o value pela posição da key
            Console.WriteLine(capitais["RN"]);

            //Adiocina um valor ao array
            capitais.Add("MG", "Minas Gerais");

            //Usa o linq para filtrar pela key e retornar os estados que começam com a letra R
            var uf = capitais.Keys.Where(x => x.StartsWith("R"));
            foreach (var c in uf)
            {
                Console.WriteLine(c);
            }

            //Usa o linq para filtrar pelo value e retornar as cidades que começam com a letra S
            var cidades = capitais.Values.Where(x => x.StartsWith("S"));
            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }
        }
    }
}
