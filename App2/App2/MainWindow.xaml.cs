using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App2
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ItemList.Loaded += ItemList_Loaded;

            PopulateData();
        }
        private IList<Person> _family { get; set; }
        private bool _isLoaded = false;
        private void ItemList_Loaded(object sender, RoutedEventArgs e)
        {
            var listView = (ListView)sender;
            PopulateData();
            listView.ItemsSource = _family;
        }
        public void PopulateData()
        {
            if (_isLoaded)
            {
                return;
            }
            _isLoaded = true;

            var me = new Person
            {
                FirstName = "Matt",
                LastName = "Gradwohl",
                Birthday = new DateTime(1970, 5, 12)
            };

            var wifey = new Person
            {
                FirstName = "Alexis",
                LastName = "Gradwohl",
                Birthday = new DateTime(1979, 1, 2)
            };

            var hayney = new Person
            {
                FirstName = "Hayden",
                LastName = "Gradwohl",
                Birthday = new DateTime(2007, 3, 14)
            };
            var fifi = new Person
            {
                FirstName = "Katie",
                LastName = "Blackburn",
                Birthday = new DateTime(1990, 6, 5)

            };
            var jefe = new Person
            {
                FirstName = "Jeff",
                LastName = "Blackburn",
                Birthday = new DateTime(1972, 10, 2)

            };
            var kevin = new Person
            {
                FirstName = "Sullivan",
                LastName = "Blackburn",
                Birthday = new DateTime(2071, 8, 11)
            };

            _family = new List<Person>
            {
                me,
                wifey,
                hayney,
                fifi,
                jefe,
                kevin
            };
        }
    }

}
