using Android.App;
using Android.Widget;
using Android.OS;

namespace StringWidthCalculator
{
    [Activity(Label = "StringWidthCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText EditString { get; set; }
        EditText EditFontSize { get; set; }
        Button CalculateButton { get; set; }
        TextView ResultTextView { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            EditString = FindViewById<EditText>(Resource.Id.editString);
            EditFontSize = FindViewById<EditText>(Resource.Id.editFontSize);
            CalculateButton = FindViewById<Button>(Resource.Id.calculate);
            ResultTextView = FindViewById<TextView>(Resource.Id.result);

            CalculateButton.Click += (sender, e) => {
                var str = EditString.Text;
                var fontSize = double.Parse(EditFontSize.Text);
                var calculator = new StringWidthCalculator();
                var widthSp = calculator.CalculateStringWidth(str, fontSize);
                var widthDp = calculator.CalculateStringWidthDP(str, fontSize);
                ResultTextView.Text = $"width(SP): {widthSp}\nwidth(DP): {widthDp}";
            };
        }
    }
}

