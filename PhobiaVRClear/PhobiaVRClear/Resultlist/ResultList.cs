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
    [Activity(Label = "Saved Tested")]
    public class ResultList : Activity
    {
   
        private List<ResultListdata> mItem;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            //retrieve the information from shared Preferences
            var localmytest = Application.Context.GetSharedPreferences("Mytests", FileCreationMode.Private);
            int Id = localmytest.GetInt("Id", 1);
            int PhobiaColorRed = localmytest.GetInt("Red", 105);
            int PhobiaColorGreen = localmytest.GetInt("Green", 105);
            int PhobiaColorBlue = localmytest.GetInt("Blue", 105);
            string PhobiaTypeStored = localmytest.GetString("PhobiaType", null);
            string TestTimeStored = localmytest.GetString("Datetime", null);
            float ScoreStored = localmytest.GetFloat("Score", 0);
            string ResultOutputStored = localmytest.GetString("Result", null);

            SetContentView(Resource.Layout.ResultList);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItem = new List<ResultListdata>();
            //mItem.Add(new ResultListdata() {PhobiaType = "thisPhobia", TestTime = "datetime", Score = "10", ResultOutput = "This is working"});
            mItem.Add(new ResultListdata()
            {
                PhobiaType = PhobiaTypeStored,
                TestTime = TestTimeStored,
                Score = ScoreStored,
                ResultOutput = ResultOutputStored
            }); 

            for (int i = 0; i < Id; i++)

            {
                mItem.Add(new ResultListdata()
                {
                    PhobiaType = PhobiaTypeStored,
                    TestTime = TestTimeStored,
                    Score = ScoreStored,
                    ResultOutput = ResultOutputStored
                });

            }

            
         
   
            ResultAdapter adapter = new ResultAdapter(this, mItem);

            mListView.Adapter = adapter;

    }
        
    }
}