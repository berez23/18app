﻿using Italia.DiciottoApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Italia.DiciottoApp.ViewModels
{
    class FindShopsViewModel : BaseViewModel
    {
        #region Properties

        public string PageTitle { get; set; } = "Negozi";

        public AppArea AppArea { get; set; } = AppArea.Stores;

        #endregion

        public FindShopsViewModel() : base()
        {

        }

    }
}