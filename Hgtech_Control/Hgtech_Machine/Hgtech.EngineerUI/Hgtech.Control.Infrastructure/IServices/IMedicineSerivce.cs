using Hgtech.Control.Infrastructure.Interceptor.HandlerAttributes;
using Hgtech.Control.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgtech.Control.Infrastructure.IServices
{
    [LogHandler]
    public interface IMedicineSerivce
    {
        List<Medicine> GetAllMedicines();

        List<Recipe> GetRecipesByPatientId(int patientId);
    }
}
