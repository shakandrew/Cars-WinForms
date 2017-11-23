using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Forms
{
    public delegate bool CarsFilter(Car c);

    public class IdentityFilter
    {
        public static CarsFilter get()
        {
            return s => true;
        }
    }

    public interface ICarViewer
    {
        void AddCar(Car c);
        void ShowAddDialog(CarType init);
        void EditCar(Car c);
        void ShowEditDialog();
        void DeleteCar(Car c);
        void ShowDeleteDialog();
        void ReloadData(List<Car> c);
        CarsFilter currentFilter { get; set; }
        int? selectedCarIndex { get; }
    }
}
