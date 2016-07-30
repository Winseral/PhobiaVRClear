using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using PhobiaVRLib;
using Android.Widget;



namespace PhobiaVRClear
{
    [Activity(Label = "Based on K10 Anxiety Test")]
    public class Test : Activity
    {
        
        //list of answers in the RatingBar
        float[] Answerarray = new float[9];
        int CountLength = 9;
        float Score = 0;
        string ResultOutput = "";
        int mytestId;

        protected override void OnCreate(Bundle savedInstanceState)
        {
     
            base.OnCreate(savedInstanceState);

            // Set our view from the "TestMain" layout resource
            SetContentView(Resource.Layout.TestMain);
            
            //Setting the background color for the Tablerows
            int red = Intent.GetIntExtra("BackgroundRed",0);
            int green = Intent.GetIntExtra("BackgroundGreen",0);
            int blue = Intent.GetIntExtra("BackgroundBlue",0);    
                
            //This span the description across two coloums
            TableRow.LayoutParams par = new TableRow.LayoutParams();
            par.Span = 3;
            par.Gravity = GravityFlags.Left;
            par.SetMargins(10, 10, 10, 10);

            //This a new TableRowLayou to centre the RatingBar
            TableRow.LayoutParams wrap = new TableRow.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            wrap.Gravity = GravityFlags.Center;

            //This a new TableRowLayou to centre the Rating text
            TableRow.LayoutParams wrap2 = new TableRow.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            wrap2.Gravity = GravityFlags.Center;

            //This span for Result button
            TableRow.LayoutParams par2 = new TableRow.LayoutParams();
            par2.Span = 3;

            //home button
            var homebutton = FindViewById<ImageView>(Resource.Id.imageHometest);
            homebutton.SetBackgroundColor(Android.Graphics.Color.Rgb(red - 30, green - 30, blue - 30));
            homebutton.Click += Homebutton_Click;

            //set the Questiontable to the Home button color
            var testlinearlayout = FindViewById<LinearLayout>(Resource.Id.testlinearlayout);
            testlinearlayout.SetBackgroundColor(Android.Graphics.Color.Rgb(red - 30, green - 30, blue - 30));


            //Sets the Phobiatype from intent sets to QuestionTable TestMain.axml
            var Qtable = FindViewById<TableLayout>(Resource.Id.QuestionTable);

            var QuestionRow = new TableRow(this);

            Qtable.AddView(QuestionRow);
            Qtable.SetColumnStretchable(0, true);
            Qtable.SetBackgroundColor(Android.Graphics.Color.Rgb(red-30, green-30, blue-30));
  

            var textView = new TextView(this);
            textView.Text = Intent.GetStringExtra("PhobiaType");
            textView.SetTextSize(Android.Util.ComplexUnitType.Dip, 36);
            textView.Gravity = GravityFlags.Center;
            textView.SetBackgroundColor(Android.Graphics.Color.Rgb(red-30,green-30,blue-30));
            QuestionRow.AddView(textView);


            //Creates a new tablelayout from answerTable in TestMain.axml
            var Qtable2 = FindViewById<TableLayout>(Resource.Id.AnswerTable);
            Qtable2.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
            var Questionlist = PhobiaVRLib.ListSource.GetTestList(CountLength);

            Qtable2.SetColumnStretchable(0, true);
            
            //Starts the Forloop and gets the list of questions from Testlist in PhobiaVRLib
            foreach (var List in Questionlist)
            {
                
                var QuestionRow2 = new TableRow(this);

                //List of Questions
                Qtable2.AddView(QuestionRow2);

                var textView2 = new TextView(this);
                textView2.Text = List.Question;
                textView2.SetTextSize(Android.Util.ComplexUnitType.Dip, 24);
                // textView2.Gravity = GravityFlags.Left;
                textView2.SetMinLines(2);
                textView2.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));

                QuestionRow2.AddView(textView2, par);


                var QuestionRow3 = new TableRow(this);
                
                Qtable2.AddView(QuestionRow3);
                //Rating
                var myRatingBar = new RatingBar(this);
                myRatingBar.NumStars = 4;
                myRatingBar.StepSize = .2f;
                myRatingBar.ScaleX = 1.3f;
                myRatingBar.ScaleY = 1.3f;
                myRatingBar.RatingBarChange += (o, e) => 
                {

                    //gets the index value of each entered Rating and stores in Answerarry[i] value
                    for (int i = 0; i < CountLength; i++)
                    {
                        if (List.QuestionNumber.IndexOf(Convert.ToString(i), 0) == 0)
                        {
                            Answerarray[i] = myRatingBar.Rating;
                        }
                    }

                    Toast.MakeText(this,"0:" + Answerarray[0] + "  1:" + Answerarray[1] + "  2:" + Answerarray[2] + "  3:" + Answerarray[3] + "  4:" + Answerarray[4] + "  5:" + Answerarray[5] + "   6:" + Answerarray[6] + "  7:" + Answerarray[7] + "  8:" + Answerarray[8], ToastLength.Short).Show();
                 };
                //myRatingBar.SetBackgroundResource(Resource.Drawable.CustomRatingBar);
                myRatingBar.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
                QuestionRow3.AddView(myRatingBar,wrap);

                //Col Test
                var QuestionRow5 = new TableRow(this);

                Qtable2.AddView(QuestionRow5);
                var testNames = new TextView(this);
                testNames.Text = "0 Not at All - 1 Little - 2 Sometimes - 3 Most of the time - 4 All the time";
                testNames.SetTextSize(Android.Util.ComplexUnitType.Dip, 10);
                testNames.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));

                QuestionRow5.AddView(testNames, wrap2);

                //******* - get the save variables from the overide savedInstancestate - ******
                if (savedInstanceState != null)
                {

                    for (int i = 0; i < CountLength; i++)
                      {
                        if (List.QuestionNumber.IndexOf(Convert.ToString(i), 0) == 0)
                        {
                            Answerarray[i] = savedInstanceState.GetFloat("Answer" + Convert.ToString(i));
                            myRatingBar.Rating = Answerarray[i];
                        }
                      }
                } //******** - End of RatingBar SavedInstance - ******

            } //End Test list foreach loop


            var QuestionRow6 = new TableRow(this);
            Qtable2.AddView(QuestionRow6);

            //result button create after all of the questions are loaded
            var ResultButton = new Button(this);
            ResultButton.SetBackgroundColor(Android.Graphics.Color.Rgb(red-30, green-30, blue-30));
            ResultButton.Text = "Result";
            ResultButton.Click += delegate
            {
                //caculate score
                for (int i = 0; i < CountLength; i++)
                {
                    Score += Answerarray[i];
                }

                //determine result
                if (Score <= 15)
                {
                    ResultOutput = "OK to try next difficulty";
                }               
                if (Score >= 16 && Score <= 20)
                {
                    ResultOutput = "You could try next difficutly if you feel OK";
                } 
                if (Score >= 21 && Score <= 25)
                {
                    ResultOutput = "Wait a while and retry this difficulty";
                }
                if (Score >= 26)
                {
                    ResultOutput = "Wait until you feel better before trying this difficutly again";
                }
  
                var timenow = DateTime.Now.ToString();


                //Stores the anwser into Local file Mytests
                var localmytest = Application.Context.GetSharedPreferences("Mytests", FileCreationMode.Private);
                //test for latest Mytest number
                var mytest = localmytest.Edit();
                mytest.PutInt("Id", mytestId);
                mytest.PutInt("Red", Intent.GetIntExtra("BackgroundRed", 0));
                mytest.PutInt("Green", Intent.GetIntExtra("BackgroundGreen", 0));
                mytest.PutInt("Blue", Intent.GetIntExtra("Backgroundblue", 0));
                mytest.PutString("PhobiaType", textView.Text);
                mytest.PutString("Datetime", timenow);
                for (int i = 0; i < CountLength; i++)
                {
                    mytest.PutFloat("Answer" + Convert.ToString(i), Answerarray[i]);
                }
                mytest.PutFloat("Score", Score);
                mytest.PutString("Result", ResultOutput);
                mytest.Commit();

                Toast.MakeText(this, textView.Text + " Phobia - Test saved at:" + timenow + "   " + Score + "  " + ResultOutput, ToastLength.Short).Show();

                Score = 0;
                ResultOutput = "";
                mytestId++;

                Intent Result = new Intent(this, typeof(Result));
                Result.PutExtra("BackgroundRed", red);
                Result.PutExtra("BackgroundGreen", green);
                Result.PutExtra("BackgroundBlue", blue);
                this.StartActivity(Result);

            };

            QuestionRow6.AddView(ResultButton,par2);

            //Create Reference Row 
            var QuestionRow7 = new TableRow(this);
            Qtable2.AddView(QuestionRow7);
            //reference text
            var Referencetext = new TextView(this);
            Referencetext.Text = "https://www.beyondblue.org.au/the-facts/anxiety-and-depression-checklist-k10 and Andrews, G., Slade, T (2001). Interpreting scores on the Kessler Psychological Distress Scale(k10).Australian and New Zealand Journal of Public Health, 25, 494 - 497 ";
            Referencetext.SetTextSize(Android.Util.ComplexUnitType.Dip, 11);
            Referencetext.SetBackgroundColor(Android.Graphics.Color.Rgb(red, green, blue));
            Referencetext.SetMaxLines(4);

            QuestionRow7.AddView(Referencetext,par2);
            
        } //End of OnCreate

        private void Homebutton_Click(object sender, EventArgs e)
        {
            Intent home = new Intent(this, typeof(MainActivity));
            this.StartActivity(home);
        }

        //Save the RatingBar Answers in this Override
        protected override void OnSaveInstanceState(Bundle outState)
        {
            for (int i = 0; i < CountLength; i++)
            {
                outState.PutFloat("Answer" + Convert.ToString(i), Answerarray[i]);
            }
            base.OnSaveInstanceState(outState);
        }
    }
}