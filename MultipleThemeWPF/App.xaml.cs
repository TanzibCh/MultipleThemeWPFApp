using MultipleThemeWPF.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MultipleThemeWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Select first dictionary
        private ResourceDictionary ThemeDictionary => Resources.MergedDictionaries[0];

        public App()
        {
            InitializeComponent();

            switch (Settings.Default.CurrentTheme)
            {
                case "Flat":
                    //Change Theme to Flat style
                    ChangeTheme(new Uri("/Styles/FlatStyle.xaml",
                        UriKind.RelativeOrAbsolute));
                    //save to settings
                    Settings.Default.CurrentTheme = "Flat";
                    Settings.Default.Save();
                    break;

                case "Modern":
                    //Change Theme to Flat style
                    ChangeTheme(new Uri("/Styles/ModernStyle.xaml",
                        UriKind.RelativeOrAbsolute));
                    //save to settings
                    Settings.Default.CurrentTheme = "Modern";
                    Settings.Default.Save();
                    break;

                default:
                    //Change Theme to Flat style
                    ChangeTheme(new Uri("/Styles/DefaultStyle.xaml",
                        UriKind.RelativeOrAbsolute));
                    //save to settings
                    Settings.Default.CurrentTheme = "Default";
                    Settings.Default.Save();
                    break;
            }
        }

        public void ChangeTheme(Uri uri)
        {
            ThemeDictionary.MergedDictionaries.Clear();
            ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary() { Source = uri });
        }
    }
}