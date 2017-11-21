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
using XFDSDeviceID.Interfaces;
using XFDSDeviceID.Droid.Services;

[assembly: Xamarin.Forms.Dependency(typeof(Devices))]
namespace XFDSDeviceID.Droid.Services
{
    public class Devices : IDevices
    {
        public string GetID()
        {
            return Build.Serial;
        }
    }
}