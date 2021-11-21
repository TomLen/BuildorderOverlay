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
        private BindableCollection<BuildOrderActionModel> _buildOrder = new BindableCollection<BuildOrderActionModel>(JsonParser.GetBuildOrder().Actions);

        public ShellViewModel()
        {
        }

        public int SupplyOne
        {
            get
            {
                return _buildOrder[0].Supply;
            }
        }
        public int TimeOne
        {
            get
            {
                return _buildOrder[0].Time;
            }
        }
        public string ActionOne
        {
            get
            {
                return _buildOrder[0].Action;
            }
        }

        public int SupplyTwo
        {
            get
            {
                return _buildOrder[1].Supply;
            }
        }
        public int TimeTwo
        {
            get
            {
                return _buildOrder[1].Time;
            }
        }
        public string ActionTwo
        {
            get
            {
                return _buildOrder[1].Action;
            }
        }

        public int TimeThree
        {
            get
            {
                return _buildOrder[2].Time;
            }
        }
        public int SupplyThree
        {
            get
            {
                return _buildOrder[2].Supply;
            }
        }
        public string ActionThree
        {
            get
            {
                return _buildOrder[2].Action;
            }
        }

        public int TimeFour
        {
            get
            {
                return _buildOrder[3].Time;
            }
        }
        public int SupplyFour
        {
            get
            {
                return _buildOrder[3].Supply;
            }
        }
        public string ActionFour
        {
            get
            {
                return _buildOrder[3].Action;
            }
        }

        public int TimeFive
        {
            get
            {
                return _buildOrder[4].Time;
            }
        }
        public int SupplyFive
        {
            get
            {
                return _buildOrder[4].Supply;
            }
        }
        public string ActionFive
        {
            get
            {
                return _buildOrder[4].Action;
            }
        }

        public int TimeSix
        {
            get
            {
               if(_buildOrder.Count > 5) { return _buildOrder[5].Time; }
                return null;
            }
        }
        public int SupplySix
        {
            get
            {
                return _buildOrder[5].Supply;
            }
        }
        public string ActionSix
        {
            get
            {
                return _buildOrder[5].Action;
            }
        }
        
        public int TimeSeven
        {
            get
            {
                return _buildOrder[6].Time;
            }
        }
        public int SupplySeven
        {
            get
            {
                return _buildOrder[6].Supply;
            }
        }
        public string ActionSeven
        {
            get
            {
                return _buildOrder[6].Action;
            }
        }

        public int TimeEight
        {
            get
            {
                return _buildOrder[7].Time;
            }
        }
        public int SupplyEight
        {
            get
            {
                return _buildOrder[7].Supply;
            }
        }
        public string ActionEight
        {
            get
            {
                return _buildOrder[7].Action;
            }
        }
        public int TimeNine
        {
            get
            {
                return _buildOrder[8].Time;
            }
        }
        public int SupplyNine
        {
            get
            {
                return _buildOrder[8].Supply;
            }
        }
        public string ActionNine
        {
            get
            {
                return _buildOrder[8].Action;
            }
        }

        public int TimeTen
        {
            get
            {
                return _buildOrder[9].Time;
            }
        }
        public int SupplyTen
        {
            get
            {
                return _buildOrder[9].Supply;
            }
        }
        public string ActionTen
        {
            get
            {
                return _buildOrder[9].Action;
            }
        }

        public int TimeEleven
        {
            get
            {
                return _buildOrder[10].Time;
            }
        }
        public int SupplyEleven
        {
            get
            {
                return _buildOrder[10].Supply;
            }
        }
        public string ActionEleven
        {
            get
            {
                return _buildOrder[10].Action;
            }
        }

        public int TimeTwelve
        {
            get
            {
                return _buildOrder[10].Time;
            }
        }
        public int SupplyTwelve
        {
            get
            {
                return _buildOrder[10].Supply;
            }
        }
        public string ActionTwelve
        {
            get
            {
                return _buildOrder[10].Action;
            }
        }
        public bool CanClearText(string firstName, string lastName)
        {
            return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
        }

        public void ClearText(string firstName, string lastName)
        {
            //FirstName = "";
            //LastName = "";
        }

        public void LoadPageOne()
        {
            //ActivateItemAsync(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
           // ActivateItemAsync(new SecondChildViewModel());
        }



    }
}
