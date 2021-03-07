using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StudentSignUp
{
    public partial class RegistrationP2 : ContentPage
    {
       
        public RegistrationP2()
        {
           
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Page p = new RegistrationP3();
            p.BindingContext = this.BindingContext;
            await Navigation.PushAsync(p);
        }
    }
}
