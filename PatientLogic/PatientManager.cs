using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using TypeBloodLogic;

namespace PatientLogic
{
    public class PatientManager
    {
        BloodTypeService bloodservice;
        IConfiguration _configuration;
        private List<Patient> patient;

        public PatientManager(IConfiguration configuration, BloodTypeService service)
        {
            _configuration = configuration;
            bloodservice = service;
            patient = new List<Patient>();
        }

        public List<Patient> getPatients()
        {
            return patient;
        }
        public Patient createPatient(string name, string lastname,int CI)
        {
            BloodType type = bloodservice.GetBlood().Result;
            Patient paciente = new Patient() { Name = name, LastName = lastname, CI = CI, TypeBlood = type };
            patient.Add(paciente);
            return paciente;
        }
        public Patient updatePatient(string name, string lastname,int ci)
        {
            Patient pa = null;
            patient.ForEach(p =>
            {
                if (p.CI == ci)
                    p.Name = name; p.LastName = lastname;pa = p;
            });
            return pa;
        }
        public Patient removePatient(int ci)
        {
            Patient pa = null;
            patient.ForEach(p =>
            {
                if (p.CI == ci)
                    pa = p; patient.Remove(p); 
            });
            return pa;
        }
    }
    
    
}
