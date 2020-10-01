using BLBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CloudComputingProject.Models
{
    public class DoctorViewModel
    {
        public Doctor doctor;

        public DoctorViewModel(Doctor _doctor)
        {
            doctor = _doctor;
        }
        [DisplayName("תעודת זהות")]
        public int Id
        {
            get { return doctor.Id; }
        }
        [DisplayName("שם")]
        public string Name
        {
            get { return doctor.Name; }
            set { doctor.Name = value; }
        }
        [DisplayName("מספר טלפון")]
        public string PhoneNumber
        {
            get { return doctor.PhoneNumber; }
            set { doctor.PhoneNumber = value; }
        }

        [DisplayName("מספר רישוי")]
        public string LicenseNumber
        {
            get { return doctor.LicenseNumber; }
            set { doctor.LicenseNumber = value; }
        }
   


    }
}