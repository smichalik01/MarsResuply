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

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using MarsResuply.Droid.Renderers;

[assembly: ExportRenderer(typeof(Xamarin.Forms.ProgressBar), typeof(FuelControlRenderer))]
namespace MarsResuply.Droid.Renderers
{
    public class FuelControlRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ScaleY = 4.0f;
                Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.PapayaWhip, PorterDuff.Mode.SrcIn);
            }
        }
    }
}
