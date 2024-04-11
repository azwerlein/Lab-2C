using AwsomeApp;

namespace Lab2C;

public partial class MainPage : ContentPage
{
    private bool _spaceOnePressed = false;
    private bool _spaceTwoPressed = false;
    private string _wordOne = "";
    private string _wordTwo = "";

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnDotOneClicked(object sender, EventArgs e)
    {
        SelectedCharacterOne.Text = _wordOne + ".";
        _spaceOnePressed = false;
    }

    private void OnDashOneClicked(object sender, EventArgs e)
    {
        SelectedCharacterOne.Text = _wordOne + "-";
        _spaceOnePressed = false;
    }

    private void OnSpaceOneClicked(object sender, EventArgs e)
    {
        if (_spaceOnePressed)
        {
            char text = Morse.MorseCoder(SelectedCharacterOne.Text);
            OutputOne.Text += text;
            _spaceOnePressed = false;
            SelectedCharacterOne.Text = _wordOne = "";
        }
        else
        {
            _wordOne = SelectedCharacterOne.Text;
            _spaceOnePressed = true;
        }
    }
    
    private void OnDotTwoClicked(object sender, EventArgs e)
    {
        SelectedCharacterTwo.Text = _wordTwo + ".";
        _spaceTwoPressed = false;
    }

    private void OnDashTwoClicked(object sender, EventArgs e)
    {
        SelectedCharacterTwo.Text = _wordTwo + "-";
        _spaceTwoPressed = false;
    }

    private void OnSpaceTwoClicked(object sender, EventArgs e)
    {
        if (_spaceTwoPressed)
        {
            char text = Morse.MorseCoder(SelectedCharacterTwo.Text);
            OutputTwo.Text += text;
            _spaceTwoPressed = false;
            SelectedCharacterTwo.Text = _wordTwo = "";
        }
        else
        {
            _wordTwo = SelectedCharacterTwo.Text;
            _spaceTwoPressed = true;
        }
    }
}