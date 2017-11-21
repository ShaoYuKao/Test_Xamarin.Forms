using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XFDSDeviceID.Interfaces;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Device))]
namespace XFDSDeviceID.iOS.Implementations
{
    public class Device : IDevices
    {
        public string GetID()
        {
            return UIDevice.CurrentDevice.IdentifierForVendor.AsString();
        }
    }
}