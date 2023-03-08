class Program
{
    static void Main(string[] args)
    {
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double Outros = 19849.53;

        Console.WriteLine("FATURAMENTOS INDIVIDUAIS:");
        Console.WriteLine("O faturamento de SP é de R$: " + SP);
        Console.WriteLine("O faturamento de RJ é de R$: " + RJ);
        Console.WriteLine("O faturamento de MG é de R$: " + MG);
        Console.WriteLine("O faturamento de ES é de R$: " + ES);
        Console.WriteLine("O faturamento de Outros é de R$: " + Outros);
        


        double soma = SP + RJ + MG + ES + Outros;

        Console.WriteLine("----------------------------------A soma dos faturamentos é: -------------------------------------");
        Console.WriteLine("O valor total do faturamento é de R$ " + soma + ".");

        double porSP = (100.0 / soma) * SP;
        double porRJ = (100.0 / soma) * RJ;
        double porMG = (100.0 / soma) * MG;
        double porES = (100.0 / soma) * ES;
        double porOutros = (100.0 / soma) * Outros;

        Console.WriteLine("----------------------------------Os faturamentos em porcentagem são: -------------------------------------");
        Console.WriteLine("A porcentagem de SP é de: "+ porSP + " %");
        Console.WriteLine("A porcentagem de SP é de: " + porRJ + " %");
        Console.WriteLine("A porcentagem de SP é de: " + porMG + " %");
        Console.WriteLine("A porcentagem de SP é de: " + porES + " %");
        Console.WriteLine("A porcentagem de SP é de: " + porOutros + " %");
        






    }
}
