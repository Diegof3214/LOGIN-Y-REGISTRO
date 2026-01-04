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
using LOGIN_Y_REGISTRO;
using System.Windows.Forms.Integration;

namespace WEB
{
    /// <summary>
    /// Lógica de interacción para Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private readonly Mainform mainform = new Mainform();
        public Page1()
        {
            InitializeComponent();

            WindowsFormsHost whf = new WindowsFormsHost();
            whf.Width = mainform.Width;
            whf.Height = mainform.Height;

            sp.Width = mainform.Width;
            sp.Height = mainform.Height;

            mainform.TopLevel = false;
            whf.Child = mainform;
            sp.Children.Add(whf);
        }
    }
}
