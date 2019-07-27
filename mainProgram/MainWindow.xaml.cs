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
            TreeViewItem item1 = new TreeViewItem() { Header = "节点一" };
            TreeViewItem item11 = new TreeViewItem() { Header = "节点1-1" };
            item11.Items.Add("aaaa");
            item11.Items.Add("bbbb");
            item11.Items.Add("cccc");
            item11.Items.Add("dddd");


            item1.Items.Add(item11);
            item1.Items.Add("cccc");
            item1.Items.Add("dddd");

            TreeViewItem item2 = new TreeViewItem() { Header = "节点二" };
            item2.Items.Add("aaaa");
            item2.Items.Add("bbbb");
            item2.Items.Add("cccc");
            item2.Items.Add("dddd");
            treeViewTotalProb.Items.Add(item1);
            treeViewTotalProb.Items.Add(item2);
        }
    }
}
