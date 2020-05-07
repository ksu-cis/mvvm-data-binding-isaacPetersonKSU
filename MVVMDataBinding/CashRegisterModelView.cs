using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace MVVMDataBinding
{
    class CashRegisterModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// value of all moneys in the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennys
        {
            get => drawer.Pennies;
            set
            {
                if (value == drawer.Pennies || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// gets or sets the number of nickels in the cash register
        /// </summary>
        public int Nickles
        {
            get => drawer.Nickels;
            set
            {
                if (value == drawer.Nickels || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickles");
            }
        }

        /// <summary>
        /// gets or sets the number of dimes in the drawer
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;
            set
            {
                if (value == drawer.Dimes || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// gets or sets the number of quarters in the drawer
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;
            set
            {
                if (value == drawer.Quarters || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// gets or sets the number of half-dollers in the drawer
        /// </summary>
        public int HalfDollers
        {
            get => drawer.HalfDollars;
            set
            {
                if (value == drawer.HalfDollars || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// gets or sets the number of dollar coins in the drawer
        /// </summary>
        public int Dollers
        {
            get => drawer.Dollars;
            set
            {
                if (value == drawer.Dollars || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// gets or sets the number of ones in the drawer
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (value == drawer.Ones || value < 0) return;
                int quantity = value - drawer.Ones;
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// gets or sets the number of twos in the drawer
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (value == drawer.Twos || value < 0) return;
                int quantity = value - drawer.Twos;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// gets or sets the number of fives in the drawer
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (value == drawer.Fives || value < 0) return;
                int quantity = value - drawer.Fives;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// gets or sets the number of tens in the drawer
        /// </summary>
        public int Tens
        {
            get => drawer.Ones;
            set
            {
                if (value == drawer.Tens || value < 0) return;
                int quantity = value - drawer.Tens;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// gets or sets the number of twenties in the drawer
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;
            set
            {
                if (value == drawer.Twenties || value < 0) return;
                int quantity = value - drawer.Twenties;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// gets or sets the number of fifties in the drawer
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;
            set
            {
                if (value == drawer.Fifties || value < 0) return;
                int quantity = value - drawer.Fifties;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// gets or sets the number of Hundreds in the drawer
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (value == drawer.Hundreds || value < 0) return;
                int quantity = value - drawer.Hundreds;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }
    }
}