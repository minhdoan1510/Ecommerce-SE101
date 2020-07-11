﻿using ECommerce_GUI.Helper;
using FlightTicketManagement.Helper;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ECommerce_GUI.Login
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public class SignUpAPI
    {
        private static SignUpAPI _Instance;

        public static SignUpAPI Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SignUpAPI();
                return _Instance;
            }
        }

        public async Task<bool> signUp(Account profile)
        {
            Response<object> responsce = await APIHelper.Instance.Post<Response<object>>
                (ApiRoutes.Account.signup, profile);
            return responsce.IsSuccess;
        }
    }

    public partial class SignUp : UserControl
    {
        public SignUp() {
            InitializeComponent();
        }

        private async void signup_Click(object sender, RoutedEventArgs e)
        {
            Account newUser = new Account();

            newUser.Name = name.Text;
            newUser.userName = username.Text;
            newUser.password = password.Password.ToString();
            newUser.phoneNum = phoneNumer.Text;
            newUser.Address = address.Text;
            newUser.email = email.Text;

            if (isBuyer.IsChecked == true) newUser.type = 1;
            else if (isSeller.IsChecked == true) newUser.type = 2;

            if (await SignUpAPI.Instance.signUp(newUser))
            {
                MainWindow.Instance.showLogin();
            }
            else
            {
                MessageBox.Show("sign up failed"); 
            }
        }

        private void backToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.showLogin();
        }

        private void isSeller_Checked(object sender, RoutedEventArgs e)
        {
            if (isBuyer.IsChecked == true)
            {
                isBuyer.IsChecked = false;
            }
        }

        private void isSeller_Unchecked(object sender, RoutedEventArgs e)
        {
            if (isBuyer.IsChecked == false)
            {
                isSeller.IsChecked = true;
                e.Handled = true; 
            }
        }

        private void isBuyer_Checked(object sender, RoutedEventArgs e)
        {
            if (isSeller.IsChecked == true)
            {
                isSeller.IsChecked = false;
            }
        }

        private void isBuyer_Unchecked(object sender, RoutedEventArgs e)
        {
            if (isSeller.IsChecked == false)
            {
                isBuyer.IsChecked = true;
                e.Handled = true;
            }
        }
    }
}
