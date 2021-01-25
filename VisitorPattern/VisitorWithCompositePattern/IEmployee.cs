namespace VisitorPattern.VisitorWithCompositePattern
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Dept { get; set; }
        string Designation { get; set; }

        //to set years of Experience
        double Experience { get; set; }
        void Accept(IVisitor visitor);
        void DisplayDetails();
    }
}
