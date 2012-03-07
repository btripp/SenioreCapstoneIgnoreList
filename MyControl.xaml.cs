using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AugustaStateUniversity.SeniorCapstoneIgnoreList
{
    /// <summary>
    /// Interaction logic for MyControl.xaml
    /// </summary>
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]

        private void ignoreListAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ignoreListTextBox.Text != "")
            {
                string file;
                ignoreList.Items.Add(ignoreListTextBox.Text);
                file = ignoreListTextBox.Text;
                ignoreListTextBox.Clear();
                MessageBox.Show("\"" + file + "\"" + " was added to the ignore list", "File Added");
            }
            else
            {
                MessageBox.Show("You must enter something in the textbox.", "Nothing Added");
            }
        
        }
    }
}