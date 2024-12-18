namespace WpfApp.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Appointment
    {
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
