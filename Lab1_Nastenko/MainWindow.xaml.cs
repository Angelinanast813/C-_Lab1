using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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
using Calendar = System.Windows.Controls.Calendar;

namespace Lab01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,  INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainWindow()
        {
            InitializeComponent();
            
    }

        public DateTime date;
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModelFunc f = new ModelFunc();
           
            date = Convert.ToDateTime(datePicker1.SelectedDate);
            
            textBox1.Text = f.Age(date).ToString();
        }

       private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ModelFunc f = new ModelFunc();

            date = Convert.ToDateTime(datePicker1.SelectedDate);

            textBox1.Text = f.Age(date).ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ModelFunc f1 = new ModelFunc();
            date = Convert.ToDateTime(datePicker1.SelectedDate);
            textBox3.Text = f1.EastZodiac(date);
        }

        private void Button2_Click2(object sender, RoutedEventArgs e)
        {
            ModelFunc f1 = new ModelFunc();
            date = Convert.ToDateTime(datePicker1.SelectedDate);
                if(date == null)
            {
               
              MessageBox.Show("You haven't entered date!");
            }
                textBox3.Text = f1.EastZodiac(date);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            ModelFunc f2 = new ModelFunc();
            date = Convert.ToDateTime(datePicker1.SelectedDate);
            textBox2.Text = f2.Chinese(date);
        }

        private void Button3_Click3(object sender, RoutedEventArgs e)
        {
            ModelFunc f2 = new ModelFunc();
            date = Convert.ToDateTime(datePicker1.SelectedDate);
            textBox2.Text = f2.Chinese(date);
        }

    }
}
         

