namespace VisitorPattern
{
    public abstract class Number
    {
        private int _NumberValue;
        private string _Type;
        public Number(string type, int number)
        {
            _NumberValue = number;
            _Type = type;
        }
        public int NumberValue
        {
            get => _NumberValue;
        }
        public string TypeInfo
        {
            get => _Type;
        }

        public abstract void Accept(IVisitor visitor);
    }
}
