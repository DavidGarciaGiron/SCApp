using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SCApp
{
    public static class Constants
    {
        // The iOS simulator can connect to localhost. However, Android emulators must use the 10.0.2.2 special alias to your host loopback interface.
        public static String BaseAdrress = Device.RuntimePlatform == Device.Android ? "http://18.234.118.22:5000" : "http://localhost:5000";
        public static string usuarioUrl = BaseAdrress + "/api/usuario";
    }
}
