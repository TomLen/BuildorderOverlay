using AoE4_BO_Overlay.ViewModels;
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
using System.Windows.Shapes;

namespace AoE4_BO_Overlay.Views
{
    /// <summary>
    /// Interaction logic for BuildOrderPickerView.xaml
    /// </summary>
    public partial class BuildOrderPickerView : Window
    {
        public BuildOrderPickerView()
        {
            DataContext = new BuildOrderPickerViewModel();
            InitializeComponent();
        }
    }
}
