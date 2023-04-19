using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("======MENU======");
            Console.WriteLine("1-EXERCICIO 1");
            Console.WriteLine("2-EXERCICIO 2");
            Console.WriteLine("3-EXERCICIO 3");
            Console.WriteLine("4-EXERCICIO 4");
            Console.WriteLine("5-EXERCICIO 5");
            Console.WriteLine("6-EXERCICIO 6");
            Console.WriteLine("7-EXERCICIO 7");
            op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:

                    int nume, numeT;
                    Console.WriteLine("Digite um numero inteiro: ");
                    nume = int.Parse(Console.ReadLine());

                    if (nume < 0)
                    {
                        numeT = nume * -1;
                        Console.WriteLine("seu numero absoluto sera: " + numeT);
                    }
                    else
                    {
                        Console.WriteLine("seu numero absoluto sera: " + nume);
                    }

                    break;
                case 2:
                    int num;

                    Console.WriteLine("digite um numero inteiro: ");
                    num = int.Parse(Console.ReadLine());

                    if ((num % 5 == 0) & (num % 3 == 0))
                    {
                        Console.WriteLine(num + " é divisivel por 5 e 3");
                    }
                    else if ((num % 4 == 0) & (num % 7 == 0))
                    {
                        Console.WriteLine(num + " é divisivel por 4 e 7");
                    }
                    else if (num % 3 == 0)
                    {
                        Console.WriteLine(num + "é divisivel por 3");
                    }
                    else if (num % 4 == 0)
                    {
                        Console.WriteLine(num + " é divisivel por 4");
                    }
                    else if (num % 5 == 0)
                    {
                        Console.WriteLine(num + " é divisivel por 5");
                    }
                    else if (num % 7 == 0)
                    {
                        Console.WriteLine(num + " é divisivel por 7");
                    }
                    else
                    {
                        Console.WriteLine("num não é divisivel por nenhuma das opções");
                    }
                    Console.ReadKey();

                    break;
                case 3:
                    int n1, n2, n3;

                    Console.WriteLine("digite o primeiro numero inteiro: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero inteiro: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("digite o terceiro numero inteiro: ");
                    n3 = int.Parse(Console.ReadLine());

                    if ((n1 < n2 && n1 < n3) & (n3 > n2))
                    {
                        Console.WriteLine(n1 + " é o menor numero e o " + n3 + " é o maior numero");
                        Console.ReadKey();
                    }
                    else if ((n1 < n2 && n1 < n3) & (n2 > n3))
                    {
                        Console.WriteLine(n1 + " é o menor numero e o " + n2 + " é o maior numero");
                        Console.ReadKey();
                    }
                    else if ((n2 < n1 && n2 < n3) & (n3 > n1))
                    {
                        Console.WriteLine(n2 + " é o menor numero e o " + n3 + " é o maior numero");
                        Console.ReadKey();
                    }
                    else if ((n1 < n2 && n1 < n3) & (n1 > n2))
                    {
                        Console.WriteLine(n1 + " é o menor numero e o " + n1 + " é o maior numero");
                        Console.ReadKey();
                    }
                    else if ((n3 < n2 && n3 < n1) & (n1 > n2))
                    {
                        Console.WriteLine(n3 + " é o menor numero e o " + n1 + " é o maior numero");
                        Console.ReadKey();
                    }
                    else if ((n3 < n2 && n3 < n1) & (n2 > n1))
                    {
                        Console.WriteLine(n3 + " é o menor numero e o " + n2 + " é o maior numero");
                        Console.ReadKey();
                    }

                    break;
                case 4:
                    int esc;

                    Console.WriteLine("escolha um dia da semana: ");
                    Console.WriteLine("1- DOMINGO");
                    Console.WriteLine("2- SEGUNDA");
                    Console.WriteLine("3- TERÇA");
                    Console.WriteLine("4- QUARTA");
                    Console.WriteLine("5- QUINTA");
                    Console.WriteLine("6- SEXTA");
                    Console.WriteLine("7- SABADO");
                    esc = int.Parse(Console.ReadLine());

                    switch (esc)
                    {
                        case 1:
                            Console.WriteLine("DOMINGO DIA DE CINEMA EM CASA ");

                            break;
                        case 2:
                            Console.WriteLine("SEGUNDA FEIRA " +
                                "FILOSOFIA " +
                                "FILOSOFIA " +
                                "PORTUGUES " +
                                "PORTUGUES " +
                                "MATEMATICA " +
                                "MATEMATICA");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("TERÇA FEIRA " +
                                "QUIMICA " +
                                "QUIMICA " +
                                "HISTORIA " +
                                "HISTORIA " +
                                "INGLES " +
                                "INGLES");
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("QUARTA FEIRA " +
                                "BIOLOGIA " +
                                "BIOLOGIA " +
                                "PORTUGUES " +
                                "PR2 " +
                                "PR2 ");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.WriteLine("QUINTA FEIRA " +
                                "FISICA " +
                                "FISICA " +
                                "REDES " +
                                "REDES " +
                                "SOCIOLOGIA " +
                                "SOCIOLOGIA ");
                            Console.ReadKey();
                            break;
                        case 6:
                            Console.WriteLine("SEXTA FEIRA" +
                                "GEOGRAFIA " +
                                "GEOGRAFIA " +
                                "MATEMATICA " +
                                "BDS " +
                                "BDS " +
                                "BDS ");
                            Console.ReadKey();
                            break;
                        case 7:
                            Console.WriteLine("SABADO DIA DE DESCANÇAR");

                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("NÃO EXISTE ESSE DIA DA SEMANA");
                            Console.ReadKey();
                            break;
                    }


                    break;
                case 5:

                    int parada = 2, menorvalor, maiorvalor, n;
                    menorvalor=int.MaxValue;
                    maiorvalor = int.MinValue;

                    for (; parada!=0; )
                    {
                        Console.WriteLine("escreva um numero: ");

                        n=int.Parse(Console.ReadLine());

                        if (n < maiorvalor)
                        {
                            maiorvalor = n;
                        }
                        if (n < menorvalor)
                        {
                            menorvalor = n;
                        }
                        Console.WriteLine(" igite 0 para sair ou 1 para continuar");
                        parada = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("maior numero: "+maiorvalor);
                    Console.WriteLine("menor numero: "+menorvalor);
                    Console.ReadKey();


                    break;
                case 6:
                    int numero, soma = 0;

                    Console.WriteLine("digite o numero inteiro: ");
                    numero = int.Parse(Console.ReadLine());



                    for (int i = 1; i < numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            soma = soma + i;
                        }
                    }
                    if (soma == numero)
                    {
                        Console.WriteLine("numero é perfeito");
                    }
                    else
                    {
                        Console.WriteLine("numero é imperfeito");
                    }
                    Console.ReadKey();

                    break;
                case 7:
                    Console.WriteLine("não sei fazer essa");

                    


                    break;
            }


        }
    }
}
