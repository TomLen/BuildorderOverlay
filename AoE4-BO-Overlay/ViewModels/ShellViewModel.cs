using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Caliburn.Micro;
using AoE4_BO_Overlay.Views;

namespace AoE4_BO_Overlay.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        public BindableCollection<BuildOrderActionModel> BuildOrder { get; set; }

        public ShellViewModel()
        {
            JsonParser.readBuildorderNames();
            BuildOrder = new BindableCollection<BuildOrderActionModel>(JsonParser.GetBuildOrder("generated.json").Actions);
        }

        public void CreateBO_Click(object sender, RoutedEventArgs e)
        {
            EditorView createBO = new EditorView();
            ActivateItemAsync(new EditorViewModel());
            createBO.Show();
        }

        public void ShowBO_Click(object sender, RoutedEventArgs e)
        {
            JsonParser.readBuildorderNames();
        }
    }
}
