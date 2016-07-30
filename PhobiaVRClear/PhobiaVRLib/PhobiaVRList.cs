using Android.Content.PM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Android.Resource;

namespace PhobiaVRLib
{
    public class PhobiaVRSource {
        private static List<PhobiaList> _PhobiaList;
        static PhobiaVRSource() {
            //list of phobias and possible VR teatment and anxiety Test buttons
            _PhobiaList = new List<PhobiaList>();
            _PhobiaList.Add(new PhobiaList {

                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Ablutophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of washing or bathing",
                VRAppName = "There is no Vitual Reality Application at this Moment"
                
            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Acarophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of itching or of the insects that cause itching",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Acerophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of sourness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Achluophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of darkness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Acousticophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of noise",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color again

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Acrophobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "Fear of heights",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Aerophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of drafts, air swallowing, or airbourne noxious substances",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Aeroacrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of open high places",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Aeronausiphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of vomiting secondary to airsickness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Agateophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of insanity",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color again

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Arachnophobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "Fear of spiders",
                VRAppName = "com.aeg.spider"

            });


        }
        public static List<PhobiaList> GetPhobiaList(int count) {
            var result = _PhobiaList.Take(count).ToList<PhobiaList>();
            return result;

        }
        public static List<PhobiaList> PhobiaList { get {
                return _PhobiaList;
                    } }

    }
    public class PhobiaList {
        public int rndred { get; set; }
        public int rndgreen { get; set; }
        public int rndblue { get; set; }
        public string Name { get; set; }
        public int VRAppIcon { get; set; }
        public string Description { get; set; }
        public string VRAppName { get; set; }

    }

}
