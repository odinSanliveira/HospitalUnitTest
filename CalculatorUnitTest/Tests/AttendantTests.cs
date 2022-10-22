/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Models;
using System.Collections.Generic;
using Xunit;

namespace HospitalUnitTest.Tests
{
    public class AttendantTests
    {
        List<Attendant> attendants;
        Attendant attendant1;
        Attendant attendant2;

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
            var actual = Assert.Throws<WrongOrUnexistentAttendantIdException>(() => attendant.GetId());          

            //assert
            Assert.Equal("Usuário Jojo não existe ou não tem ID", actual.Message);
        }

        [Fact]
        public void AttendantExistInTheList()
        {
            //arrange
            attendants = new List<Attendant>();
            attendant1 = new Attendant("Izabel", "123.456.789-00", 21, "445477");

            attendants.Add(attendant1);
            //act
            bool result = Attendant.VerifyIfAttendantExist(attendants, attendant1);

            //assert
            Assert.True(result);
        }

        [Fact]
        public void AttendantDoesNotExistInTheList()
        {
            //arrange
            attendants = new List<Attendant>();
            attendant1 = new Attendant("Izabel", "123.456.789-00", 21, "445477");
            attendant2 = new Attendant("Gabriel", "123.945.225-00", 21, "258964");

            attendants.Add(attendant1);
            //act
            var actual = Assert.Throws<AttendantDoesNotExistException>(() => Attendant.VerifyIfAttendantExist(attendants, attendant2));
            //assert
            Assert.Equal("Não existe atendente com a matrícula 258964", actual.Message);
        }
    }
}
