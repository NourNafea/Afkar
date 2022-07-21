using System.ComponentModel.DataAnnotations;

namespace Afkar.Models.Loans;

public class LoanRequestModel
{
    [Required]
    public float MonthlyIncome { get; set; }
    
    [Required]
    public int LoanAmount { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [Required]
    public int LoanDuration { get; set; }
}