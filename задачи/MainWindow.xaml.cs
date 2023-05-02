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

namespace задачи
{
    
    public partial class MainWindow : Window
    {
        List<Tasks> active;
        List<Tasks> inactive;
        List<Tasks> tasks;   
        
        public void Input()
        {
            active = tasks.Where(a => a.Status == false).ToList();
            inactive = tasks.Where(i => i.Status == true).ToList();
            NotCompl.ItemsSource = active;
            Compl.ItemsSource = inactive;

        }
        public MainWindow()
        {
            InitializeComponent();
            tasks = new List<Tasks>()
            {
                new Tasks("Задача", true),
                new Tasks("Задача", false),
             
            };
            Input();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            foreach (var i in NotCompl.SelectedItems)
            {
                tasks.Remove((Tasks)i);
            }
            Input();
        }

        private void Delete2_Click(object sender, RoutedEventArgs e)
        {
            foreach (var i in Compl.SelectedItems)
            {
                tasks.Remove((Tasks)i);
            }
            Input();
        }

      

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            tasks.Add(new Tasks(AddTextBox.Text, false));
            AddTextBox.Clear();
            Input();
        }

        private void NotCompl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddInCompl_Click(object sender, RoutedEventArgs e)
        {
            var ind = tasks.FindIndex(i => i == NotCompl.SelectedItem);
            tasks[ind].Status = true;
            Input();
        }

        private void AddInNotCompl_Click(object sender, RoutedEventArgs e)
        {
            var ind = tasks.FindIndex(i => i == Compl.SelectedItem);
            tasks[ind].Status = false;
            Input();
        }

        private void AddTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
