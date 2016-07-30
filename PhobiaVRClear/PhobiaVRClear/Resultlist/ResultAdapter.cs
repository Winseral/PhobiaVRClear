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
    class ResultAdapter : BaseAdapter<ResultListdata>
    {

        Context mContext;
        public List<ResultListdata> mItem;

        public ResultAdapter(Context context, List<ResultListdata> item)
        {
            mContext = context;
            mItem = item;

        }

        public override int Count
        {
            get
            {
                return mItem.Count;
            }
        }

       /* public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }*/

        public override long GetItemId(int position)
        {
            return position;
        }

        public override ResultListdata this[int position]
        {
            get { return mItem[position]; }

        }


        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            // Adapter1ViewHolder holder = null;

            if (view == null)
            // holder = view.Tag as Adapter1ViewHolder;
            {
                view = LayoutInflater.From(mContext).Inflate(Resource.Layout.ResultListAdapter, null, false);
            }

            /* if (holder == null)
             {
                 holder = new Adapter1ViewHolder();
                 var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                 //replace with your item and your holder items
                 //comment back in
                 //view = inflater.Inflate(Resource.Layout.item, parent, false);
                 //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
                 view.Tag = holder;
             }*/
         
            TextView textPhobiaType = view.FindViewById<TextView>(Resource.Id.textPhobiaType);
            textPhobiaType.Text = mItem[position].PhobiaType;

            TextView textDateTime = view.FindViewById<TextView>(Resource.Id.textDateTime);
            textDateTime.Text = mItem[position].TestTime;

            TextView textScore = view.FindViewById<TextView>(Resource.Id.textScore);
            textScore.Text = mItem[position].Score.ToString();

            TextView textResult = view.FindViewById<TextView>(Resource.Id.textResult);
            textResult.Text = mItem[position].ResultOutput;

            return view;
        }


    }

    //class Adapter1ViewHolder : Java.Lang.Object
   // {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
   // }
}