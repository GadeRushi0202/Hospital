using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            Hospital hospital = new Hospital();
            do
            {
                Console.WriteLine("--------_________________---------");
                Console.WriteLine("1.Patient List");
                Console.WriteLine("2.Get Patient By Id");
                Console.WriteLine("3.Add Patient");
                Console.WriteLine("4.Update Patient");
                Console.WriteLine("5.Deletr Patient");
                Console.WriteLine("Select Your Option");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Patient> list = hospital.GetPatients();
                        Console.WriteLine("Id \t P_Name \t P_Bill \t Hospital_Name");
                        foreach (Patient p in list)
                        {
                            Console.WriteLine($"{p.Id} \t {p.P_Name} \t {p.P_Bill} \t        {p.Hospital_Name}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter The Patient Id");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        Patient p1 = hospital.GetPatientById(Id);
                        Console.WriteLine("Id \t P_Name \t P_Bill \t Hospital_Name");
                        Console.WriteLine($"{p1.Id} \t {p1.P_Name} \t {p1.P_Bill} \t        {p1.Hospital_Name}");
                        break; 
                    case 3:
                        Patient p2 = new Patient();
                        Console.WriteLine("Enter The Patient Id");
                        p2.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Patient Name");
                        p2.P_Name =Console.ReadLine();
                        Console.WriteLine("Enter The Patient Totla Bill");
                        p2.P_Bill= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Patient Hospital Name");
                        p2.Hospital_Name = Console.ReadLine();
                        hospital.AddPatient(p2);
                        Console.WriteLine("Patient Saved");
                        break;
                    case 4:
                        Patient p3 = new Patient();
                        Console.WriteLine("Enter The Patient Id");
                        p3.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Patient Name");
                        p3.P_Name = Console.ReadLine();
                        Console.WriteLine("Enter The Patient Total Bill");
                        p3.P_Bill = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Patient Hospital Name");
                        p3.Hospital_Name = Console.ReadLine();
                        hospital.UpadatePatient(p3);
                        Console.WriteLine("Patient Update");
                        break;
                    case 5:
                        Console.WriteLine("Enter The Patient Id");
                        int Id2 = Convert.ToInt32(Console.ReadLine());
                        hospital.DeletePatient(Id2);
                        Console.WriteLine($"{Id2} Patient Deleted" );
                        break;
                }
                Console.WriteLine("Press 1 for Continue");
                no = Convert.ToInt32(Console.ReadLine());
            } 
            while (no != 0);

        }
    }
}
