using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Patient
    {
        public int Id { get; set; }
        public string P_Name { get; set; }
        public int P_Bill { get; set; }
        public string Hospital_Name { get; set; }
    }
    public class Hospital
    {
        private List<Patient> patientlist;

        public Hospital()
        {
            patientlist = new List<Patient>()
            {
                new Patient() { Id=1, P_Name="RushiKesh", P_Bill=65000,Hospital_Name="Impulse Hospital"},
                new Patient() { Id=2, P_Name="Vishal", P_Bill=75000,Hospital_Name="Impulse Hospital"},
                new Patient() { Id=3, P_Name="Rajesh", P_Bill=85000,Hospital_Name="Impulse Hospital"}

            };
        }
        public List<Patient> GetPatients()
        {
            return patientlist;
        }

        public Patient GetPatientById(int Id)
        {
            Patient patient   = new Patient();
            foreach(Patient pat in patientlist)
            {
                if (pat.Id == Id)
                {
                    patient = pat;
                }
            }
            return patient;
        }
        public void AddPatient(Patient p)
        {
            patientlist.Add(p);
        }
        public void UpadatePatient(Patient p)
        {
            foreach(Patient pat in patientlist)
            {
                if(pat.Id == p.Id)
                {
                    pat.P_Name = p.P_Name;
                    pat.P_Bill = p.P_Bill;
                    pat.Hospital_Name = p.Hospital_Name;
                    break;
                }
            }
        }
        public void DeletePatient(int Id)
        {
            foreach(Patient p in patientlist)
            {
                if (p.Id == Id)
                {
                    patientlist.Remove(p);
                    break;
                }
            }
        }
    }
}
