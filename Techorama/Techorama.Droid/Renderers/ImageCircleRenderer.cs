using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Techorama.Renderers;
using Techorama.Droid.Renderers;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]

namespace Techorama.Droid.Renderers
{
    public class ImageCircleRenderer : ImageRenderer
    {
    }
}