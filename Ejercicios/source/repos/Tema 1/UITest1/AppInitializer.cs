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
                return ConfigureApp.Android.ApkFile(@"C:\Users\david\AppData\Local\Xamarin\Mono for Android\Archives\2023-01-22\App3.Android 1-22-23 8.25 PM.apkarchive\com.companyname.app3.apk").StartApp();
            }

            return ConfigureApp.iOS.StartApp();
        }
    }
}