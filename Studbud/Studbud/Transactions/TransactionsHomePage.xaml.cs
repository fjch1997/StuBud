﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Studbud.Transactions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TransactionsHomePage : ContentPage
	{
		public TransactionsHomePage ()
		{
			InitializeComponent();
		}
        protected override void OnAppearing()
        {
            ((TransactionsHomePageViewModel)BindingContext).RefreshTransactionsCommand.Execute(null);
            base.OnAppearing();
        }
    }
}