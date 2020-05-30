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
using Autofac;
using NewDemo.Services.IServices;

namespace NewDemo.Droid.FirebaseAndroid
{
    class DroidModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<FirebaseAuthenticator>().As<IFirebaseAuthenticator>().SingleInstance();
		}
	}
}