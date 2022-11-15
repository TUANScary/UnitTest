using StudentServiceLib;
using static System.Formats.Asn1.AsnWriter;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreLowerThan10()
        {
            Student st = new Student();

            int _score = 10;

            Assert.AreNotEqual(_score, st.Score);
        }

        [TestMethod]
        public void getLetterScore_1()
        {
            Student st1 = new Student();

            double Score = st1.Score;
            Assert.AreEqual(Score,st1.getLetterScore());
            
        }

        
    }

   
}