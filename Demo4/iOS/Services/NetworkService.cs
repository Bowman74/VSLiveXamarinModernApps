using System;
using System.Collections.Generic;
using System.Text;
using XamarinMALDemo.Interfaces;

namespace XamarinMALDemo.iOS.Services
{
    public class NetworkService : INetworkService
    {
        public bool HasNetworkConnection()
        {
            return true;
        }
    }
}
