using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Parte 1
        Parte1();
        // Parte 2
        Parte2();
        // Parte 3
        Parte3();
        // Parte 4
        Parte4();
        // Parte 5
        Parte5();
        // Parte 6
        Parte6();
        // Parte 7
        Parte7();
        // Parte 8
        Parte8();
        // Parte 9
        Parte9();
        // Parte 10
        Parte10();
    }

    static void Parte1()
    {
        Console.Write("Quantos alunos? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite as três notas do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Digite A para média aritmética ou P para média ponderada: ");
            char tipoMedia = char.Parse(Console.ReadLine().ToUpper());

            CalcularMedia(nota1, nota2, nota3, tipoMedia);
        }
    }

    static void CalcularMedia(double nota1, double nota2, double nota3, char tipoMedia)
    {
        if (tipoMedia == 'A')
        {
            double media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"Média Aritmética: {media}");
        }
        else if (tipoMedia == 'P')
        {
            double mediaPonderada = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
            Console.WriteLine($"Média Ponderada: {mediaPonderada}");
        }
    }

    static void Parte2()
    {
        List<double> salarios = new List<double>();
        List<int> filhos = new List<int>();

        while (true)
        {
            Console.Write("Digite o salário (ou -1 para sair): ");
            double salario = double.Parse(Console.ReadLine());
            if (salario == -1) break;

            Console.Write("Digite o número de filhos: ");
            int numFilhos = int.Parse(Console.ReadLine());

            salarios.Add(salario);
            filhos.Add(numFilhos);
        }

        CalcularMediaSalario(salarios);
    }

    static void CalcularMediaSalario(List<double> salarios)
    {
        double soma = 0;
        foreach (var salario in salarios)
        {
            soma += salario;
        }

        double media = soma / salarios.Count;
        Console.WriteLine($"Média de Salário: {media}");
    }

    static void Parte3()
    {
        Console.Write("Quantos conjuntos de valores? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite os três valores: ");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());

            ExibirEmOrdemCrescente(valor1, valor2, valor3);
        }
    }

    static void ExibirEmOrdemCrescente(int valor1, int valor2, int valor3)
    {
        int[] valores = new int[] { valor1, valor2, valor3 };
        Array.Sort(valores);
        Console.WriteLine($"Valores em ordem crescente: {valores[0]}, {valores[1]}, {valores[2]}");
    }

    static void Parte4()
    {
        while (true)
        {
            Console.Write("Digite os três lados do triângulo (ou -1 para sair): ");
            double x = double.Parse(Console.ReadLine());
            if (x == -1) break;
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            VerificarTriangulo(x, y, z);
        }
    }

    static void VerificarTriangulo(double x, double y, double z)
    {
        if (x < y + z && y < x + z && z < x + y)
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Não é um triângulo");
        }
    }

    static void Parte5()
    {
        Console.Write("Digite dois números para calcular o MDC: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int mdc = CalcularMDC(a, b);
        Console.WriteLine($"MDC de {a} e {b}: {mdc}");
    }

    static int CalcularMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Parte6()
    {
        Console.Write("Quantos números? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            bool isPositivo = VerificarPositivo(numero);
            Console.WriteLine(isPositivo ? "Positivo" : "Negativo");
        }
    }

    static bool VerificarPositivo(int numero)
    {
        return numero >= 0;
    }

    static void Parte7()
    {
        Console.Write("Quantos alunos? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite a média final do aluno: ");
            int media = int.Parse(Console.ReadLine());

            ExibirConceito(media);
        }
    }

    static void ExibirConceito(int media)
    {
        if (media < 40)
        {
            Console.WriteLine("Conceito: F");
        }
        else if (media < 60)
        {
            Console.WriteLine("Conceito: E");
        }
        else if (media < 70)
        {
            Console.WriteLine("Conceito: D");
        }
        else if (media < 80)
        {
            Console.WriteLine("Conceito: C");
        }
        else if (media < 90)
        {
            Console.WriteLine("Conceito: B");
        }
        else
        {
            Console.WriteLine("Conceito: A");
        }
    }

    static void Parte8()
    {
        Console.Write("Digite o valor de N: ");
        int n = int.Parse(Console.ReadLine());

        double resultado = CalcularSerie(n);
        Console.WriteLine($"Valor de S: {resultado}");
    }

    static double CalcularSerie(int n)
    {
        double s = 0;
        for (int i = 1; i <= n; i++)
        {
            s += (Math.Pow(i, 2) + 1) / (double)(i + 3);
        }
        return s;
    }

    static void Parte9()
    {
        Console.Write("Quantos alunos? ");
        int n = int.Parse(Console.ReadLine());

        List<double> notas = new List<double>();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        double mediaAprovados = CalcularMediaAprovados(notas);
        Console.WriteLine($"Média dos alunos aprovados: {mediaAprovados}");
    }

    static double CalcularMediaAprovados(List<double> notas)
    {
        double soma = 0;
        int count = 0;
        foreach (var nota in notas)
        {
            if (nota >= 6)
            {
                soma += nota;
                count++;
            }
        }
        return count > 0 ? soma / count : 0;
    }

    static void Parte10()
    {
        Console.Write("Digite a idade do nadador: ");
        int idade = int.Parse(Console.ReadLine());

        string categoria = VerificarCategoria(idade);
        Console.WriteLine($"Categoria: {categoria}");
    }

    static string VerificarCategoria(int idade)
    {
        if (idade >= 5 && idade <= 7)
        {
            return "F";
        }
        else if (idade >= 8 && idade <= 10)
        {
            return "E";
        }
        else if (idade >= 11 && idade <= 13)
        {
            return "D";
        }
        else if (idade >= 14 && idade <= 15)
        {
            return "C";
        }
        else if (idade >= 16 && idade <= 17)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }
}
