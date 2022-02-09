using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prakt14
{
    public class CarViewModel : INotifyPropertyChanged
    {
        private Car _selectedCar;
        public ObservableCollection<Car> Cars { get; set; }
        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                OnPropertyChanged("SelectedCar");
            }
        }
        public CarViewModel()
        {
            Cars = new ObservableCollection<Car>
                 {
                  new Car { Model="ВАЗ-2105", MaxSpeed=150, Price=56000 },
                  new Car { Model="LADA Priora", MaxSpeed=170, Price=560000 },
                  new Car { Model="КамАЗ", MaxSpeed=100, Price=5600000 },
                  new Car { Model="Новый мерин", MaxSpeed=300, Price=530000 }
                 };
        }
        public void AddCar()
        {
            Car car = new Car();
            Cars.Insert(0, car);
            SelectedCar = car;
          
        }
        public void DeleteCar()
        {
            if (_selectedCar != null)
            {
                Cars.Remove(SelectedCar);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

}
