using System;
using Android.Widget;
using Microsoft.Maui.Handlers;
using SampleApp.Controls;

namespace SampleApp.Handlers
{
	public partial class TimePickerViewHandler
	{
#if ANDROID
        public static IPropertyMapper<TimePickerView, TimePickerViewHandler> PropertyMapper = new PropertyMapper<TimePickerView, TimePickerViewHandler>(ViewHandler.ViewMapper)
        {
        };
        public TimePickerViewHandler() : base(PropertyMapper)
        {
        }
#endif
    }
}

