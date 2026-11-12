int num1 = 0;
int par = 0;
int impar = 0;

int[] numeros = new int[5];
int[] pares = new int[5];
int[] impares = new int[5];

void LerInteiro()
{
    Console.WriteLine("Digite 5 numeros inteiros:");
    Console.WriteLine("===== DE FRENTE PRA TRAS =====");

    while (num1 < 5)
    {
        numeros[num1] = int.Parse(Console.ReadLine());

        if (numeros[num1] % 2 == 0)
        {
            pares[par] = numeros[num1];
            par++;
        }
        else
        {
            impares[impar] = numeros[num1];
            impar++;
        }

        Console.WriteLine($"Numero {numeros[num1]} adicionado no indice {num1}");

        num1++;
    }

    Console.WriteLine("\nDE TRAS PRA FRENTE");

    for (int j = num1 - 1; j >= 0; j--)
    {
        Console.WriteLine($"Numero {numeros[j]} está no indice {j}");
    }

    Console.WriteLine("\n==== PARES ====");

    for (int i = 0; i < par; i++)
    {
        Console.WriteLine(pares[i]);
    }

    Console.WriteLine("\n==== IMPARES ====");

    for (int i = 0; i < impar; i++)
    {
        Console.WriteLine(impares[i]);
    }
}

LerInteiro();