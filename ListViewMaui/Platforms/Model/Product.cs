using System.ComponentModel;

namespace ListViewMaui
{
    public class Product : INotifyPropertyChanged
    {
        private int quantity = 0;
        private double totalPrice = 0;

        public string? Name { get; set; }

        //public string? Image { get; set; }

        public string? Weight { get; set; }

        public double Price { get; set; }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    TotalPrice = quantity * Price;
                    RaisePropertyChanged("Quantity");
                }
            }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set
            {
                if (totalPrice != value)
                {
                    totalPrice = value;
                    RaisePropertyChanged("TotalPrice");
                }
            }
        }

        private void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
