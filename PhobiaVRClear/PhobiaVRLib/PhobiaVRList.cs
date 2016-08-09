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

            //start color 1

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Acrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
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

            //start color 2

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Agliophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of pain",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Agoraphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of open spaces or of being in crowded, public places like markets. Fear of leaving a safe place",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Agraphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of sexual abuse",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Agrizoophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of wild animals",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Agyrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of streets or crossing the street",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 3

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Aichmophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of needles or pointed objects",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Ailurophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of cats",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Albuminurophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of kidney disease",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Alektorophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of chickens",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Algophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of pain",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 4

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Alliumphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of garlic",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Allodoxaphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of opinions",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Altophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of heights",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Amathophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of dust",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Amaxophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of riding in a car",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 5

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Ambulophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of walking",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Amnesiphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of amnesia",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Amychophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of scratches or being scratched",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Anablephobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of looking up",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Ancraophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of wind. (Anemophobia)",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 6

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Anemophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of air drafts or wind.(Ancraophobia)",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Anginophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of angina, choking or narrowness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Anglophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of England or English culture",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Angrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of anger or of becoming angry",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Ankylophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of immobility of a joint",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 7

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Anthrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "or Anthophobia- Fear of flowers",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Anthropophobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "Fear of people or society",
                VRAppName = "com.virtualSpeech.android"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Antlophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of floods",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Anuptaphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of staying single",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Apeirophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of infinity",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 8

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Aphenphosmphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of being touched. (Haphephobia)",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Apiphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of bees",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Apotemnophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of persons with amputations",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Arachibutyrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of peanut butter sticking to the roof of the mouth",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Arachnephobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "or Arachnophobia- Fear of spiders",
                VRAppName = "com.aeg.spider"

            });

            //start color 9

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Arithmophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of numbers",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Arrhenphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of men",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Arsonphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of fire",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Asthenophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of fainting or weakness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Astraphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "or Astrapophobia- Fear of thunder and lightning.(Ceraunophobia, Keraunophobia)",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 10

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Astrophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of stars or celestial space",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Asymmetriphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of asymmetrical things",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Ataxiophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of ataxia. (muscular incoordination)",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Ataxophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of disorder or untidiness",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Atelophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of imperfection",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });
            //start color 11

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Atephobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of ruin or ruins",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Athazagoraphobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "Fear of being forgotton or ignored or forgetting",
                VRAppName = "com.virtualSpeech.android"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Atomosophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of atomic explosions",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Atychiphobia",
                VRAppIcon = 2130837663, //this is the icon from drawable ic_get_app_white_36dp
                Description = "Fear of failure",
                VRAppName = "com.virtualSpeech.android"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Aulophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of flutes",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 12

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Aurophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of gold",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Auroraphobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "Fear of Northern lights",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 217,
                rndgreen = 100,
                rndblue = 89,
                Name = "Autodysomophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of one that has a vile odor",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 242,
                rndgreen = 174,
                rndblue = 114,
                Name = "Automatonophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of ventriloquist's dummies, animatronic creatures, wax statues - anything that falsly represents a sentient being",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 199,
                rndgreen = 120,
                rndblue = 120,
                Name = "Automysophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of being dirty",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });

            //start color 13

            _PhobiaList.Add(new PhobiaList
            {
                rndred = 88,
                rndgreen = 140,
                rndblue = 126,
                Name = "Autophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_white_36pd
                Description = "Fear of being alone or of oneself",
                VRAppName = "There is no Vitual Reality Application at this Moment"

            });


            _PhobiaList.Add(new PhobiaList
            {
                rndred = 140,
                rndgreen = 199,
                rndblue = 161,
                Name = "Aviophobia",
                VRAppIcon = 2130837709, //this is the icone from drawable ic_info_outline_whit_36pd
                Description = "or Aviatophobia- Fear of flying",
                VRAppName = "There is no Vitual Reality Application at this Moment"

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
