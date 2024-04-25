using System;

const int size = 5;
float[,] matriz_1 = new float[size, size];
float[,] matriz_2 = new float[size, size];
int lin, col;
int lin_size = Definir_Tamanho(1);
int Col_size = Definir_Tamanho(2);

int Definir_Tamanho(int num)
{
    string lin_Col = "";
    if (num == 1)
    {
        lin_Col = "Linha";
    }
    else
    {
        lin_Col = "Coluna";
    }
    Console.Write($"\nInsira a quantidade de {lin_Col} da matriz: ");
    return int.Parse(Console.ReadLine());
}
float[,] Gerar_Matriz(float[,] matriz, string name)
{

    for (lin = 0; lin < lin_size; lin++)
    {
        for (col = 0; col < Col_size; col++)
        {
            matriz[lin, col] = new Random().Next(1, 100);
        }
    }
    Imprimir_Matriz(name, matriz, size);
    return matriz;
}
void Imprimir_Matriz(string operacao, float[,] matriz, int size)
{
    Console.WriteLine($"\nImprimindo Matriz {operacao}: \n");
    for (int i = 0; i < lin_size; i++)
    {
        for (int j = 0; j < Col_size; j++)
        {
            Console.Write($"{matriz[i, j]:000} "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int Menu()
{
    int op;
    do
    {
        Console.Write("\nDigite um número para escolher a operação:\n1-) Soma\n2-) Subtração\n3-) Multiplicação\n4-) Divisão\n5-) Sair\n");
        op = int.Parse(Console.ReadLine());
    } while ((op < 1) || (op > 5));
    return op;
}


int op = 0;
do
{
    op = Menu();

    matriz_1 = Gerar_Matriz(matriz_1, "A");
    matriz_2 = Gerar_Matriz(matriz_2, "B");

    float[,] resultado = new float[size, size];
    string operacao = "";

    for (lin = 0; lin < lin_size; lin++)
    {
        for (col = 0; col < Col_size; col++)
        {
            switch (op)
            {
                case 1:
                    resultado[lin, col] = matriz_1[lin, col] + matriz_2[lin, col];
                    operacao = "A + B";
                    break;
                case 2:
                    resultado[lin, col] = matriz_1[lin, col] - matriz_2[lin, col];
                    operacao = "A - B";
                    break;
                case 3:
                    resultado[lin, col] = matriz_1[lin, col] * matriz_2[lin, col];
                    operacao = "A * B";
                    break;
                case 4:
                    resultado[lin, col] = matriz_1[lin, col] / matriz_2[lin, col];
                    operacao = "A / B";
                    break;
                default:
                    break;
            }
        }
    }

    Imprimir_Matriz(operacao, resultado, size);
} while (op != 5);
