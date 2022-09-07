using System.Globalization;

namespace SalesTransactionDemo;

public class SalesTransaction
{
    public SalesTransaction(string name, double salesAmount, double rate)
    {
        Name = name;
        SalesAmount = salesAmount;
        Rate = rate;
        Commission = salesAmount * rate;
    }
    /// <summary>
    /// The : this(...) part is called constructor chaining. Effectively, it chains
    /// calls to different (overloaded) constructors.
    /// An alternative to overloading constructors could be defaulting/optionsl parameters.
    /// </summary>
    public SalesTransaction(string name, double salesAmount)
        : this(name, salesAmount, 0)
    { }
    public SalesTransaction(string name): this(name, 0, 0)
    { }

    /// <summary>
    /// Just using a getter and leaving out the setter means: this property is
    /// readonly. It can only be set during initialization (from inside a constructor).
    /// </summary>
    public string Name { get; }
    public double SalesAmount { get; }
    /// <summary>
    /// This requirement is not following good practices:
    /// Monetary values should use the Decimal type.
    /// See: https://msdn.microsoft.com/en-us/library/364x0z75(v=vs.140).aspx
    /// </summary>
    public double Commission { get; }
    /// <summary>
    /// We don't use accessors of the type getRate() in C#.
    /// Properties (getters/setters) are first-class citizens, hence we use them.
    /// Also, we use PascalCasing, not camelCasing.
    /// </summary>
    public double Rate { get; }

    public override string ToString()
    {
        // For the $"" notation, see: String Interpolation
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
        return $"{Name}\t\t\t{SalesAmount:C}\t\t\t{Commission:C}\t\t\t{Rate:P}";
    }
    public static SalesTransaction operator +(SalesTransaction st1, SalesTransaction st2)
    {
        var combinedNames = $"{st1.Name}+{st2.Name}";
        var totalSalesAmount = st1.SalesAmount + st2.SalesAmount;

        return new SalesTransaction(combinedNames, totalSalesAmount);
    }
}