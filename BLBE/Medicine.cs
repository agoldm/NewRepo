using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLBE
{
    public class Medicine
    {
        public int Id { get; set; }
        public String CommercialName { get; set; }
        public String Manufacturer { get; set; }
        public String GenericName { get; set; }
        public String ImageUrl { get; set; }
        public List<string> ActiveComponents { get; set; }
        public String Properties { get; set; }

    }
}
