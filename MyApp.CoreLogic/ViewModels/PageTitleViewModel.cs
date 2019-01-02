using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.CoreLogic
{
    public class PageTitleViewModel : ViewModel
    {
        string _Title = "";

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                ChangePropertyValue(ref _Title, value);
            }
        }
    }
}
