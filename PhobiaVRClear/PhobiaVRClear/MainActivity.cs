using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PhobiaVRLib;

namespace PhobiaVRClear
{
    [Activity(Label = "PhobiaVRClear", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //set the Phobia list for Library on to the table layout call PhobiaTableLayout
            var phobias = PhobiaVRLib.PhobiaVRSource.GetPhobiaList(5);
            var table = FindViewById<TableLayout>(Resource.Id.PhobiaTableLayout);

            foreach (var Phobialisted in phobias)
            {

                var tableRow = new TableRow(this);
                var tableRow1 = new TableRow(this);

                table.AddView(tableRow);

                //the names from the PhobiaVRClear Library(PhboiaList) inserts into table
                var textView = new TextView(this);
                textView.Text = Phobialisted.Name;
                //Set the Names to left margin
                textView.Gravity = GravityFlags.Left;
               // this does not change text size textView.SetTextAppearance(Android.Resource.Attribute.TextAppearanceSmall);

                tableRow.AddView(textView);

                var VRAppButton = new Button(this);
                VRAppButton.Text = Phobialisted.VRAppName;
                VRAppButton.Gravity = GravityFlags.Center;

                VRAppButton.Click += delegate
                {
                    //Add google Store Intent using the VRAppName 
                };
                
                tableRow.AddView(VRAppButton);


                // Anxiety test Button 
                var AnxietyButton = new Button(this);
                AnxietyButton.Text = "Test";
                AnxietyButton.Gravity = GravityFlags.Center;

                AnxietyButton.Click += delegate
                {
                    //Add takes to Anxiety Class and layout

                };

                tableRow.AddView(AnxietyButton);


                //Row two add for description            
                table.AddView(tableRow1);
                //the names from the PhobiaVRClear Library(PhboiaList) inserts into table
                var textView2 = new TextView(this);
                textView2.Text = Phobialisted.Description;
                
                //Set the Names to right margin
                textView2.Gravity = GravityFlags.Left;
                tableRow1.AddView(textView2);

            }

        }
    }

}

