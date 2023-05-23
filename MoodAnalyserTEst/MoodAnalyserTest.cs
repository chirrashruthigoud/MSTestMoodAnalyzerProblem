using MoodAnalyser;
namespace MoodAnalyserTEst
{
    public class MoodAnalyserTest
    {
        MoodAnalyserClass analyse = new MoodAnalyserClass();
        [Test]
        public void Message_Should_return_Sad()
        {
            string result = analyse.AnalyzeMood("I am in sad Mood");
            Assert.AreEqual(result,"Sad");
        }

        //[Test]
        //public void Message_Should_return_Happy()
        //{
        //    string result = analyse.AnalyzeMood("I am in Any Mood");
        //    Assert.AreEqual(result, "Happy");
        //}
        //[Test]
        //public void Return_Mood_Sad_Constructor()
        //{
        //    MoodAnalyserClass analyse = new MoodAnalyserClass("I am in sad Mood");
        //    string result = analyse.AnalyzeMood();
        //    Assert.AreEqual(result, "Sad");
        //}

        //[Test]
        //public void Return_Mood_Happy_Constructor()
        //{
        //    string result = analyse.AnalyzeMood("I am in Any Mood");
        //    Assert.AreEqual(result, "Happy");
        //}
    }
}