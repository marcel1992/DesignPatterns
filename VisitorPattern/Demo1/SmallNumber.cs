namespace VisitorPattern
{
    public class SmallNumber : Number
    {
        public SmallNumber(string type, int number) : base(type, number)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitNumbers(this);
        }
    }
}
