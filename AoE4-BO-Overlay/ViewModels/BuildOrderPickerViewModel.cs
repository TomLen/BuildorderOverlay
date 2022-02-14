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
        private BindableCollection<string> _names = new BindableCollection<string>();

        public BuildOrderPickerViewModel()
        {
            BuildOrderCollaction.UpdatebuildOrders();

        }

        public BindableCollection<string> Names{
            get {
                return _names;
            }
        }

        private BindableCollection<string> BuildOrderNames()
        {
            _names.Clear();
            foreach (var name in _buildOrders)
            {
                _names.Add(name.Name);
            }
            return _names;
        }
    }
}
