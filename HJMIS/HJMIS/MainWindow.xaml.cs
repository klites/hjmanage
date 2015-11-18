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

using Dos.Model;
using Dos.ORM;
using Dos.ORM.Common;

namespace HJMIS
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ExaminerList = new List<v_Examiner>();

            InitData();
        }

        public List<v_Examiner> ExaminerList;

        private void InitData()
        {
            List<v_Examiner> list = DbSession.Default.From<v_Examiner>().Where(a => a.Sex == "男").ToList();

        }




    }
}
