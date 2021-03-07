using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentSignUp
{
    public partial class MainPage : ContentPage
    {
        Student Sd;
        public MainPage()
        {
            Sd = new Student();
            InitializeComponent();
            BindingContext = Sd;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page p = new RegistrationP2();
            p.BindingContext = this.BindingContext;
            await Navigation.PushAsync(p);
        }
    }
}
