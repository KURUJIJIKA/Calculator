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

namespace калькулятор
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRaschet_Click(object sender, RoutedEventArgs e)
        {


            int oklad = Convert.ToInt32(txtOklad.Text);
            int o_day = Convert.ToInt32(txtOtrab_day.Text);
            int r_day = Convert.ToInt32(txtRab_day.Text);
            int premia = Convert.ToInt32(txtPremia.Text);

            double kof = 0;

            if (rbtKof12.IsChecked == true)
            {
                kof = 0.12;
            }
            if (rbtKof13.IsChecked == true)
            {
                kof = 0.13;
            }
            if (rbtKof14.IsChecked == true)
            {
                kof = 0.14;
            }
            if (rbtKof15.IsChecked == true)
            {
                kof = 0.15;
            }


            if (o_day <= r_day)
            {
                if (r_day < 0 || r_day > 32)
                {
                    MessageBox.Show("Отработанные дни должны быть в промежутке 1-31", "");

                }
                else
                {
                    if (o_day < 0 || o_day > 32)
                    {
                        MessageBox.Show("Рабочие дни не   ");
                    }
                    else
                    {
                        double poln_ZP = oklad * kof * o_day / r_day + premia;
                        txtPolnayZP.Text = $"{poln_ZP}";

                        double ndfl = poln_ZP * 0.13;
                        txtNDFL.Text = $"{ndfl}";

                        double zp = poln_ZP - ndfl;
                        txtZp_na_ruki.Text = $"{zp}";

                    }


                }
            }
            else MessageBox.Show("Ты не можешь работать больше указанного времени!!!");
        }
        private void btmClear_Click(object sender, RoutedEventArgs e)
        {
            txtNDFL.Text = "";
            txtOklad.Text = "";
            txtOtrab_day.Text = "";
            txtPolnayZP.Text = "";
            txtPremia.Text = "";
            txtRab_day.Text = "";
            txtZp_na_ruki.Text = "";
            

        }

        private void txtRab_day_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
            
    }
}
