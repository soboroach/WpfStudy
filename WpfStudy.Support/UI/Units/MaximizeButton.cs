﻿using System.Windows;
using System.Windows.Controls;

namespace WpfStudy.Support.UI.Units
{

    public class MaximizeButton : Button
    {
        static MaximizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MaximizeButton),
                new FrameworkPropertyMetadata(typeof(MaximizeButton)));
        }
    }
}
