/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Models;
using Xunit;

namespace HospitalUnitTest.Tests
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
            attendant.Id = "";

            //act
            var ex = Assert.Throws<WrongOrUnexistentAttendantIdException>(() => attendant.GetId());          

            //assert
            Assert.Equal("Usuário Jojo não existe ou não tem ID", ex.Message);
        }

        [Fact]
        public void 
    }
}
