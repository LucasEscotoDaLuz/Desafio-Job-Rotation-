class Program
{

    public static string Reverse(string Input)
    {
        char[] stringArray = Input.ToCharArray();
        string invertString = String.Empty;
        
        for (int i = stringArray.Length - 1; i > -1; i--)
        {
            invertString += stringArray[i];
        }
        return invertString;
    }


    static void Main(string[] args)
    {
        //Insira a string desejada
        Console.WriteLine(Reverse("MeContratePorFavor"));
        Console.WriteLine(Reverse("AprendoRapido"));
        Console.WriteLine(Reverse("SouDedicado"));
        Console.WriteLine(Reverse("VaiDarCerto"));
    }
}