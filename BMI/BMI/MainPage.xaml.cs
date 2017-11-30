using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender,EventArgs e)
        {
            Double w = Double.Parse(weight.Text);

            Double h = Double.Parse(height.Text);

            if (h >= 3)
            {
                h /= 100;
            }

            double bmi2 = w / h / h;

            if (bmi2 < 18.5)
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で低体重(痩せ型)です", "OK");
            }
            else if (bmi2 < 25)
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で普通体重です", "OK");
            }
            else if (bmi2 < 30)
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で肥満(1度)です", "OK");
            }
            else if (bmi2 < 35)
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で肥満(2度)です", "OK");
            }
            else if (bmi2 < 40)
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で肥満(3度)です", "OK");
            }
            else
            {
                DisplayAlert("BMI", bmi2.ToString() + "　で肥満(4度)です", "OK");
            }

        }
	}
}