using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalvarySouthside.Reporting.Budget;
using System.Collections.Generic;

namespace CalvarySouthside.Test.Reporting.Budget
{
    [TestClass]
    public class BudgetGeneratorTests
    {
        [TestMethod]
        public void Generate()
        {
            BudgetGenerator generator = new BudgetGenerator();
            AnnualReport annualReport = generator.Generate("https://dl.dropboxusercontent.com/u/128970065/WebResources/BudgetReport/2014.csv");

            Assert.AreEqual(3, annualReport.MonthlyLineItems.Count);
        }
    }
}
