﻿using Italia.DiciottoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Italia.DiciottoApp.ViewModels
{
    class NearToYouShopsViewModel: BaseViewModel
    {
        #region Properties

        public string PageTitle { get; set; } = "Negozi";

        public AppArea AppArea { get; set; } = AppArea.Stores;

        #endregion

        public NearToYouShopsViewModel() : base()
        {
           
        }

    }
}
