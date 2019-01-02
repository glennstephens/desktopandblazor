using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace MyApp.CoreLogic
{
#if MOBILEORDESKTOP
    public class ViewModel : INotifyPropertyChanged
#else
    public class ViewModel
#endif
    {
        protected void NotifyPropertyChange(params string[] propertyName)
        {
            foreach (var property in propertyName)
            {
                RaisePropertyChanged(property);
            }
        }

#if (MOBILEORDESKTOP)

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool ChangePropertyValue<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);

                return true;
            }

            return false;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
#else
        protected bool ChangePropertyValue<T>(ref T field, T value)
        {
            if (!Equals(field, value))
            {
                field = value;
                return true;
            }

            return false;
        }

        protected void RaisePropertyChanged(string propertyName)
        {
        }
#endif
    }

    public class WrappedCommand : ICommand
    {
        private readonly Action methodToCall;

        public WrappedCommand(Action methodToCall)
        {
            this.methodToCall = methodToCall;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            methodToCall.Invoke();
        }
    }
}
