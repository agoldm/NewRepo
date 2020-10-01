using BLBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CloudComputingProject.Models
{
    public class PrescriptionViewModel
    {
        public Prescription prescription;

        public PrescriptionViewModel(Prescription _prescription)
        {
            prescription = _prescription;
        }


        [DisplayName("מספר רופא")]
        public int DoctorId
        {
            get { return prescription.DoctorId; }
            set { prescription.DoctorId = value; }
        }
        [DisplayName("זמן סיום")]
        public DateTime EndTime
        {
            get { return prescription.EndTime; }
            set { prescription.EndTime = value; }
        }

        [DisplayName("תרופה")]
        public int MedicineId
        {
            get { return prescription.MedicineId; }
            set { prescription.MedicineId = value; }
        }
        
  
        [DisplayName("מספר פציינט")]
        public int PatientId
        {
            get { return prescription.PatientId; }
            set { prescription.PatientId = value; }
        }
        [DisplayName("זמן התחלה")]
        public DateTime StartTime
        {
            get { return prescription.StartTime; }
            set { prescription.StartTime = value; }
        }
    }
}