using Review4;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Review - 4 \n\n");


        /*DataValidation dataValidation = new DataValidation();
        dataValidation.Validate();

        PhoneNumberExtract.ExtractNumber();
        DateExtract.ExtractDate();*/

        //ReplaceWhiteSpaces.ReplaceSpace();

        //FileSizeCheck.FileCheck();

        //PalindromeUsingLambda.IsPalindromString();

        /*FileHandling fileReadWrite = new FileHandling();
        fileReadWrite.ReadFile();
        fileReadWrite.WriteData();*/

        JSONDataReader jSON = new JSONDataReader();
        jSON.ParseAndReadData();
    }
}