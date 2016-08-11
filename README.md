# PhobiaVRClear
================
# [Xamarin.Android Application](https://github.com/xamarin/xamarin-android/blob/master/README.md)

# [Deakin](http://www.deakin.edu.au/) IT Degree SIT313 Tri2 2016 Mobile Computing 


##Phobia testing application designed to help find Phobia Virtual Reality Applications, test and overcome your fears.
-----------------

### Android Supported API 19 KitCat to Android N API 24
### [Download the code from GitHub](https://github.com/Winseral/PhobiaVRClear)

-----------------

### Phobia List and their descriptions
![mainpage](https://cloud.githubusercontent.com/assets/12288812/17422701/b27255b4-5af7-11e6-80f3-8224744e30a0.PNG)

### [K10 Anxiety Test from Beyond Blue](https://www.beyondblue.org.au/the-facts/anxiety-and-depression-checklist-k10])
![question page](https://cloud.githubusercontent.com/assets/12288812/17422704/b7273714-5af7-11e6-8d90-a0ae8fdd707d.PNG)

### About page
![about page](https://cloud.githubusercontent.com/assets/12288812/17422723/ce03b3fe-5af7-11e6-81c4-33e2ead83026.PNG)
----------------

##Data structure - all data found in PhobiaVRClearLib
![datastructure](https://cloud.githubusercontent.com/assets/12288812/17501665/3afc1aee-5e24-11e6-9109-bfa126959b70.PNG)

#Code
===============
##*****Google Play Store Intent****
```

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

```
##****Popup Menu ****
```

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
        
  ```
----------------
#Styles
================
##**Popup axml -  Menu folder**
```
  <?xml version="1.0" encoding="utf-8"?>
<menu xmlns:android="http://schemas.android.com/apk/res/android">
  <item android:id="@+id/item1"
        android:title ="Home"/>
  <item android:id="@+id/item2"
        android:title ="Previous Test"/>
  <item android:id="@+id/item3"
          android:title ="About"/>
</menu>
```
##**Custom Page style**
```
?xml version="1.0" encoding="utf-8" ?>
<resources>
  <style name="PhobiaVRClearTheme" parent="@android:style/Theme.Holo">
    <item name="android:actionBarSize">0dp</item>
    <item name="android:colorPrimary">#007d99</item>
    <item name="android:colorPrimaryDark">#40c5e9</item>
    <item name="android:textColor">#f2f2f2</item>
    <item name="android:textColorPrimary">#f2f2f2</item>
  </style>
</resources>
```
---------------
#[Offical Google IconsMaterial](http://www.google.com/design/spec/style/icons.html#icons-system-icons)

###The material design icons were used in this project, the guidlines specs can be found at http://www.google.com/design/spec
Please see the [Creative Commons Attribution 4.0 Internationl License](http://creativecommons.org/licenses/by/4.0/) for use
--------------


