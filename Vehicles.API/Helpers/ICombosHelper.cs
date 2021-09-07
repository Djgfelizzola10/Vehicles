using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboDocumentType();
        IEnumerable<SelectListItem> GetComboProcedures();
        IEnumerable<SelectListItem> GetComboVehiclesType();
        IEnumerable<SelectListItem> GetComboBrands();
    }
}
