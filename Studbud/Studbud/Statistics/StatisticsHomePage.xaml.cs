﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Studbud.Statistics
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StatisticsHomePage : ContentPage
	{
		public StatisticsHomePage ()
		{
			InitializeComponent ();
            ((StatisticsHomePageViewModel)BindingContext).EndInit();
		}
	}
}