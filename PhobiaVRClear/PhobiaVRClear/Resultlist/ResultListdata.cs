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
    class ResultListdata
    {
        public string PhobiaType { get; set; }
        public string TestTime { get; set; }
        public float Score { get; set; }
        public string ResultOutput { get; set; }
    }
}