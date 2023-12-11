namespace CoreMain
{
    public class Main
    {
        public string DoIt()
        {
            var dependency = new CoreDependency.Dependency();

            return dependency.DoIt();
        }
    }
}
