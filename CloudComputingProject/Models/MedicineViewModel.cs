using BLBE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CloudComputingProject.Models
{
    public class MedicineViewModel
    {
        public Medicine medicine;

        public MedicineViewModel(Medicine _medicine)
        {
            medicine = _medicine;
        }
        public int Id
        {
            get { return medicine.Id; }
        }
        [DisplayName("Name")]
        public string Name
        {
            get { return medicine.CommercialName; }
            set { medicine.CommercialName = value; }
        }
        [DisplayName("Generic Name")]
        public string GenericName
        {
            get { return medicine.GenericName; }
            set { medicine.GenericName = value; }
        }
        [DisplayName("Active Ingredients")]
        public List<string> ActiveIngredients
        {
            get { return medicine.ActiveComponents; }
            set { medicine.ActiveComponents = value; }
        }
        [DisplayName("Company")]
        public string Company
        {
            get { return medicine.Manufacturer; }
            set { medicine.Manufacturer = value; }
        }
        [DisplayName("Image Path")]
        public string ImagePath
        {
            get { return medicine.ImageUrl; }
            set { medicine.ImageUrl = value; }
        }
    }
}