using System;

namespace CalvarySouthside.Reporting.Budget
{
    public class LineItem
    {
        public DateTime Date { get; set; }

        public decimal? Income { get; set; }
        public string sIncome { get { return (Income != null) ? string.Format("{0:C}", Income) : string.Empty; } }

        public decimal? Expenses { get; set; }
        public string sExpenses { get { return (Expenses != null) ? string.Format("{0:C}", Expenses) : string.Empty; } }

        public decimal? CC { get; set; }
        public string sCC { get { return (CC!= null) ? string.Format("{0:C}", CC) : string.Empty; } }

        public decimal? Checking { get; set; }
        public string sChecking { get { return (Checking != null) ? string.Format("{0:C}", Checking) : string.Empty; } }

        public decimal? Savings { get; set; }
        public string sSavings { get { return (Savings != null) ? string.Format("{0:C}", Savings) : string.Empty; } }

        #region ctor

        public LineItem()
        { }

        public LineItem(string line)
        {
            var v = line.Split(',');
            SetValues(v[0], v[1], v[2], v[3], v[4], v[5]);
        }

        public LineItem(string date, string income, string expenses, string cc, string checking, string savings)
        {
            SetValues(date, income, expenses, cc, checking, savings);
        }

        #endregion

        #region private members

        private void SetValues(string date, string income, string expenses, string cc, string checking, string savings)
        {
            DateTime dt = DateTime.MinValue;
            if (DateTime.TryParse(date, out dt))
                Date = dt;

            Income = ParseDecimal(income);
            Expenses = ParseDecimal(expenses);
            CC = ParseDecimal(cc);
            Checking = ParseDecimal(checking);
            Savings = ParseDecimal(savings);
        }


        private decimal? ParseDecimal(string sNumber)
        {
            decimal dValue;
            if (decimal.TryParse(sNumber, out dValue))
                return dValue;

            return null;
        }

        #endregion

    }
}
