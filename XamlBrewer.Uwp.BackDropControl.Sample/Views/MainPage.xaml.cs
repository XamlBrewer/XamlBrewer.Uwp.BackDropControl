﻿using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace XamlBrewer.Uwp.BackDropControl.Sample
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TintColorSlider_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            if (e.NewValue < 1)
            {
                BackDrop.TintColor = Colors.Transparent;
            }
            else
            {
                var color = (byte)(e.NewValue * 2.55);
                BackDrop.TintColor = Color.FromArgb(90, color, (byte)(255 - color), (byte)(255 - color));
            }
        }

        //private void TintAlphaSlider_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        //{
        //    BackDrop.TintAlpha = (byte) e.NewValue;
        //}
    }
}
