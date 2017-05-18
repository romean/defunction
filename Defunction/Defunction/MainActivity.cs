using System;
using Android.Runtime;
using Android.Views;
using Android.Content;
using Android.App;
using Android.Widget;
using Android.OS;

namespace Defunction
{
    [Activity(Label = "Defunction", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Material.Light")]
    public class MainActivity : Activity
    {
        Button button1;
        Button button2;
        Button button4;
        Button button5;
        Button button6;
        Button button7;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
            button4 = FindViewById<Button>(Resource.Id.button4);
            button5 = FindViewById<Button>(Resource.Id.button5);
            button6 = FindViewById<Button>(Resource.Id.button6);
            button7 = FindViewById<Button>(Resource.Id.button7);

            button1.Click += delegate (object sender, EventArgs e)
            {
                StartActivity(typeof(comb));
            };
        }
    }
}