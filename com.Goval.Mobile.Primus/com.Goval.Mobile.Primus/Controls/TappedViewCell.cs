using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace com.Goval.Mobile.Primus.Controls
{
    public class TappedViewCell : ViewCell
    {
        public TappedViewCell()
        {
            View.GestureRecognizers.Clear();
            View.GestureRecognizers.Add(new TapGestureRecognizer());
        }
        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create("TappedCommandProperty", typeof(ICommand), typeof(TappedViewCell), null, propertyChanged: OnTappedCommandChanged);

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            OnTappedCommandChanged(this, null, null);
        }

        private static void OnTappedCommandChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var viewCell = bindable as TappedViewCell;

            if (viewCell == null)
                return;

            viewCell.View.GestureRecognizers.Clear();
            viewCell.View.GestureRecognizers.Add(new TapGestureRecognizer() { Command = viewCell.TappedCommand });
        }
    }
}
