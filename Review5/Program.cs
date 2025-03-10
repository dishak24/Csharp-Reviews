using Review5;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Review - 5 !\n\n");

        PrimeChecking.CheckPrimeNumber();

        NameSorting.SortNames();

        AgeValidator.ValidateAge();

        StackOperations.PerformAllStackOperation();

        TPLCode.PerformTPL(); //TPL
        
    }
}