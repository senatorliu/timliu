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

namespace Liu.Droid.Login.KeyinUserName
{
    [Activity(Label = "LiginActivity")]
    public class LiginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.login_loginview);

            var button = FindViewById<Button>(Resource.Id.login_loginview_btnConfirm);
        }
    }
}