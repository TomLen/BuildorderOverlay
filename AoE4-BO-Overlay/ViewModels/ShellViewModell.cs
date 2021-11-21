using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Caliburn.Micro;

namespace AoE4_BO_Overlay.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public BindableCollection<BuildOrderActionModel> BuildOrder { get; set; }

        public ShellViewModel()
        {

            BuildOrder = new BindableCollection<BuildOrderActionModel>(JsonParser.GetBuildOrder().Actions);
        }
    }
}
