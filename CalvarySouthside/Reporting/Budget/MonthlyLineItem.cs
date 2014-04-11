using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CalvarySouthside.Reporting.Budget
{
    public class MonthlyLineItem
    {
        public decimal TotalMonthIncome { get; private set; }
        public decimal TotalMonthExpenses { get; private set; }
        public int Month { get; private set; }
        public string MonthName { get; private set; }

        public decimal LatestCheckingAccountBalance { get; private set; }
        public decimal LatestCreditCardBalance { get; private set; }
        public decimal LatestSavingsAccountBalance { get; private set; }

        public List<LineItem> Items { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items">A List of Items already pre-filtered by month</param>
        public MonthlyLineItem(int month, List<LineItem> items)
        {
            Items = items;

            Month = month;
            MonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);

            foreach (var item in items)
            {
                TotalMonthIncome += item.Income ?? 0;
                TotalMonthExpenses += item.Expenses ?? 0;
            }


            var mostRecentCheckingAccountBalance = items.Where(x => x.Checking != null).OrderBy(x => x.Date);
            if (mostRecentCheckingAccountBalance.Count() > 0)
                LatestCheckingAccountBalance = (decimal)(mostRecentCheckingAccountBalance.Last().Checking);

            var mostRecentCreditCardBalance = items.Where(x => x.CC != null).OrderBy(x => x.Date);
            if (mostRecentCreditCardBalance.Count() > 0)
                LatestCreditCardBalance = (decimal)(mostRecentCreditCardBalance.Last().CC);

            var mostRecentSavingsAccountBalance = items.Where(x => x.Savings != null).OrderBy(x => x.Date);
            if (mostRecentSavingsAccountBalance.Count() > 0)
                LatestSavingsAccountBalance = (decimal)(mostRecentSavingsAccountBalance.Last().Savings);
        }
    }
}