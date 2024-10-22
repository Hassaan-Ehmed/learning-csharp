using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementCLI
{
     class Person {

        private string name; // field 
        private int age;
        private string gender;

        public string Name { // property
            get { return name; } // getter method
            set { name = value ; } // setter method
        }

        //getter / setters for Age
        public int Age { 
            get { return age; }
            set { age = value; }
        }

        //getter / setters for Gender
        public string Gender 
        {
            get { return gender; }
            set { gender = value; } 
        }

    }

    class Appointment
    {
        private int appointmentID;
        private string doctor;
        private string patient;
        private DateTime date;
        private TimeSpan time;


        public void ScheduleAppointment() { 
        

        }
    }

    class Doctor : Person {

        private string specialization;
        private int docterID;
    
    }

}
