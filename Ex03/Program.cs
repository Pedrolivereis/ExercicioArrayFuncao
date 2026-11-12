Console.WriteLine("Informe um numero: ");
int num = int.Parse(Console.ReadLine());
int[] vetor = new int[num];
vetor = fibonacci(num);

int[] fibonacci(int num)
{
    int[] novoVetor = new int[num];

    int a = 1, b = 0, aux = a;
    novoVetor[0] = b;

    for (int i = 1; i < num; i++)
    {
        novoVetor[i] = aux;
        aux = a + b;
        b = a;
        a = aux;
    }
    return novoVetor;
}
void imprimirVetor(int[] vetor)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write(vetor[i] + " ");
    }
}
imprimirVetor(vetor);