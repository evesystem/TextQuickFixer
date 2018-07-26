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


namespace TextQuickFixer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private StringFixer stringFixer = new StringFixer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_remove_n_r_Click(object sender, RoutedEventArgs e)
        {
            var output=stringFixer.remove_n_r(tb_input.Text);
            tb_output.Text = output;
        }

        private void btn_remove_blanks_Click(object sender, RoutedEventArgs e)
        {
            var output = stringFixer.removeBlanks(tb_input.Text);
            tb_output.Text = output;
        }

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            tb_input.Text = tb_output.Text;
        }

        private void btn_sb_Click(object sender, RoutedEventArgs e)
        {
            tb_output.Text = stringFixer.sb_Append(tb_input.Text);
        }
    }
}
