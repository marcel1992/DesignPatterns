namespace TemplateMethodPattern
{
    /// <summary>
    /// Basic skeleton of actions/steps
    /// </summary>
    public abstract class BasicEngineering
    {
        //the following method(step) will not vary
        private void Math()
        {
            System.Console.WriteLine("1.Mathematics");
        }
        //the following method(step) will not vary
        private void SoftSkills()
        {
            System.Console.WriteLine("2.SoftSkills");
        }

        //the following method(step) will vary. It will be overridden by derived classes
        public abstract void SpecialPaper();

        //the Template Method
        public void DisplayCourseStructure()
        {
            Math();
            SoftSkills();
            SpecialPaper();
            if (IsAdditionalPaperNeeded())
            {
                IncludeAdditionalPaper();
            }
        }

        private void IncludeAdditionalPaper()
        {
            System.Console.WriteLine("4.Compiler Design");
        }

        //a hook method
        //by default, an additional subject is needed
        public virtual bool IsAdditionalPaperNeeded() => true;
    }
}
