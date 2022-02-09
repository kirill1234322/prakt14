using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prakt14
{
   public class Car : INotifyPropertyChanged
    {
        private string _model;
        private int _maxSpeed;
        private decimal _price;
        private decimal _disc;

       
        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged("Model");
            }
        }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                _maxSpeed = value;
                OnPropertyChanged("MaxSpeed");
            }
        }
        public decimal Discount
        {
            get { return _disc; }
            set
            {
                _disc = value;              
                OnPropertyChanged("HasDiscount");
            }
        }
        public decimal Price
        {
            get
            {
                return _price * (1 - _disc / 100);
            }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        public bool HasDiscount
        {
           
                get
                {
                OnPropertyChanged("Price");
                return _disc > 0;
                   
                   

                }
            
        }
       

        public decimal DiscountPrice
        {
            get
            {
                return Price * (decimal)(1 - Discount);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
