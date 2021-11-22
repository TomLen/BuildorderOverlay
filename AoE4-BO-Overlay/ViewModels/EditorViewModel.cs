using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using AoE4_BO_Overlay.Views;

namespace AoE4_BO_Overlay.ViewModels 
{
    internal class EditorViewModel : Conductor<object>
    {
        private string _firstName = "Tom";
        public BindableCollection<BuildOrderActionModel> CurrendBuildOrder { get; set; }
        public EditorViewModel()
        {
            CurrendBuildOrder = new BindableCollection<BuildOrderActionModel>(JsonParser.GetBuildOrder().Actions);
        }

        public string FirstName
        {
            get
            {

                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
            }
        }
    }
}
