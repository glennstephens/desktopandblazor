using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.CoreLogic
{
    public class PageCounterViewModel : ViewModel
    {
        int _ClickedCount = 0;

        public int ClickedCount {
            get
            {
                return _ClickedCount;
            }
            set
            {
                ChangePropertyValue(ref _ClickedCount, value);
            }
        }

        public void IncrementCount()
        {
            ClickedCount += 15;
        }

        public WrappedCommand IncrementCommand { get; set; }

        public PageCounterViewModel()
        {
            IncrementCommand = new WrappedCommand(IncrementCount);
        }
    }
}
