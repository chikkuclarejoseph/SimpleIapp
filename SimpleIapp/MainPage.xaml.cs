using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleIapp
{
    public partial class MainPage : ContentPage
    {
        float y, p, i, a;
      
       
        public MainPage()
        {
           
            InitializeComponent();
            
            calcButton.Clicked += CalcButton_Clicked;
         
            clearButton.Clicked += ClearButton_Clicked;
      



        }

       private void ClearButton_Clicked(object sender, EventArgs e)
       {
            EditorPrincipalAmount.Text = "";
            EditorYear.Text = "";
            EditorInterestRate.Text = "";
            Editoramount.Text = "";

}

      private void CalcButton_Clicked(object sender, EventArgs e)
       {

            p = float.Parse(EditorPrincipalAmount.Text);
            y = float.Parse(EditorYear.Text);
            i = float.Parse(EditorInterestRate.Text);
            //a = float.Parse(Editoramount.Text);

            a = (p * y * i) / 100;
            Editoramount.Text =a.ToString();
            
        }
    }
}

