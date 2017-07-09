using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techorama.Renderers;
using Techorama.UWP.Renderers;
using Windows.UI.Xaml.Media;
using Xamarin.Forms.Platform.UWP;

[assembly:ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]

namespace Techorama.UWP.Renderers
{
    public class ImageCircleRenderer : ImageRenderer
    {
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control != null && Control.Clip == null)
            {
                var min = Math.Min(Element.Width, Element.Height) / 2.0f;
                if (min <= 0)
                    return;

                EllipseGeometry eg = new EllipseGeometry
                {
                    Center = new Windows.Foundation.Point(min, min),
                    RadiusX = min,
                    RadiusY = min
                };

                /*Control.Clip = new EllipseGeometry
                {
                    Center = new Windows.Foundation.Point(min,min),
                    RadiusX = min,
                    RadiusY = min
                };*/
            }
        }
    }
}
