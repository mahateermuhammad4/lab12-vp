using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var patients = new[]
        {
            new { ID = 1, Name = "John Doe" },
            new { ID = 2, Name = "Jane Smith" },
        };

        var doctors = new[]
        {
            new { ID = 1, Name = "Dr. Adams" },
            new { ID = 2, Name = "Dr. Baker" },
        };

        var appointments = new[]
        {
            new { pID = 1, dID = 1, AppointmentDate = new DateTime(2024, 1, 15) },
            new { pID = 2, dID = 2, AppointmentDate = new DateTime(2024, 1, 16) },
        };

        var query = from appointment in appointments
                    join patient in patients on appointment.pID equals patient.ID
                    join doctor in doctors on appointment.dID equals doctor.ID
                    select new
                    {
                        PatientName = patient.Name,
                        DoctorName = doctor.Name,
                        appointment.AppointmentDate
                    };

        foreach (var item in query)
        {
            Console.WriteLine($"Patient: {item.PatientName}, Doctor: {item.DoctorName}, Date: {item.AppointmentDate}");
        }
        Console.ReadLine();
    }
}

