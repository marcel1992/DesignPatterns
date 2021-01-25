namespace VisitorPattern.VisitorWithCompositePattern
{
    public interface IVisitor
    {
        //to visit leaf nodes
        void VisitEmployees(Employee employee);
        //to visit composite nodes
        void VisitEmployees(CompositeEmployee employee);
    }
}
