﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NetSalaryPT.Core
{
    class RelayCommand : ICommand
    {
        private Action<Object> _execute;
        private Func<Object, bool> _canExecute;
      
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<Object> execute,Func<object,bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
