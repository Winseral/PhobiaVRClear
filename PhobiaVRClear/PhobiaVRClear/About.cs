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
    [Activity(Label = "About", Theme = "@style/PhobiaVRClearTheme")]
    public class About : Activity
    {
        ImageView button_home;

        protected override void OnCreate(Bundle savedInstanceState)
        {
  
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.About);

            button_home = FindViewById<ImageView>(Resource.Id.imageHome2);
            button_home.Click += Button_home_Click;
        }
       
        //This is popmenu click event
        private void Button_home_Click(object sender, EventArgs e)
        {
           
            PopupMenu menu = new PopupMenu(this, button_home);
            menu.MenuInflater.Inflate(Resource.Menu.popup_menu, menu.Menu);

            menu.MenuItemClick += (s, arg) =>
            {
                Console.WriteLine("{0} selected", arg.Item.TitleFormatted);

                if (arg.Item.TitleFormatted.ToString() == "Home")
                {
                    Intent Home = new Intent(this, typeof(MainActivity));
                    this.StartActivity(Home);
                };

                if (arg.Item.TitleFormatted.ToString() == "Previous Test")
                {
                    Intent Result = new Intent(this, typeof(Result));
                    this.StartActivity(Result);
                };

                if (arg.Item.TitleFormatted.ToString() == "About")
                {
                    //run an intent here
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