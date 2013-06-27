using System.Windows;

using Telerik.Windows.Controls;

namespace DataTemplates
{
    public class TradePriceCellTemplateSelector : DataTemplateSelector 
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var trade = (Trade)item;

            return trade.Type == Type.Swap ? this.SwapTemplate : this.NormalTemplate;
        }

        public DataTemplate SwapTemplate
        {
            get;
            set;
        }

        public DataTemplate NormalTemplate
        {
            get;
            set;
        }
    }
}
