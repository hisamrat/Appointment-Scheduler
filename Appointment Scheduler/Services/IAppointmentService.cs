using Appointment_Scheduler.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appointment_Scheduler.Services
{
   public interface IAppointmentService
    {
        public List<DcotorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();

        public Task<int> AddUpdate(AppointmentVM model);

        public List<AppointmentVM> DoctorsEventsById(string doctorId);
        public List<AppointmentVM> PatientsEventsById(string patientId);

        public AppointmentVM GetById(int id);
    }
}
