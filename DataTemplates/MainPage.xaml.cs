using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace DataTemplates
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            this.TradeGrid.ItemsSource = new List<Trade>()
                                       {
                                           new Trade()
                                               {
                                                   DealDate = new DateTime(2013, 04, 15),
                                                   Id = 1,
                                                   Price = 100,
                                                   Price2Leg = 150,
                                                   Type = Type.Option
                                               },
                                           new Trade()
                                               {
                                                   DealDate = new DateTime(2013, 04, 15),
                                                   Id = 2,
                                                   Price = 200,
                                                   Price2Leg = 250,
                                                   Type = Type.Swap
                                               }
                                       };
        }
    }
}
