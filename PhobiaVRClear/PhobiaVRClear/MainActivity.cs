using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;
using static Android.Views.View;
using System;
using Android.Graphics;
using static Android.Resource;
using PhobiaVRLib;
using Uri = Android.Net.Uri;
using Android.Content;


namespace PhobiaVRClear
{
    [Activity(Label = "PhobiaVRClear", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/PhobiaVRClearTheme")]
    public class MainActivity : Activity
    {
        ImageView button_home;
      

        protected override void OnCreate(Bundle bundle)
        {
 
            base.OnCreate(bundle);

            Vibrator myvibrator = (Vibrator)this.ApplicationContext.GetSystemService(Context.VibratorService);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            button_home = FindViewById<ImageView>(Resource.Id.imageHome1);
            button_home.Click += Homemenu_Click;


            //set the Phobia list for Library on to the table layout call PhobiaTableLayout
            var phobias = PhobiaVRLib.PhobiaVRSource.GetPhobiaList(11);
            var table = FindViewById<TableLayout>(Resource.Id.PhobiaTableLayout);
            table.SetColumnStretchable(0, true);
            table.SetColumnStretchable(1, true);
            table.SetColumnStretchable(2, true);

            foreach (var Phobialisted in phobias)
            {
              
                var tableRow = new TableRow(this);
                var tableRow1 = new TableRow(this);


                //This span the description across three coloums
                TableRow.LayoutParams par = new TableRow.LayoutParams();
                par.Span = 3;

                //Setting the background color for the Tablerows
                tableRow.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred, Phobialisted.rndgreen, Phobialisted.rndblue));
                tableRow1.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred, Phobialisted.rndgreen, Phobialisted.rndblue));

                //creating the tablerows for the tablelayout
                table.AddView(tableRow);

                //the names from the PhobiaVRClear Library(PhboiaList) inserts into table
                var textView = new TextView(this);
                textView.Text = Phobialisted.Name;
                //Set the Names to left margin
                textView.SetTextSize(Android.Util.ComplexUnitType.Dip, 24);
                textView.Gravity = GravityFlags.Left;
                tableRow.AddView(textView);

                //Creating the Imagebutton for VR application launcher
                ImageView VRAppButton = new ImageView(this);
                VRAppButton.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred-20, Phobialisted.rndgreen-20, Phobialisted.rndblue-20));
                VRAppButton.SetImageResource(Phobialisted.VRAppIcon);
                VRAppButton.SetPadding(50, 50, 50, 50);
                // familyimage.setScaleType(ImageView.ScaleType.FIT_START);
                //familyimage.setAdjustViewBounds(true);
                VRAppButton.Click += delegate
                {

                    //Check to see the download icon before allow to access the Google store
                    if (Phobialisted.VRAppIcon != 2130837709)
                    {
                        VRAppButton.PlaySoundEffect(SoundEffects.Click);
                        VRAppButton.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred - 30, Phobialisted.rndgreen - 30, Phobialisted.rndblue - 30));
                        //Google Play store intent
                        Intent downloadVRApp = new Intent(Intent.ActionView);
                        downloadVRApp.SetData(Uri.Parse("market://details?id=" + Phobialisted.VRAppName));
                        StartActivity(downloadVRApp);
                    }
                    else {
                        Toast.MakeText(this, "There is no Virtual Realty Application for this Phobia", ToastLength.Short).Show (); 
                         }
                };

                tableRow.AddView(VRAppButton);

                ImageView AnxietyButton = new ImageView(this);
                AnxietyButton.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred-30, Phobialisted.rndgreen-30, Phobialisted.rndblue-30));
                AnxietyButton.SetImageResource(Resource.Drawable.ic_thumb_up_white_36dp);
                AnxietyButton.SetPadding(50, 50, 50, 50);
                // familyimage.setScaleType(ImageView.ScaleType.FIT_START);
                //familyimage.setAdjustViewBounds(true);
                AnxietyButton.Click += delegate
                {
                    AnxietyButton.PlaySoundEffect(SoundEffects.Click);
                    AnxietyButton.SetBackgroundColor(Android.Graphics.Color.Rgb(Phobialisted.rndred - 50, Phobialisted.rndgreen - 50, Phobialisted.rndblue - 50));
                    //Anxiety Test Intent
                    Intent testing = new Intent(this, typeof(Test));
                    testing.PutExtra("PhobiaType", Phobialisted.Name);
                    testing.PutExtra("BackgroundRed", Phobialisted.rndred);
                    testing.PutExtra("BackgroundGreen", Phobialisted.rndgreen);
                    testing.PutExtra("BackgroundBlue", Phobialisted.rndblue);
                    this.StartActivity(testing);

                };
                tableRow.AddView(AnxietyButton);


                //Row two add for description            
                table.AddView(tableRow1);
     
                //the names from the PhobiaVRClear Library(PhboiaList) inserts into table
                var textView2 = new TextView(this);
                textView2.Text = Phobialisted.Description;
                textView2.SetTextSize(Android.Util.ComplexUnitType.Dip,16);

                //Set the Names to right margin
                textView2.Gravity = GravityFlags.Left;
                textView2.SetMinLines(3);
                  
                tableRow1.AddView(textView2,par);

            }

          
        }
        //This is popmenu click event
        private void Homemenu_Click(object sender, EventArgs e)
        {
            PopupMenu menu = new PopupMenu(this, button_home);
            menu.MenuInflater.Inflate(Resource.Menu.popup_menu, menu.Menu);

            menu.MenuItemClick += (s, arg) =>
            {
                Console.WriteLine("{0} selected", arg.Item.TitleFormatted);

                if (arg.Item.TitleFormatted.ToString() == "Home")
                {
                    //not required but need the spacing
                };

                if (arg.Item.TitleFormatted.ToString() == "Previous Test")
                {
                    Intent Result = new Intent(this, typeof(Result));
                    this.StartActivity(Result);
                };

                if (arg.Item.TitleFormatted.ToString() == "About")
                {
                    Intent Home = new Intent(this, typeof(About));
                    this.StartActivity(Home);
                };

            };

            menu.DismissEvent += (s, arg) =>
            {
                Console.WriteLine("menu dismissed");
            };
            menu.Show();
        }
       
    }

}

