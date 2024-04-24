const int size = 5;
float[,] matriz_1 = new float[size, size];
float[,] matriz_2 = new float[size, size];
int lin, col;
float[,] Gerar_Matriz(float[,] matriz, string name)
{
    for (lin = 0; lin < size; lin++)
    {
        for (col = 0; col < size; col++)
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
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            Console.Write($"{matriz[i, j]} "); ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Menu(float[,] matriz_1, float[,] matriz_2)
{
    float[,] resultado = new float[size, size];
    string operacao = "";
    int lin, col, op;
    do
    {
        do
        {
            Console.Write("\nDigite um número para escolher a operação:\n1-) Soma\n2-) Subtração\n3-) Multiplicação\n4-) Divisão\n5-) Sair\n");
            op = int.Parse(Console.ReadLine());
        } while ((op < 1) || (op > 5));
        for (lin = 0; lin < size; lin++)
        {
            for (col = 0; col < size; col++)
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

}
Menu(Gerar_Matriz(matriz_1, "A"), Gerar_Matriz(matriz_2, "B"));