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

namespace PhobiaVRClear
{
    [Activity(Label = "Result and Red")]
    public class Result : Activity
    {
   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            //retrieve the information from shared Preferences
            var localmytest = Application.Context.GetSharedPreferences("Mytests", FileCreationMode.Private);
            int Id = localmytest.GetInt("Id", 1);
            string PhobiaTypeStored = localmytest.GetString("PhobiaType", null);
            string TestTimeStored = localmytest.GetString("Datetime", null);
            float ScoreStored = localmytest.GetFloat("Score", 0);
            string ResultOutputStored = localmytest.GetString("Result", null);

            //Setting the background color for the Tablerows
            int red = Intent.GetIntExtra("BackgroundRed", 0);
            int green = Intent.GetIntExtra("BackgroundGreen", 0);
            int blue = Intent.GetIntExtra("BackgroundBlue", 0);

            SetContentView(Resource.Layout.Result);

            var layoutcolor = FindViewById<LinearLayout>(Resource.Id.ResultLayout);
            layoutcolor.SetBackgroundColor(Android.Graphics.Color.Rgb(red-30, green-30, blue-30));

            var homebutton = FindViewById<ImageView>(Resource.Id.imageHome);
            homebutton.SetBackgroundColor(Android.Graphics.Color.Rgb(red-30, green-30, blue));
            homebutton.Click += Homebutton_Click;

            var scrollcolor = FindViewById<ScrollView>(Resource.Id.scrollViewResult);
            scrollcolor.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));

            var textPhobia = FindViewById<TextView>(Resource.Id.textPhobiaType);
            textPhobia.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
            textPhobia.Text = PhobiaTypeStored;

            var scored = FindViewById<TextView>(Resource.Id.textScore);
            scored.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
            scored.Text = ScoreStored.ToString();

            var Output = FindViewById<TextView>(Resource.Id.textResultOutput);
            Output.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
            Output.Text = ResultOutputStored;

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            Intent home = new Intent(this, typeof(MainActivity));
            this.StartActivity(home);
        }
    }
}