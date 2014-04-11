using CalvarySouthside;
using CalvarySouthside.Reporting.Budget;
using System.Web.Mvc;

namespace Southside2.Areas.Reports.Controllers
{
    public class FinancesController : Controller
    {

        public ActionResult Index()
        {
            BudgetGenerator generator = new BudgetGenerator();
            AnnualReport annualReport = generator.Generate(ConfigurationHelper.FinancialBudgetUrl);

            return View(annualReport);
        }

    }
}
