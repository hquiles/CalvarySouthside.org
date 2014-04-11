using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CalvarySouthside.Reporting.Budget
{
    public class BudgetGenerator
    {
        private string GetCsvFromUrl(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }

        private string GetCsvFromFile(string file)
        {
            var sb = new StringBuilder();
            var reader = new StreamReader(File.OpenRead(file));

            while (!reader.EndOfStream)
                sb.AppendFormat("{0}{1}", reader.ReadLine(), Environment.NewLine);

            return sb.ToString();
        }

        public AnnualReport Generate(string input)
        {
            List<LineItem> lineItems = new List<LineItem>();

            string csv;
            if (input.ToLower().Contains("http"))
                csv = GetCsvFromUrl(input);
            else
                csv = GetCsvFromFile(input);

            // generate list of items
            using (StringReader reader = new StringReader(csv))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    var lineItem = new LineItem(line);
                    if (lineItem.Date > DateTime.MinValue)
                        lineItems.Add(lineItem);
                }
            }

            var monthlyLineItems = GenerateMonthlyLineItems(lineItems);

            return new AnnualReport(monthlyLineItems);
        }

        private List<MonthlyLineItem> GenerateMonthlyLineItems(List<LineItem> list)
        {
            var output = new List<MonthlyLineItem>();

            for (int i = 1; i <= 12; i++)
            {
                var monthlyItems = list.Where(x => x.Date.Month == i)
                                       .OrderBy(x => x.Date)
                                       .Reverse()
                                       .ToList();

                //if (monthlyItems.Count > 0)
                    output.Add(new MonthlyLineItem(i, monthlyItems));
            }

            return output.OrderBy(x => x.Month).Reverse().ToList();
        }

    }
}
