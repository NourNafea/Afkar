namespace Afkar.Entities;

public class LoansRequests
{
    public Guid Id { get; set; }
    public float MonthlyIncome { get; set; }

    public int Age { get; set; }
    public int LoanAmount { get; set; }
    public int LoanDuration { get; set; }
}