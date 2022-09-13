using static System.Console;

class DemoLoan
{
    static void Main()
    {
        Loan aLoan = new Loan();
        CarLoan aCarLoan = new CarLoan();
        aLoan.LoanNumber = 2239;
        aLoan.LastName = "Mitchell";
        aLoan.LoanAmount = 1_000.00;
        aCarLoan.LoanNumber = 3358;
        aCarLoan.LastName = "Jansen";
        aCarLoan.LoanAmount = 20_000.00;
        aCarLoan.Make = "Ford";
        aCarLoan.Year = 2007;
        WriteLine($"Loan #{aLoan.LoanNumber} for {aLoan.LastName} is for {aLoan.LoanAmount.ToString("C2")}");
        WriteLine($"Loan #{aCarLoan.LoanNumber} for {aCarLoan.LastName} is for {aCarLoan.LoanAmount.ToString("C2")}");
        WriteLine($" Loan #{aCarLoan.LoanNumber} is for a {aCarLoan.Year} {aCarLoan.Make}");
    }
}


class Loan
{
    public int LoanNumber { get; set; }
    public string LastName { get; set; }
    public double LoanAmount { get; set; }
}

class CarLoan : Loan
{
    public int Year { get; set; }
    public string Make { get; set; }
}
