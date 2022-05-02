using System;
using TypeBloodLogic;
namespace PatientLogic
{
    public class Patient
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int CI { get; set; }

        public BloodType TypeBlood { get; set; }
    }
}
