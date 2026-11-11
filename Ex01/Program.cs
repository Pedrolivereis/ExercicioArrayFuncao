char[] caracteres = new char[6];
int contador = 0;
void LerEAdicionarEmOrdem()
{
    Console.WriteLine("Digite 6 caracteres:");
    Console.WriteLine("=====DE FRENTE PRA TRÁS=====");
    while (contador < 6)
    {
        caracteres[contador] = char.Parse(Console.ReadLine());
        Console.WriteLine($"\nCaractere {caracteres[contador]} adicionado\n");
        contador++;
    }
    Console.WriteLine("=====DE TRÁS PRA FRENTE=====");
    while (contador > 0)
    {
        contador--;
        Console.WriteLine($"\nCaractere {caracteres[contador]} adicionado.\n");
    }
}
LerEAdicionarEmOrdem();