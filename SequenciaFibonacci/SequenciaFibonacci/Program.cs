using System;
class SequenciaFibonacci
{
    static void Main(string[] args)
    {
        int elemento1 = 0;
        int elemento2 = 1;
        int auxiliar;

        for (int i = 0; i < 20; i++)
        {
            auxiliar = elemento1;
            elemento1 = elemento2;
            elemento2 = elemento1 + auxiliar;
            Console.WriteLine("{0}", elemento2);
        }

        Console.ReadLine();
    }
}