using System;

namespace MyApp.CoreLogic
{
#if MOBILEORDESKTOP

#else
    public class OnCommandCanExecute : Attribute
    {
        public OnCommandCanExecute(string name)
        {

        }
    }

    public class OnCommand : Attribute
    {
        public OnCommand(string name)
        {

        }
    }
#endif
}
