using Android.App;
using Android.Content.Res;
using Android.Util;
using Android.Widget;

namespace StringWidthCalculator
{
    public class StringWidthCalculator
    {

        public double CalculateStringWidth(string str, double fontSize)
        {
            var textView = new TextView(Application.Context);
            textView.SetTextSize(ComplexUnitType.Sp, (float)fontSize);
            var widthOfPixel = textView.Paint.MeasureText(str);
            return widthOfPixel / Resources.System.DisplayMetrics.Density;
        }

        public double CalculateStringWidthDP(string str, double fontSize)
        {
            var textView = new TextView(Application.Context);
            textView.SetTextSize(ComplexUnitType.Dip, (float)fontSize);
            var widthOfPixel = textView.Paint.MeasureText(str);
            return widthOfPixel / Resources.System.DisplayMetrics.Density;
        }
    }
}
