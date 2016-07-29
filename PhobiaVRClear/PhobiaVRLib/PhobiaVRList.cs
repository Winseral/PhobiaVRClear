using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhobiaVRLib
{
    public class PhobiaVRSource {
        private static List<PhobiaList> _PhobiaList;
        static PhobiaVRSource() {
            //list of phobias and possible VR teatment and anxiety Test buttons
            _PhobiaList = new List<PhobiaList>();
            _PhobiaList.Add(new PhobiaList{
                Name = "Phobia 1",
                Description = "Description Phobia   1",
                VRAppName = "theapp"
                
            });

            _PhobiaList.Add(new PhobiaList
            {
                Name = "Phobia 2",
                Description = "Description Phobia   2",
                VRAppName = "theapp"

            });

            _PhobiaList.Add(new PhobiaList
            {
                Name = "Phobia 3",
                Description = "Description Phobia     3",
                VRAppName = "theapp"

            });

            _PhobiaList.Add(new PhobiaList
            {
                Name = "Phobia 4",
                Description = "Description Phobia    4",
                VRAppName = "theapp"

            });

            _PhobiaList.Add(new PhobiaList
            {
                Name = "Phobia 5",
                Description = "Description Phobia5  ",
                VRAppName = "theapp"

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
        public string Name { get; set; }
        public string Description { get; set; }
        public string VRAppName { get; set; }

    }

}
