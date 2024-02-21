using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Car
    {
        public delegate void CarStatusChangeDelegate(string message);
        public event CarStatusChangeDelegate StatusChanged;

        private string _name { get; set; }
        private double _price { get; set; }
        private int _qty { get; set; }

        public Car(string name, double price, int qty)
        {
            this._name = name;
            this._price = price;
            this._qty = qty;
        }

        public override string ToString() => $"Name: {_name} \t Price: ${_price:N0} \t Qty: {_qty}";

        public void SetPrice(double newPrice)
        {
            double oldPrice = _price;
            _price = newPrice;

            string message = $"Car Information: {_name}, Price changed: ${oldPrice:N0} -> ${newPrice:N0}";

            StatusChanged?.Invoke(message);
        }

        public void UpdateQty(int newQty)
        {
            int oldQty = _qty;
            _qty = newQty;

            if (newQty > 0 && oldQty <= 0)
            {
                string message = $"Car Information: {_name}, Quantity updated: {oldQty} -> {newQty}";

                StatusChanged?.Invoke(message);
            }
        }
    }
}
