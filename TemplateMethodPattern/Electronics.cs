namespace TemplateMethodPattern
{
    //concrete derived class
    public class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            System.Console.WriteLine("3.Digital Logic and Circuit Theory");
        }

        //using the hook method
        //additional paper is not needed for Electronics
        public override bool IsAdditionalPaperNeeded() => false;
    }
}
