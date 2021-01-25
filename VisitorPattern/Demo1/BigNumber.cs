namespace VisitorPattern
{
    public class BigNumber : Number
    {
        public BigNumber(string type, int number) : base(type, number)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitNumbers(this);
        }
    }
}
