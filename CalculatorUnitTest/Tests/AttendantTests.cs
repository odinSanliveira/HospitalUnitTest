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
            var ex = Assert.Throws<WrongOrUnexistentAttendantIdException>(() => attendant.GetId());          

            //assert
            Assert.Equal("Usuário Jojo não existe ou não tem ID", ex.Message);
        }

        [Fact]
        public void AttendantExistInTheList()
        {
            //arrange
            attendants = new List<Attendant>();
            attendant1 = new Attendant("Izabel", "123.456.789-00", 21, "445477");

            attendants.Add(attendant1);
            //act
            bool result = Attendant.RegisterUserToConsultation(attendants, attendant1);

            //assert
            Assert.True(result);
        }
    }
}
