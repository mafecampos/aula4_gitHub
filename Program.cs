using System;
class HelloWorld
{
    static void Main(String[] args)
    {
        string nome = "Mafe amiga da Livs";
        Console.WriteLine(nome);
        Console.WriteLine("Sabia que eu tenho poderes? Escolhe um número de 1 a 3 ai");
        int escolha = Convert.ToInt32(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.BackgroundColor = ConsoleColor.Black;
                break;
            case 2:
                Console.BackgroundColor = ConsoleColor.Magenta;
                break;
            case 3:
                Console.BackgroundColor = ConsoleColor.Cyan;
                break;
        }
        Console.Clear();
        Console.WriteLine("EU SOU O SUPER PINTADINHO");
        Console.ReadLine();
    }
}