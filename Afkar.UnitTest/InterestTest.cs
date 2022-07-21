using System;
using Afkar.Models.Loans;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Afkar.UnitTest;

[TestClass]
public class InterestTest
{
    [TestMethod]
    public void AgeLimit_scenario()
    {
        //Arrange
        var loanModel = new LoanRequestModel();
        var rnd = new Random();

        //Act
        // loanModel.Age = rnd.Next(18, 60);
        // loanModel.LoanAmount = rnd.Next(10000, 1500000);
        // loanModel.LoanDuration = rnd.Next(6, 60);
        // loanModel.MonthlyIncome = rnd.Next(1000, 100000);
        
        loanModel.Age = 58;
        loanModel.LoanAmount = 100000;
        loanModel.LoanDuration = 36;
        loanModel.MonthlyIncome = 2000;

        //Assert

        Assert.AreEqual();
    }
}