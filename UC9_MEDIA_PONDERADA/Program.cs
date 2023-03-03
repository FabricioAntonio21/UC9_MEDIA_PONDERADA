// CRIANDO VARIAVEIS 
string[,] media = new string[5,7];
int l = 0;
int c = 0;

int trabalho = 0;
double total = 0;
string resultado = " ";
double presenca = 0;
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

    total = ((int.Parse(media[l, 3]) + int.Parse(media[l, 4]) + int.Parse(media[l, 5])) / 3 ) + trabalho;
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