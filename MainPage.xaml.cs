namespace MAUIApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void ImageButtonClick(object sender, EventArgs e)
        {
            
            if (one.Source == one.Source)
            {
                one.Source = "reality_1.jpg";
            }
            else 
            {
                one.Source = "expectation_1.jpg";
            }
        }
        private void ImageButtonClick2(object sender, EventArgs e) 
        {
            if (two.Source == two.Source)
            {
                two.Source = "reality_2.jpg";
            }
            else
            {
                two.Source = "expectation_2.jpg";
            }  
        } 
    }
}