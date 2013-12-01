using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace HybridApp
{
	[Activity (Label = "HybridApp", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			RequestWindowFeature (WindowFeatures.NoTitle);
			SetContentView (Resource.Layout.Main);
			var myWebView = FindViewById<WebView> (Resource.Id.SampleWebView);
			myWebView.SetWebViewClient (new CustomWebViewClient ());
			myWebView.LoadUrl ("http://www.dotnetthoughts.net");
			myWebView.Settings.JavaScriptEnabled = true;
		}

		private class CustomWebViewClient : WebViewClient
		{
			public override bool ShouldOverrideUrlLoading 
			(WebView view, string url)
			{
				view.LoadUrl (url);
				return true;
			}
		}
	}
}


