using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PlanIt
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            placeComponents();
        }

        private void placeComponents()
        {
            // Logo Image
            loginLayout.Children.Add(loginLogoImage,
                Constraint.RelativeToParent((parent) =>
            {
                return (parent.Width - getLogoSize(parent)) / 2.0;
            }), Constraint.RelativeToParent((parent) =>
            {
                return parent.Height * 0.2;
            }), Constraint.RelativeToParent((parent) =>
            {
                return getLogoSize(parent);
            }), Constraint.RelativeToParent((parent) =>
            {
                return getLogoSize(parent);
            }));
        }

        private double getLogoSize(RelativeLayout layout)
        {
            return Math.Min(layout.Width * 0.4, layout.Height * 0.2);
        }
    }
}