using System;
using System.Collections.Generic;
using System.IO;
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

namespace mainProgram
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            loadDirectoryInfo();
        }


        //菜单栏保存点击
        private void mnuSaveDoc_Click(object sender, RoutedEventArgs e)
        {

        }
        //菜单栏另存为点击
        private void mnuSaveAsDoc_Click(object sender, RoutedEventArgs e)
        {

        }
        //菜单栏编辑点击
        private void mnuEditDoc_Click(object sender, RoutedEventArgs e)
        {

        }
        //添加日期
        private void btnAddDate_Click(object sender, RoutedEventArgs e)
        {

        }
        //添加问题
        private void btnAddProm_Click(object sender, RoutedEventArgs e)
        {

        }
        //选择中日期
        private void datePickerProm_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            tbAddContent.Text = Convert.ToDateTime(datePickerProm.Text).ToString("yyyyMMdd");
        }
        //加载数据到treeView
        private void loadDirectoryInfo()
        {
            DirectoryInfo directoryInfo=new DirectoryInfo(@"data");

            foreach (var directory in directoryInfo.GetDirectories())
            {
                TreeViewItem item=new TreeViewItem() {Header = directory.Name};
                treeViewTotalProb.Items.Add(item);
            }
            tbAddContent.Text = directoryInfo.GetDirectories().First().Name;
        }
    }
}
