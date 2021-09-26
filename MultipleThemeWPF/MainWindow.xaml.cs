using MultipleThemeWPF.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultipleThemeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Properties.Settings.Default.CurrentTheme.Equals(ThemeSelectorCB.SelectedValue))
            {
                var app = (App)Application.Current;

                switch (ThemeSelectorCB.SelectedIndex)
                {
                    case 1:
                        //Change Theme to Flat style
                        app.ChangeTheme(new Uri("/Styles/FlatStyle.xaml",
                            UriKind.RelativeOrAbsolute));
                        //save to settings
                        Settings.Default.CurrentTheme = "Flat";
                        Settings.Default.Save();
                        break;

                    case 2:
                        //Change Theme to Flat style
                        app.ChangeTheme(new Uri("/Styles/ModernStyle.xaml",
                            UriKind.RelativeOrAbsolute));
                        //save to settings
                        Settings.Default.CurrentTheme = "Modern";
                        Settings.Default.Save();
                        break;

                    default:
                        //Change Theme to Flat style
                        app.ChangeTheme(new Uri("/Styles/DefaultStyle.xaml",
                            UriKind.RelativeOrAbsolute));
                        //save to settings
                        Settings.Default.CurrentTheme = "Default";
                        Settings.Default.Save();
                        break;
                }
            }
        }
    }
}