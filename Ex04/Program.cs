int tamnaho = 10;
char[] vetor1 = new char[tamnaho];
string[] vetor2 = new string[tamnaho*2];

void PopularVetor(char[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Informe a letra desejada: ");
        vetor[i] = char.Parse(Console.ReadLine());
    }
}

int ConverterAscci(char letra)
{
    return (int)letra;
}

void CriarVetorAscii()
{


    for (int i = 0; i < vetor2.Length; i+=2)
    {
        vetor2[i] = vetor1[i / 2].ToString();
        vetor2[i+1] = ConverterAscci(vetor1[i / 2]).ToString(); 
    }
}

void ExibirVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.Write($"[{vetor[i]}]");
    }
    Console.WriteLine("\n");
}

PopularVetor(vetor1);

string[] temp = new string[vetor1.Length];
for (int i = 0; i < vetor1.Length; i++)
{
    temp[i] = vetor1[i].ToString();
}


ExibirVetor(temp);
CriarVetorAscii();
ExibirVetor(vetor2);