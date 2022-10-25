using System;

namespace HospitalUnitTest.Exceptions
{
    public class DoctorNullRegistryException : Exception
    {
        public DoctorNullRegistryException(string message) : base(message)
        {
        }
    }
}
