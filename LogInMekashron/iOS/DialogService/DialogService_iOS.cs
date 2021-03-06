﻿using LogInMekashron.Dialog;
using Xamarin.Forms;
using UIKit;
using System;

[assembly: Dependency(typeof(LogInMekashron.iOS.DialogService.DialogService_iOS))]
namespace LogInMekashron.iOS.DialogService
{
    public class DialogService_iOS : IDialogService
    {
        public void ShowMessage(string Message)
        {
            UIAlertView alert = new UIAlertView()
            {
                Title = "Authenticate message",
                Message = Message,
            };
            alert.AddButton("OK");
            nfloat r = 1, g = 0, b = 0, alpha = 1;
            alert.TintColor.GetRGBA(out r, out g, out b, out alpha); //= UIColor.Red;
            alert.BackgroundColor = UIColor.Red;
            alert.Show();
        }
    }
}
