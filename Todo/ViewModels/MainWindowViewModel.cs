﻿using System;
using System.Collections.Generic;
using System.Text;
using Todo.Services;

namespace Todo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
        {
            List = new TodoListViewModel(db.GetItems());
        }

        public TodoListViewModel List { get; }
        //public string Greeting => "Welcome to Avalonia!";
    }
}
