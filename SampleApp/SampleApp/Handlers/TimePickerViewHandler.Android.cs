using System;
using Android.Text.Format;
using Android.Views;
using Android.Widget;
using Com.Loper7.Date_time_picker;
using Microsoft.Maui.Handlers;
using SampleApp.Controls;

namespace SampleApp.Handlers
{
	public partial class TimePickerViewHandler:ViewHandler<TimePickerView, LinearLayout>
	{
        private Business business;

        protected override LinearLayout CreatePlatformView()
        {
            var inflater = LayoutInflater.From(Context);
            var result = inflater.Inflate(Resource.Layout.DateTimePickerLayout, null) as LinearLayout;
            var picker = result.FindViewById<DateTimePicker>(Resource.Id.picker);
            business = new Business(picker);
            picker.SetOnDateTimeChangedListener(business);
            return result;
        }
    }

    public class Business : Java.Lang.Object, Kotlin.Jvm.Functions.IFunction1
    {
        private DateTimePicker picker;

        public Business(DateTimePicker thePicker)
        {
            picker = thePicker;
        }

        public Java.Lang.Object Invoke(Java.Lang.Object p0)
        {
            var ms = picker.Millisecond;

            var str = DateFormat.Format("yyyy-MM-dd HH:mm:ss", ms);
            
            Toast.MakeText(Platform.CurrentActivity, str, ToastLength.Short).Show();
            
            return null;
        }
    }
}

