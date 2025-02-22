using Review3;

internal class Program
{
    private static void Main(string[] args)
    { 
        Console.WriteLine("Review - 3 \n\n");

        UserDataValidation userDataValidation = new UserDataValidation();
        userDataValidation.Validate();
        userDataValidation.FindDuplicate();

        DivideException divideException = new DivideException();
        divideException.NumberDivision();

        AgeValidator.ValidateAge();

        WithdrawTransaction withdrawTransaction = new WithdrawTransaction();
        withdrawTransaction.Transaction();

        ECommerceApplication eCommerce = new ECommerceApplication();
        eCommerce.CheckStock();

        EvenOddUsingLambda evenOdd = new EvenOddUsingLambda();
        evenOdd.EvenOddChecking();

        StringComparisionLambda stringComparision = new StringComparisionLambda();
        stringComparision.LengthCompare();

        NumberTransformation numberTransformation = new NumberTransformation();
        numberTransformation.MultiplyListElements();
        numberTransformation.RemoveElementLessThan10();

        MaxNumberLambda maxNumberLambda = new MaxNumberLambda();
        maxNumberLambda.FindMaxNumber();
    }
}