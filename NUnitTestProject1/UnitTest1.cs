using NUnit.Framework;
using MoodAnalyserDay12;


namespace NUnitTestProject
{

    public class Tests
    {

        MoodAnalyserOne moodAnalyserOne;
        [SetUp]
        public void Setup()
        {
            moodAnalyserOne = new MoodAnalyserOne();

        }

        /// <summary>
        /// TC-4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserOne.CreateMoodAnalyse("MoodAnalyserDay12.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-4.2 Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string message = null;
            string expected = "Class not found";
            try
            {
                obj = MoodAnalyserOne.CreateMoodAnalyse("MoodAnalyserDay12.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string message = null;
            string expected = "Method not found";
            try
            {
                obj = MoodAnalyserOne.CreateMoodAnalyse("MoodAnalyserDay12.MoodAnalyser", "AnalyserMood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}