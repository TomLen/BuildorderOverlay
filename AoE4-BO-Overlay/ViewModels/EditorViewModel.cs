using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using AoE4_BO_Overlay.Views;
using System.Windows.Input;

namespace AoE4_BO_Overlay.ViewModels 
{
    internal class EditorViewModel : Conductor<object>
    {
        private BindableCollection<BuildOrderActionModel> _currendBuildOrder;
        private BuildOrderActionModel _newBuildOrderAction = new BuildOrderActionModel(0, "", 0, "");

        public EditorViewModel()
        {
            CurrendBuildOrder = new BindableCollection<BuildOrderActionModel>(JsonParser.GetBuildOrder().Actions);
        }


        public BindableCollection<BuildOrderActionModel> CurrendBuildOrder
        {
            get
            {

                return _currendBuildOrder;
            }
            set
            {
                _currendBuildOrder = value;
                NotifyOfPropertyChange(() => CurrendBuildOrder);
            }
        }
        public int NewBuildOrderSupply
        {
            get
            {

                return _newBuildOrderAction.Supply;
            }
            set
            {
                _newBuildOrderAction.Supply = value;
                NotifyOfPropertyChange(() => NewBuildOrderSupply);
            }
        }

        public string NewBuildOrderTime
        {
            get
            {

                return _newBuildOrderAction.Time;
            }
            set
            {
                _newBuildOrderAction.Time = value;
                NotifyOfPropertyChange(() => NewBuildOrderTime);
                AddNewEntry();
            }
        }

        public string NewBuildOrderAction
        {
            get
            {

                return _newBuildOrderAction.Action;
            }
            set
            {
                _newBuildOrderAction.Action = value;
                NotifyOfPropertyChange(() => NewBuildOrderAction);
                AddNewEntry();
            }
        }

        public void AddNewEntry()
        {
            if(!string.IsNullOrWhiteSpace(_newBuildOrderAction.Action) && !string.IsNullOrWhiteSpace(_newBuildOrderAction.Time))
            {
                _newBuildOrderAction.Index = _currendBuildOrder.Count();
                _currendBuildOrder.Add(new BuildOrderActionModel(
                        _currendBuildOrder.Count(), 
                        NewBuildOrderTime, 
                        NewBuildOrderSupply, 
                        NewBuildOrderAction
                    ));
                _newBuildOrderAction.Supply = 0;
                _newBuildOrderAction.Action = "";
                _newBuildOrderAction.Time = "";
                NotifyOfPropertyChange(() => NewBuildOrderSupply);
                NotifyOfPropertyChange(() => NewBuildOrderTime);
                NotifyOfPropertyChange(() => NewBuildOrderAction);
                NotifyOfPropertyChange(() => CurrendBuildOrder);
            }
        }
    }
}
