using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo092023A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direction = e.Direction.ToString();

            if (direction == "Right")
                ((BoxView)sender).BackgroundColor = Color.Purple;
            if (direction == "Left")
                ((BoxView)sender).BackgroundColor = Color.Red;
            if (direction == "Up")
                ((BoxView)sender).BackgroundColor = Color.Black;
            if (direction == "Down")
                ((BoxView)sender).BackgroundColor = Color.Blue;

            _label.Text = $"You siped: {e.Direction.ToString()}";
        }
    }
}