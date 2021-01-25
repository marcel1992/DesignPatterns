namespace VisitorPattern
{
    public interface IVisitor
    {
        void VisitNumbers(SmallNumber number);
        void VisitNumbers(BigNumber number);
    }
}