using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalvarySouthside.Reporting.Budget
{
    public class AnnualReport
    {
        public int Year { get; set; }
        public decimal TotalAnnualIncome { get; set; }
        public decimal TotalAnnualExpenses { get; set; }

        public List<MonthlyLineItem> MonthlyLineItems { get; set; }

        public AnnualReport(List<MonthlyLineItem> monthlyLineItems)
        {
            Year = monthlyLineItems.Where(x => x.Items.Count > 0).First().Items.First().Date.Year;

            MonthlyLineItems = monthlyLineItems;

            foreach(var month in monthlyLineItems)
            {
                TotalAnnualIncome += month.TotalMonthIncome;

                foreach(var lineItem in month.Items)
                {
                    TotalAnnualExpenses += lineItem.Expenses ?? 0;
                }
            }
        }
    }
}
