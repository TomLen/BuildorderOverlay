using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using AoE4_BO_Overlay.Views;
using System.Windows.Input;
using AoE4_BO_Overlay.Models;

namespace AoE4_BO_Overlay.ViewModels
{
    internal class BuildOrderPickerViewModel : Conductor<object>
    {
        private BindableCollection<BuildOrderModel> _buildOrders = new BindableCollection<BuildOrderModel>(BuildOrderCollaction._buildOrders);
        public BuildOrderPickerViewModel()
        {
            BuildOrderCollaction.UpdatebuildOrders();

        }

        public List<string> GetBOName {
            get {
                return OnlyBoNames();
            }
        }

        private List<string> OnlyBoNames()
        {
            var names = new List<string>();
            foreach (var name in _buildOrders)
            {
                names.Add(name.Name);
            }
            return names;
        }
    }
}
