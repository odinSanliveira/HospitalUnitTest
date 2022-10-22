﻿/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using CalculatorUnitTest.Models;

namespace CalculatorUnitTest.Interfaces
{
    public interface IFicha
    {
        void Save(Patient patient, Models.Attendant attendant);
    }
}
