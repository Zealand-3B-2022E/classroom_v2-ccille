using ClassRoomNet60;

namespace Test
{
    [TestClass]
    public class StuderendeTest
    {
        //Kan gøre dette, så behøver man ikke og lave en nye studerende liste hver gang.
        private Studerende stu = null;

        [TestInitialize]
        public void BeforeEachTest()
        {
            stu = new Studerende();
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(12)]
        public void StuderendeÅrstidVinter(int årstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "vinter";

            //Act
            string å = st.Årstid(årstid);

            //Assert
            Assert.AreEqual(expected, å);
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void StuderendeÅrstidForår(int årstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "forår";

            //Act
            string å = st.Årstid(årstid);

            //Assert
            Assert.AreEqual(expected, å);
        }

        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void StuderendeÅrstidEfterår(int årstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "efterår";

            //Act
            string å = st.Årstid(årstid);

            //Assert
            Assert.AreEqual(expected, å);
        }

        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void StuderendeÅrstidSommer(int årstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "sommer";

            //Act
            string å = st.Årstid(årstid);

            //Assert
            Assert.AreEqual(expected, å);
        }
    }
}