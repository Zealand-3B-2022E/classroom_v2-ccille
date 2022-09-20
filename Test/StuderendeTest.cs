using ClassRoomNet60;

namespace Test
{
    [TestClass]
    public class StuderendeTest
    {
        //Kan g�re dette, s� beh�ver man ikke og lave en nye studerende liste hver gang.
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
        public void Studerende�rstidVinter(int �rstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "vinter";

            //Act
            string � = st.�rstid(�rstid);

            //Assert
            Assert.AreEqual(expected, �);
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        public void Studerende�rstidFor�r(int �rstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "for�r";

            //Act
            string � = st.�rstid(�rstid);

            //Assert
            Assert.AreEqual(expected, �);
        }

        [DataTestMethod]
        [DataRow(9)]
        [DataRow(10)]
        [DataRow(11)]
        public void Studerende�rstidEfter�r(int �rstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "efter�r";

            //Act
            string � = st.�rstid(�rstid);

            //Assert
            Assert.AreEqual(expected, �);
        }

        [DataTestMethod]
        [DataRow(6)]
        [DataRow(7)]
        [DataRow(8)]
        public void Studerende�rstidSommer(int �rstid)
        {
            //Arrange
            Studerende st = new Studerende();
            string expected = "sommer";

            //Act
            string � = st.�rstid(�rstid);

            //Assert
            Assert.AreEqual(expected, �);
        }
    }
}