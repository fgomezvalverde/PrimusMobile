using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace com.Goval.Mobile.Primus.Controls
{
    class CustomMap : Map
    {
        private IList<Pin> _staticPins;
        public IList<Pin> StaticPins
        {
            get { return _staticPins; }
            set
            {
                _staticPins = value;
                foreach (var pin in value)
                {
                    this.Pins.Add(pin);
                }
            }
        }
    }
}
