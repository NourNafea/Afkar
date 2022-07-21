using Afkar.Entities;
using Afkar.Helpers;
using Afkar.Models.Loans;
using Microsoft.AspNetCore.Mvc;
namespace Afkar.Controllers;
[ApiController]
[Route("[controller]")]
public class LoanController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    public LoanController(ApplicationDbContext dbContext )
    {
        _dbContext = dbContext;
    }
    
    [HttpPost]
    [Route("Calculate")]
    public async Task<IActionResult> Calculate(LoanRequestModel model)
    {
        var loanDurationInYears = (model.LoanDuration / 12);
        var ageLimit =  model.Age + loanDurationInYears;
        var maximumInstallmentLimit = 0.4 * model.MonthlyIncome;
        
        var monthlyInstallment = (1.14 * (model.LoanAmount))/model.LoanDuration ;
        if (ageLimit > 60)
            return StatusCode(StatusCodes.Status406NotAcceptable, 
                new {error ="Your age cannot exceed 60 at the end of the loan term"});
        if (model.LoanAmount > 1500000)
            return StatusCode(StatusCodes.Status406NotAcceptable, 
                new {error ="Loan Amount cannot exceed 1,500,000"});
        if (model.LoanDuration is < 6 or > 60)
            return StatusCode(StatusCodes.Status406NotAcceptable,
                new {error = "The loan duration must be between 6 and 60 months"});
        if (monthlyInstallment > maximumInstallmentLimit )
            return StatusCode(StatusCodes.Status406NotAcceptable,
            new {error = "Your Monthly Installment should not exceed "+ Math.Round(maximumInstallmentLimit)+" Try to lower your loan amount or increase the loan duration"});
            
        LoansRequests Loan = new()
        {
            MonthlyIncome = model.MonthlyIncome,
            LoanAmount = model.LoanAmount,
            LoanDuration = model.LoanDuration,
            Age = model.Age
        };
        _dbContext.LoansRequests.Add(Loan);
        _dbContext.SaveChanges();
         return StatusCode(StatusCodes.Status200OK,
            new {Response = "Your are eligible to our program and you will pay "+Math.Round(monthlyInstallment)+" each month"}); 
    }
}