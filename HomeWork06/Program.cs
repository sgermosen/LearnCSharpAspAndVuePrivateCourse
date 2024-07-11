/*
Desarrolle un programa que:
1.	Implemente una clase MedicalAppointment que herede de una clase base Person y añada propiedades específicas de una cita médica.
2.	Utilice propiedades auto-implementadas, métodos y niveles de acceso adecuados en sus clases.
3.	Cree instancias de sus clases y demuestre su uso en un método.

 * */

using ProgramsForLearning.HomeWork6;

var appointment = new MedicalAppointment
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30,
    Sex = 'M',
    AppointmentDate = new DateTime(2023, 12, 1),
    DoctorName = "Smith"
};

appointment.DisplayInformation();
appointment.DisplayAppointmentDetails();
