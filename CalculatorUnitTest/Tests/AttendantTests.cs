using CalculatorUnitTest.Exceptions;
using CalculatorUnitTest.Models;
using Xunit;

namespace CalculatorUnitTest
{
    public class AttendantTests
    {
        [Fact]
        public void CreateAttendantUser()
        {
            Attendant attendant = new Attendant("Gabriel", "106.554.857-22", 22, "ADSPL202021312");
            string expectedName = "Gabriel";
            string expectedCPF = "106.554.857-22";
            int expectedYearOld = 22;
            Assert.Equal(expectedName, attendant.GetName());
            Assert.Equal(expectedCPF, attendant.GetCpf());
            Assert.Equal(expectedYearOld, attendant.GetBirthday());
        }

        [Fact]
        public void ReturnWrongOrUnexistentAttendantIdException()
        {
            //arrange
            Attendant attendant = new Attendant();
            attendant.SetName("Jojo");
            //attendant.Id = "";
            //act
            var ex = Assert.Throws<WrongOrUnexistentAttendantIdException>(() => attendant.GetId());
            //WrongOrUnexistentAttendantIdException exception = Assert.Throws<WrongOrUnexistentAttendantIdException>(() => attendant.GetId());

            //assert
            Assert.Equal("Usuário Jojo não existe ou não tem ID", ex.Message);
        }
    }
}
