/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using HospitalUnitTest.Enums;
using HospitalUnitTest.Models;

namespace HospitalUnitTest.Interfaces
{
    public interface IFicha
    {
        void SaveForm(Patient patient, Illnesses illnesses);
    }
}
