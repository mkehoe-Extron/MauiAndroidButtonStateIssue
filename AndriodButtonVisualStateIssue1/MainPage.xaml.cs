namespace AndriodButtonVisualStateIssue1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (button.IsEnabled)
        {
            button.Text = $"Button State = Disabled";
            button.IsEnabled = !button.IsEnabled;
        }
        else
        {
            button.Text = $"Button State = Enabled";
            button.IsEnabled = !button.IsEnabled;
        }

    }
}

