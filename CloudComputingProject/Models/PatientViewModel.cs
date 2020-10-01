using BLBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CloudComputingProject.Models
{
    public class PatientViewModel
    {
        public Patient patient;

        public PatientViewModel(Patient _patient)
        {
            patient = _patient;
        }

        [DisplayName("תעודת זהות")]
        public int Id
        {
            get { return patient.Id; }
        }


        [DisplayName("שם מלא")]
        public string FullName
        {
            get { return patient.Name; }
            set { patient.Name = value; }
        }


        [DisplayName("מספר טלפון")]
        public string Phone
        {
            get { return patient.PhoneNumber; }
            set { patient.PhoneNumber = value; }
        }

    }
}