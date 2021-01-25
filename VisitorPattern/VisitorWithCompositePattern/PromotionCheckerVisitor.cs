using System;

namespace VisitorPattern.VisitorWithCompositePattern
{
    public class PromotionCheckerVisitor : IVisitor
    {
        string eligibleForPromotion = string.Empty;
        public void VisitEmployees(Employee employee)
        {
            //we'll promote them if experience is > 12 years

            eligibleForPromotion = employee.Experience > 12 ? "Yes" : "No";
            Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion? :{eligibleForPromotion}");
        }

        public void VisitEmployees(CompositeEmployee employee)
        {
            //we'll promote the if experience is > 15 years

            eligibleForPromotion = employee.Experience > 15 ? "Yes" : "No";
            Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion? :{eligibleForPromotion}");
        }
    }
}
