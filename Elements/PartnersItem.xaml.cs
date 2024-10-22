using Bugrina_UP01.Data;
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

namespace Bugrina_UP01.Elements
{
    /// <summary>
    /// Логика взаимодействия для Partners.xaml
    /// </summary>
    public partial class Partners : UserControl
    {
        public Partners(PartnersContext partnersContext)
        {
            InitializeComponent();
            typeLbl.Content = partnersContext.type_partn;
            nameLbl.Content = partnersContext.company_name;
            directorLbl.Content = partnersContext.fio_director;
            phoneLbl.Content = partnersContext.number_phone;
            raytingLbl.Content = partnersContext.rayting;
            saleLbl.Content = partnersContext.skidka + " % ";
        }
    }
}
