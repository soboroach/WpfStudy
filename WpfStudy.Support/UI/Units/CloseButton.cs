using System.Windows;
using System.Windows.Controls;

namespace WpfStudy.Support.UI.Units
{

    public class CloseButton : Button
    {
        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton),
                new FrameworkPropertyMetadata(typeof(CloseButton)));
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
