using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfApp.DataContext
{
    using Models;

    public static class DataStore
    {
        public static List<Patient> Patients => new()
        {
            new Patient { ID = 1, Name = "John Doe" },
            new Patient { ID = 2, Name = "Jane Smith" }
        };

        public static List<Doctor> Doctors => new()
        {
            new Doctor { ID = 1, Name = "Dr. Adams" },
            new Doctor { ID = 2, Name = "Dr. Baker" }
        };

        public static List<Appointment> Appointments => new()
        {
            new Appointment { PatientID = 1, DoctorID = 1, AppointmentDate = DateTime.Now.AddDays(1) },
            new Appointment { PatientID = 2, DoctorID = 2, AppointmentDate = DateTime.Now.AddDays(2) }
        };

        public static IEnumerable<object> GetAppointmentDetails()
        {
            return from appointment in Appointments
                   join patient in Patients on appointment.PatientID equals patient.ID
                   join doctor in Doctors on appointment.DoctorID equals doctor.ID
                   select new
                   {
                       PatientName = patient.Name,
                       DoctorName = doctor.Name,
                       appointment.AppointmentDate
                   };
        }
    }
}
