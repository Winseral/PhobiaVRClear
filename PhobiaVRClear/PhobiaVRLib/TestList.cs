using Android.Content.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Android.Resource;

namespace PhobiaVRLib
{
    public class ListSource {
        private static List<TestList> _TestList;
        static ListSource() {
            //list of anxiety Test Questions
            _TestList = new List<TestList>();
            _TestList.Add(new TestList {


                QuestionNumber = "0",
                Question = "Did you feel tired after the test?"             
               
                
                
            });

          
            _TestList.Add(new TestList
            {

                QuestionNumber = "1",
                Question = "Did you feel nervous?"
              
               

            });

            
            _TestList.Add(new TestList
            {

                QuestionNumber = "2",
                Question = "Did you feel so nervous that nothing could calm you down?"
                
             

            });

            
            _TestList.Add(new TestList
            {

                QuestionNumber = "3",
                Question = "Did you feel hopeless?"
              
                

            });

           
            _TestList.Add(new TestList
            {

                QuestionNumber = "4",
                Question = "Did you feel restless or fidgety?"
               
                

            });


           
            _TestList.Add(new TestList
            {

                QuestionNumber = "5",
                Question = "Did you feel so restless you could not sit still?"
                
               

            });

           
            _TestList.Add(new TestList
            {

                QuestionNumber = "6",
                Question = "Did you feel depressed?"
               
               

            });

           
            _TestList.Add(new TestList
            {

                QuestionNumber = "7",
                Question = "Did you feel that everything was an effort?"
                
                

            });

            
            _TestList.Add(new TestList
            {

                QuestionNumber = "8",
                Question = "Did you feel so sad that nothing could cheer you up?"
             
                

            });


        }
        public static List<TestList> GetTestList(int count) {
            var result1 = _TestList.Take(count).ToList<TestList>();
            return result1;

        }
        public static List<TestList> TestList { get {
                return _TestList;
                    } }

    }
    public class TestList {

        public string QuestionNumber { get; set; }
        public string Question { get; set; }
       
       
 
    }

}
