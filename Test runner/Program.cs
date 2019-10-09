namespace Test_runner
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new Tests.Tests();
            tests.Generate_GiveemptylistOfLessons_ThrowExeption();
            tests.Generate_GivelistOfLessons_GeneratePlan();
        }
    }
}
