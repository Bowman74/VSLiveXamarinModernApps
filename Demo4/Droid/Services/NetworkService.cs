﻿using System;
using XamarinMALDemo.Interfaces;
using Android.Net;
using Android.App;
using Android.Content;

namespace XamarinMALDemo.Droid.Services
{
    public class NetworkService : INetworkService
    {
        public NetworkService()
        {
        }
            
        public bool HasNetworkConnection()
        {
            ConnectivityManager connectivityManager = (ConnectivityManager)Application.Context.GetSystemService(Context.ConnectivityService);
            NetworkInfo activeConnection = connectivityManager.ActiveNetworkInfo;
            return (activeConnection != null) && activeConnection.IsConnected;
        }
    }
}