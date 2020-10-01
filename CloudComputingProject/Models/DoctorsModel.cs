using BLBE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudComputingProject.Models
{
    public class DoctorsModel
    {
        public List<Doctor> Doctors { get; set; }

        public DoctorsModel()
        {
            Doctors = new List<Doctor>
            {
                new Doctor {Id=211820790,Name="Moshe Cohen",PhoneNumber="052-0000000",Password="moshe123",LicenseNumber="1234",},
                
            };
        }

        public Doctor GetFood(int Id)
        {
            Doctor Result = null;

            Result = (from d in Doctors
                      where d.Id == Id
                      select d).Single<Doctor>();

            return Result;
        }
    }
}