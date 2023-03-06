// CRIANDO VARIAVEIS 
string[,] media = new string[5,7];
int l = 0;
int c = 0;

int trabalho = 0;
double total = 0;
string resultado = " ";
double presenca = 0;
double nota1 = 0;
double nota2 = 0;
double nota3 = 0;

for (l = 0; l <= 4; l++)
{
    Console.WriteLine("Bem vindo, Professor(a) \n -> Informe o nome do Aluno desejado");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe o numero de aulas dadas");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe o nome de faltas do aluno");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe a PRIMEIRA PROVA");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe a SEGUNDA PROVA");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe a TERCEIRA PROVA");
    media[l, c++] = Console.ReadLine();
    Console.WriteLine("-> Informe a nota do TRABALHO");
    media[l, c++] = Console.ReadLine();
    c = 0;

    nota1 = Double.Parse(media[l, 3]) * 0.30;
    nota2 = Double.Parse(media[l, 4]) * 0.25;
    nota3 = Double.Parse(media[l, 5]) * 0.35;

    total = (nota1 + nota2 + nota3) / 3 + trabalho;
    presenca = (double.Parse(media[l, 2]) / double.Parse(media[l, 1])) * 100;

    if (total >= 6 && presenca <= 25)
    {
        resultado = "Aprovado";
    }
    if (total < 6 && presenca <= 25)
    {
        resultado = "Reprovado por Menção";
    }
    if (total >= 6 && presenca > 25)
    {
        resultado = "Reprovado por Faltas";
    }
    if (total < 6 && presenca > 25)
    {
        resultado = "Reprovado por Menção e Faltas";
    }

    Console.WriteLine(media[l, 0] + ", sua nota foi de: " + total + " sua cota de falta foi de: " + presenca + "%, o Aluno foi " + resultado);

}