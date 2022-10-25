/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using FluentAssertions;
using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Models;
using System;
using Xunit;

namespace HospitalUnitTest.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void DoctorShouldHaveCpfAndRegistry()
        {
            Doctor DoctorOne = new Doctor("Luan", "201.235.445-98", 55, "36544258");          

            DoctorOne.GetCpf().Should().NotBeNull();
            DoctorOne.Id.Should().NotBeNull();
        }

        [Fact]
        public void DoctorWithNullRegistryThrowsException()
        {
            Doctor DoctorTwo = new Doctor("Maria", "", 39, null);

            Action result = () => DoctorTwo.GetRegistry();

            result.Should().Throw<DoctorNullRegistryException>().WithMessage("Médico não pode ter matrícula nula");
        }

    }
}
