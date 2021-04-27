using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgtech.Control.Infrastructure.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        public List<Medicine> LstMedicines { get; set; }
    }
}
