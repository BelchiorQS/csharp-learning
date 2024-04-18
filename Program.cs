using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_CSharp
{
    public class Jogador
    {
        //Propriedades da classe
        public int energia;
        public bool vivo;
        public string nome;
        //Construtor da classe
        public Jogador(string nome)
        {
            energia = 100;
            vivo = true;
            this.nome = nome;
        }
        public Jogador(string nome, int energia)
        {
            this.energia = energia;
            vivo = true;
            this.nome = nome;
        }
        public Jogador(string nome, int energia, bool vivo)
        {
            this.energia = energia;
            this.vivo = vivo;
            this.nome = nome;
        }
        public Jogador()
        {
            energia = 100;
            vivo = true;
            this.nome = "Jogador";
        }
        //Destrutor da Classe
        ~Jogador() { Console.WriteLine($"Jogador {nome} foi destruido!"); }
        public void info() { Console.WriteLine($"Jogador: {nome}\nEnergia: {energia}\nStatus: {vivo}"); }
    }
    static public class Jogadores
    {
        //Propriedades da classe
        static public int energia;
        static public bool vivo;
        static public string nomes;
        static public void Iniciar(string nome)
        {
            energia = 100;
            vivo = true;
            nomes = nome;
        }
        static public void info() { Console.WriteLine($"Jogador: {nomes}\nEnergia: {energia}\nStatus: {vivo}"); }
    }
    class Inimigo
    {
        static public bool alerta;
        public string nome;
        public Inimigo(string nome)
        {
            alerta = true;
            this.nome = nome;
        }
        public void info() { Console.WriteLine($"Inimigo: {nome}\nStatus: {alerta}"); Console.WriteLine("---------------------"); }
    }
    class Calculos
    {
        public int v1;
        public int v2;
        public Calculos(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
        public int somar() { return v1 + v2; }

    }
    class Jogadas
    {
        private int energia;
        private string nome;

        public Jogadas(string nome)
        {
            this.nome = nome;
            energia = 100;
        }
        public int Getenergia()
        {
            return energia;
        }
        public string Getnome()
        {
            return nome;
        }

        public void setEnergia(int e)
        {
            if (e < 0)
                if (energia + e < 0)
                    energia = 0;
                else
                    energia += e;
            else if (e > 0)
                if (energia + e > 100)
                    energia = 100;
                else
                    energia += e;
        }
    }
    class Veiculo //Classe Base
    {
        //Propriedades
        public int velMax;
        private bool ligado;
        public int rodas;

        public Veiculo(int roda)
        {
            this.rodas = roda;
        }


        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "SIM" : "Não");
        }

        public int getRodas() { return rodas; }
        public void setRodas(int rodas)
        {
            if (rodas < 0)
                this.rodas = 0;
            else if (rodas > 40)
                rodas = 40;
            else
                this.rodas = rodas;
        }
    }
    class carro : Veiculo //classe derivada
    {
        public string nome = string.Empty;
        public string cor = string.Empty;
        public carro(string nome, string cor) : base(4)
        {
            desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }
    class CarroCombate : carro
    {
        public int monicao;
        public CarroCombate() : base("Carro de Combate", "vermelho")
        {
            monicao = 100;
            setRodas(6);
        }

    }
    internal class Program
    {
        static int num1 = 10;
        enum DaysWeek
        {
            Domingo,
            Segunda,
            terça,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        };
        static void Main(string[] args)
        {
            #region Aula 01: Variaveis
            //int num = 10;
            //char letra = 'a';
            //float valor = 1.0f;
            //byte bit = 255;
            //string nome = "Belchior";
            //var Versatil = nome;

            //Console.WriteLine(num);
            //Console.WriteLine(letra);
            //Console.WriteLine(valor);
            //Console.WriteLine(bit);
            //Console.WriteLine("Meu nome é : "+nome);

            //Console.WriteLine($"Me chamo {Versatil} e tenho {num + num} anos de idade ");
            #endregion

            #region Aula 02: Escopo de Variaveis
            //int num2 = 20;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            #endregion

            #region Aula 03: Operadores e operações
            ////Aritmétricos
            //int result = (10 + 5) *2;
            //int num = 10;
            //num++;

            ////Logicos e realacionais
            //bool res = (5>7) && (10<5);

            //Console.WriteLine(res);
            //Console.WriteLine(result);
            //Console.WriteLine(num);
            #endregion

            #region Aula 04: Formatação de saída
            //int num1, num2,num3;
            //num1 = 10; num2 = 20; num3 = 30;

            //double valuePay = 1.50;
            //double spand ;
            //double lucro = 0.1;
            //string produt = "Pastel";

            //spand =valuePay + (valuePay*lucro);

            //Console.WriteLine("Produto..............:{0,15}",produt);
            //Console.WriteLine("Valor de Compra......:{0,15:c}",valuePay);
            //Console.WriteLine("Lucro................:{0,15:p}",lucro);
            //Console.WriteLine("Valor de Venda.......:{0,15:c}",lucro);

            //Console.WriteLine("\nnumero 1 :{0},\nnumero 3 :{1},\nnumero 1 :{2}",num1,num2,num3);
            #endregion

            #region Aula 05: Constantes
            //const string nome = "Belchior";
            //const double pi = 3.1415;

            //Console.WriteLine($"Nome: {nome}\nPI: {pi}");
            #endregion

            #region Aula 06: Entrada de dados
            //int v1, v2, soma;
            //string nome =string.Empty;
            //Console.Write("Digite o Primeiro valor:");
            //v1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo valor:");
            //v2 = Convert.ToInt32(Console.ReadLine());

            //soma = v1 + v2;

            //Console.WriteLine($"A soma de {v1} + {v2} é igual a {soma}");
            #endregion

            #region Aula 07: Operadores de Bitwise
            //int num = 10;
            //int num2 = 10;
            //num <<= 1;
            //num2 >>= 1;

            //Console.WriteLine(num);
            //Console.WriteLine(num2);
            #endregion

            #region Aula 08: Enumeradosres
            //DaysWeek dia = (DaysWeek)3;

            //int day = (int)DaysWeek.Quarta;

            //Console.WriteLine(day);
            //Console.WriteLine(dia);
            #endregion

            #region Aula 09: Conversões de tipos (TypeCast)
            //float num1 = 10.2f;
            //int num2 = (int)num1; //TypeCast
            //short num4 = (short)num2;

            //Console.WriteLine(num2);
            //Console.WriteLine(num4);
            #endregion

            #region Aula 10: Condicional IF
            //Console.Write("informe um valor: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 10) { Console.WriteLine("Aluno Reprovado!"); }
            //else { Console.WriteLine($"Aluno Aprovado com a nota de {num} valores"); }
            #endregion

            #region Aula 11: Condicional Aninhados (Else-IF)
            //Console.Write("informe um valor: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 9) { Console.WriteLine("Aluno Reprovado!"); }
            //else if (num == 9) { Console.WriteLine("Aluno foi a Recurso!"); }
            //else { Console.WriteLine($"Aluno Aprovado com a nota de {num} valor");}
            #endregion

            #region Aula 12: Função Swicth Case
            //Console.WriteLine($"1-Curso de Engenharia Informática.....{2000:C}");
            //Console.WriteLine($"2-Curso de Engenharia De Computação...{2000:C}");
            //Console.WriteLine($"3-Curso de Engenharia Eletrotecnia....{2000:C}\n");

            //Console.Write("Informe a sua escolha: ");
            //int escolha = int.Parse(Console.ReadLine());
            //switch (escolha)
            //{
            //    case 1:
            //        Console.WriteLine("Benvindo ao CURSO DE INFORMATICA");
            //        break;
            //    case 2:
            //        Console.WriteLine("Benvindo ao CURSO DE COMPUTAÇÃO");
            //        break;
            //    case 3:
            //        Console.WriteLine("Benvindo ao CURSO DE ELETROTECNIA");
            //        break ;
            //    default:
            //        Console.WriteLine("Escolha não permitida!");
            //    break;
            //}
            #endregion

            #region Aula 13: Função Goto 
            //inicio:
            //Console.Clear();
            //Console.WriteLine($"1-Curso de Engenharia Informática.....{2000:C}");
            //Console.WriteLine($"2-Curso de Engenharia De Computação...{2000:C}");
            //Console.WriteLine($"3-Curso de Engenharia Eletrotecnia....{2000:C}\n");

            //Console.Write("Informe a sua escolha: ");
            //int escolha = int.Parse(Console.ReadLine());
            //switch (escolha)
            //{
            //    case 1:
            //        Console.WriteLine("Benvindo ao CURSO DE INFORMATICA");
            //        break;
            //    case 2:
            //        Console.WriteLine("Benvindo ao CURSO DE COMPUTAÇÃO");
            //        break;
            //    case 3:
            //        Console.WriteLine("Benvindo ao CURSO DE ELETROTECNIA");
            //        break;
            //    default:

            //    break;
            //}
            //Console.WriteLine("Calcular novamente? [S/N]");
            //escolha = char.Parse(Console.ReadLine());
            //if (escolha == 's' || escolha == 'S')
            //{
            //    goto inicio;
            //}
            //else
            //{
            //    Console.Clear();
            //    Console.WriteLine("Fim do programa....");
            //}
            #endregion

            #region Aula 14: Array (Vetor)
            //int[] vetor = new int[5];
            //vetor[0]= 10;
            //vetor[1]= 20;
            //vetor[2]= 30;
            //vetor[3]= 40;
            //vetor[4]= 50;

            //int[] array = new int[3] {60,70,80 };
            //int[] array2 = {90,100,110 };

            //Console.WriteLine($"Vetor: {vetor[1]}");
            //Console.WriteLine($"Array: {array[1]}"); 
            //Console.WriteLine($"Array2: {array2[1]}");
            #endregion

            #region Aula 15: Matrizes
            //int[,] vetor = new int[2,3];
            //vetor[0, 0] = 10;
            //vetor[0, 1] = 20;
            //vetor[0, 2] = 30;

            //vetor[1, 0] = 40;
            //vetor[1, 1] = 50;
            //vetor[1, 2] = 60;

            //Console.WriteLine($"Vetor: {vetor[1,1]}");
            #endregion

            #region Aula 16: Loop For
            //int[] num = new int[10];

            //for (int i = 0; i < num.Length; i++) 
            //{
            //    num[i] = i;
            //    Console.WriteLine(num[i]);
            //}
            #endregion

            #region Aula 17: Loop while
            //int[] num = new int[10];

            //int i = 0;
            //while (i < num.Length)
            //{
            //    num[i] = i;
            //    Console.WriteLine(num[i]);
            //    i++;
            //}
            #endregion

            #region Aula 18: Loop while
            //int[] num = new int[10];

            //int i = 0;
            //do{
            //    num[i] = i;
            //    Console.WriteLine(num[i]);
            //    i++;
            //} while (i < num.Length) ;           
            #endregion

            #region Aula 19: Loop Foreach
            //int[] num = new int[3] { 10, 20, 30 };

            //foreach (var item in num)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Aula 20: Métodos da Classe Array 
            //int[] vetor1 = new int[5];
            //int[] vetor2 = new int[5];
            //int[] vetor3 = new int[5];
            //int[,] matriz = new int[2, 5] { { 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 100 } };

            //Random rand = new Random();
            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    vetor1[i] = rand.Next(50);
            //}

            //Console.WriteLine(".....Elementos do Vetor 1:");
            //foreach (var item in vetor1)
            //{
            //    Console.WriteLine(item);
            //}

            ////public static int BinarySearch(array, vaolor);
            //Console.WriteLine("BinarySearch:");
            //int wanted = 30;
            //int pos = Array.BinarySearch(vetor1, wanted);
            //Console.WriteLine($"O valor {wanted} está na posição {pos}");
            //Console.WriteLine("...........................................");

            ////public static void copy(array_origem, array_destino,quantidade);
            //Console.WriteLine("Copy:");
            //Array.Copy(vetor1, vetor2, vetor1.Length);
            //foreach (var item in vetor2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("...........................................");

            ////public static void copyTo(array_destino, apartir_desta_posição);
            //Console.WriteLine("CopyTo:");
            //vetor2.CopyTo(vetor3, 0);
            //foreach (var item in vetor3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("...........................................");

            ////public long GetLongLength(Dimensão);
            //Console.WriteLine("GetLongLength:");
            //long quant_elemento = vetor1.GetLongLength(0);
            //Console.WriteLine("Quantidade de elemento: " + quant_elemento);
            //Console.WriteLine("...........................................");

            ////public long GetLowerBound(Dimensão);
            //Console.WriteLine("GetLowerBound:");
            //int menor_indice_vetor = vetor1.GetLowerBound(0);
            //int menor_indice_matriz = matriz.GetLowerBound(1);
            //Console.WriteLine("Menor Indice do Vetor1: " + menor_indice_vetor);
            //Console.WriteLine("Menor Indice da matriz: " + menor_indice_matriz);
            //Console.WriteLine("...........................................");

            ////public long GetUpperBound(Dimensão);
            //Console.WriteLine("GeUpperBound:");
            //int maior_indice_vetor = vetor1.GetUpperBound(0);
            //int maior_indice_matriz = matriz.GetUpperBound(1);
            //Console.WriteLine("Maior Indice do Vetor1: " + maior_indice_vetor);
            //Console.WriteLine("Maior Indice da matriz: " + maior_indice_matriz);
            //Console.WriteLine("...........................................");

            ////public long GetValue(Long indice);
            //Console.WriteLine("GeValue:");
            //int valor1 = Convert.ToInt32(vetor1.GetValue(3));
            //int valor2 = Convert.ToInt32(matriz.GetValue(1, 3));
            //Console.WriteLine("Valor da Posição 3  do Vetor 1: " + valor1);
            //Console.WriteLine("Valor da Posição 1,3  da matriz: " + valor2);
            //Console.WriteLine("...........................................");

            ////public static int IndexOf(array, valor);
            //Console.WriteLine("IndexOf:");
            //int indice = Array.IndexOf(vetor1, 3);
            //Console.WriteLine("Indice do primeiro valor 3 do vetor 1: " + indice);
            //Console.WriteLine("...........................................");

            ////public static int IndexOf(array, valor);
            //Console.WriteLine("LastIndexOf:");
            //int indice2 = Array.LastIndexOf(vetor1, 3);
            //Console.WriteLine("Indice do ultimo valor 3 do vetor 1: " + indice);
            //Console.WriteLine("...........................................");

            ////public static void Reverse(array);
            //Console.WriteLine("Reverse:");
            //Array.Reverse(vetor1);

            //foreach (var item in vetor1)
            //{
            //    Console.WriteLine("Sequencia invertida: " + item);
            //}
            //Console.WriteLine("...........................................");

            ////public void SetValue(Object valor, long pos);
            //Console.WriteLine("SetValue:");
            //vetor2.SetValue(99, 0);

            //for (int i = 0; i < vetor2.Length; i++)
            //{
            //    vetor2.SetValue(0, i);
            //}

            //foreach (var item in vetor2)
            //{
            //    Console.WriteLine("vetor 2: " + item);
            //}
            //Console.WriteLine("...........................................");

            ////public static void Sort(array);
            //Console.WriteLine("Sorte:");
            //Array.Sort(vetor1);
            //Array.Sort(vetor2);
            //Array.Sort(vetor3);

            //Console.WriteLine("Vetor 1: ");
            //foreach (var item in vetor1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Vetor 2: ");
            //foreach (var item in vetor2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Vetor 3: ");
            //foreach (var item in vetor3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("...........................................");
            #endregion

            #region Aula 21: Métodos
            //ola();

            //Console.Write("Informe o primeiro valor:");
            //int v1 = int.Parse(Console.ReadLine());
            //Console.Write("Informe o segundo valor:");
            //int v2 = int.Parse(Console.ReadLine());

            //Soma(v1, v2);
            //int resultado = mult(v1, v2);

            //Console.WriteLine($"O resultado da Multiplicação entre {v1} x {v2} é igual a {resultado}");
            #endregion

            #region Aula 22: Passagem de valor por velor e referencia
            //int num = 50;
            //int num1 = 50;

            //dobrar(ref num);
            //dobrar2(num);

            //Console.WriteLine(num);
            //Console.WriteLine(num1);
            #endregion

            #region Aula 23: Argumento Out
            //int dividendo = 50;
            //int divisor = 2;
            //int resto;
            //int quociente = divide(dividendo, divisor, out resto);
            //Console.WriteLine($"{dividendo} / {divisor} = {quociente},com o resto {resto}");
            #endregion

            #region Aula 24: Argumentos de Entrada Params
            //somasParams(12,12,43,5,6);
            #endregion

            #region Aula 25: Classes e Objetos
            //Jogador jogador1 = new Jogador();
            //Jogador jogador2 = new Jogador();
            //Jogador jogador3 = new Jogador();

            //Console.WriteLine($"Energia do Jogador 1: {jogador1.energia}");
            //Console.WriteLine($"Energia do Jogador 2: {jogador2.energia}");
            //Console.WriteLine($"Energia do Jogador 3: {jogador3.energia}");
            #endregion

            #region Aula 26: Construtores e Destrutores
            //Console.Write("Digite o nome do Jogador 1:");
            //string nome = Console.ReadLine();

            //Jogador j1 = new Jogador(nome);
            //Jogador j2 = new Jogador("Soares");

            //Console.WriteLine("O nome do Jogador 1: "+j1.nome);
            //Console.WriteLine("O nome do Jogador 2: "+j2.nome);
            #endregion

            #region Aula 27: Sobrecarga de Construtores
            //Jogador jogador1 = new Jogador();
            //Jogador jogador2 = new Jogador("Belchior");
            //Jogador jogador3 = new Jogador("Belchior",50);
            //Jogador jogador4 = new Jogador("Belchior",60,true);

            //jogador1.info();
            //jogador2.info();
            //jogador3.info();
            //jogador4.info();
            #endregion

            #region Aula 28: Classes Statics
            //Jogadores.Iniciar("Belchior");
            //Jogadores.info();

            //Inimigo i1 = new Inimigo("Ti Paulo");
            //Inimigo i2 = new Inimigo("Ti Soares");
            //Inimigo i3 = new Inimigo("Ti Bernardo");

            //Inimigo.alerta = true;

            //i1.info();
            //i2.info();
            //i3.info();
            #endregion

            #region Aula 29: Oprador This
            //Calculos c = new Calculos(10, 2);

            //Console.WriteLine(c.somar()); 
            #endregion

            #region Aula 30: public vs Private
            //Jogadas Jd1 = new Jogadas("Belchior");

            //Jd1.setEnergia(-50);

            //Console.WriteLine($"Nome: {Jd1.Getnome()}");
            //Console.WriteLine($"Energia: {Jd1.Getenergia()}");
            #endregion

            #region Aula 31: Herança
            //carro c1 = new carro("Rapidaão","Vermelho");
            //Console.WriteLine("Nome: "+c1.nome);
            //Console.WriteLine("Cor: "+c1.cor);
            //Console.WriteLine("Rodas: "+c1.rodas);
            //Console.WriteLine("Velocidade: "+c1.velMax);
            //Console.WriteLine("Ligado: "+c1.getLigado());
            #endregion

            #region Aula 32: Cadeia de Herança e Construtores
            //carro c1 = new carro("Rapidaão", "Vermelho");
            //CarroCombate cb = new CarroCombate();

            //c1.ligar();

            //Console.WriteLine("Nome: " + c1.nome);
            //Console.WriteLine("Cor: " + c1.cor);
            //Console.WriteLine("Rodas: " + c1.getRodas());
            //Console.WriteLine("Velocidade: " + c1.velMax);
            //Console.WriteLine("Ligado: " + c1.getLigado());
            //Console.WriteLine("----------------------------");

            //Console.WriteLine("Nome: " + cb.nome);
            //Console.WriteLine("Cor: " + cb.cor);
            //Console.WriteLine("Rodas: " + cb.getRodas());
            //Console.WriteLine("Velocidade: " + cb.velMax);
            //Console.WriteLine("Ligado: " + cb.getLigado());
            //Console.WriteLine("Monição: " + cb.monicao);
            #endregion
        }
        static void ola() { Console.WriteLine("Belchior Soares"); }
        static void Soma(int n1, int n2)
        {
            int result = n1 + n2;
            Console.WriteLine($"O resultado da soma entre {n1} + {n2} é igual a {result}");
        }
        static int mult(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
        static void dobrar(ref int referencia)
        {
            referencia <<= 1;
        }
        static void dobrar2(int valor)
        {
            valor <<= 1;
        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
        static void somasParams(params int[] n)
        {
            int result = 0;
            if (n.Length < 1)
                Console.WriteLine("Não tem valores a serem somados");
            else if (n.Length == 1)
                Console.WriteLine("valores insuficientes para serem somados");
            else
            {
                for (int i = 0; i < n.Length; i++)
                {
                    result = result + n[i];
                }
                Console.WriteLine("A soma dos valores é : " + result);
            }
        }
    }
}
