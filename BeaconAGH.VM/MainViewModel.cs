﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace BeaconAGH.VM
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel(IMessenger messenger) : base(messenger)
        {
        }
    }
}
