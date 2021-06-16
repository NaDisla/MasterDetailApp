using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MasterDetailApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(Button), typeof(FixUppercaseButton))]
#pragma warning restore CS0612 // Type or member is obsolete
namespace MasterDetailApp.Droid
{
    [Obsolete]
    public class FixUppercaseButton : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            Control.SetAllCaps(false);
        }
    }
}