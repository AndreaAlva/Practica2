using System;
using System.Collections.Generic;
namespace PatientLogic
{
    public class PatientManager
    {
        private List<Patient> patient;

        public PatientManager()
        {
            patient = new List<Patient>();
        }

        public List<Patient> getPatients()
        {
            return patient;
        }
        public Patient createPatient(string name, string lastname,int CI, string typeBlood)
        {
            Patient paciente = new Patient() { Name = name, LastName = lastname, CI = CI, TypeBlood = typeBlood };
            patient.Add(paciente);
            return paciente;
        }
        public void updatePatient(string name, string lastname,int ci)
        {
            patient.ForEach(p =>
            {
                if (p.CI == ci)
                    p.Name = name; p.LastName = lastname;
            });
        }
        public void removePatient(string name, string lastname, int ci)
        {
            patient.ForEach(p =>
            {
                if (p.CI == ci)
                    patient.Remove(p);
            });
        }
    }
    
    
}
