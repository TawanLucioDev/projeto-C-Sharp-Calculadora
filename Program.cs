// See https://aka.ms/new-console-template for more information

class Program 
{

static void Main(string[] args)
{
    Menu();
}

static void Menu(){

    Console.Clear();
    Console.WriteLine("Qual operação você deseja efetuar?");
    
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Resto");
    Console.WriteLine("6 - sair");

    Console.WriteLine("");

    Console.WriteLine("Escolha uma opção:");
    short result = short.Parse(Console.ReadLine());

    switch(result){

        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Resto(); break;
        case 6:System.Environment.Exit(0); break;
        default: Menu(); break;
    }

}

static void Soma()
{
Console.Clear();

Console.WriteLine("Digite um valor:");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine(" ");

float resultado = v1 + v2;

Console.WriteLine("O valor da sua soma é:" + resultado);

Console.ReadKey();

Menu();

}

static void Subtracao()
{
Console.Clear();

Console.WriteLine("Digite um valor:");
float v3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor:");
float v4 = float.Parse(Console.ReadLine());

Console.WriteLine("");

float resultado2 = v3 - v4;

Console.WriteLine("O Resultado da Subtração é:" + resultado2);

Console.ReadKey();

Menu();

}

static void Divisao(){
    Console.Clear();
    
    Console.WriteLine("Digite um valor: ");
    float v5 = float.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite um segundo valor: ");
    float v6 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado3 = v5/v6;

    Console.WriteLine("O Resultado da Divisão é:" + resultado3);

    Console.ReadKey();

    Menu();

}

static void Multiplicacao(){
    Console.Clear();
    
    Console.WriteLine("Digite um valor:");
    float v7 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite um segundo valor:");
    float v8 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado4 = v7*v8;

    Console.WriteLine("O resultado da Multiplicação é:" + resultado4);

    Console.ReadKey();

    Menu();
}

static void Resto(){

    Console.Clear();

    Console.WriteLine("Digite um valor:");
    float v9 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite um Segundo valor:");
    float v10 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado5 = v9%v10;

    Console.WriteLine("O resto da divisão é:" + resultado5);

    Console.ReadKey();

    Menu();
}

}


