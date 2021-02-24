using NUnit.Framework;
using MoodAnalyserDay11;


namespace NUnitTestProject
{

    public class Tests
    {

        MoodAnalyserFactory moodAnalyserFactory;
        [SetUp]
        public void Setup()
        {
            moodAnalyserFactory = new MoodAnalyserFactory();

        }

        /// <summary>
        /// TC-4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new AnalyseMood(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-4.2 Given Improper MoodAnalyse Class Name Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string message = null;
            string expected = "Class not found";
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAppWithCore.Mood", "Mood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-4.3 Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_ShouldThrowMoodAnalyserException()
        {
            object obj = null;
            string message = null;
            string expected = "Method not found";
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserAppWithCore.MoodAnalyser", "AnalyserMood");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        /// <summary>
        /// TC-5.1  Given MoodAnalyse Class Name Should Return MoodAnalyser Object
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_ShouldReturnMoodAnalyserObject_UsingParametrizedConstructor()
        {
            object expected = new AnalyseMood("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "Happy");
            expected.Equals(obj);
        }

        /// <summary>
        /// TC-5.2  Given MoodAnalyse Class Name When Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.Mood", "MoodAnalyser", "Happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }

        /// <summary>
        /// TC-5.3  Given MoodAnalyse Class Name When Constructor is Improper Should Throw Exception
        /// </summary>
        [Test]
        public void MoodAnalyserClassName_WhenConstructorIsImproper_UsingParametrizedConstructor_ShouldThrowExcpetion()
        {
            string expected = "Method not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "Mood", "Happy");
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}