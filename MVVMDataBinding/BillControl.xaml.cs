using CashRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMDataBinding
{
    /// <summary>
    /// Interaction logic for BillControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",
                typeof(Bills),
                typeof(BillControl),
                new PropertyMetadata(Bills.One));

        /// <summary>
        /// The denomination of the coin being modified
        /// </summary>
        public Bills Denomination
        {
            get => (Bills)GetValue(DenominationProperty);
            set => SetValue(DenominationProperty, value);
        }

        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(BillControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        public BillControl()
        {
            InitializeComponent();
        }

        public void OnIncreaseClick(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        public void OnDecreaseClick(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
