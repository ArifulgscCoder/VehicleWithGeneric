using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    public interface IExteriorDesign<T>where T : Vehicle
    {
        string[] GetExteriorDesigns(string data);
    }
}
