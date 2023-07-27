using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.InstalledApp(@"C:\Users\david\AppData\Local\Xamarin\Mono for Android\Archives\2023-01-15\Practica3.Android 1-15-23 10.41 PM.apkarchive\com.companyname.practica3.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}