using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moodanalyzer;

namespace MoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood()
        {
            //Arrange
            MoodAnalyser moodAnalyzer = new MoodAnalyser();
            string meassage = "I am in Sad Mood";
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);

        }
    }
}