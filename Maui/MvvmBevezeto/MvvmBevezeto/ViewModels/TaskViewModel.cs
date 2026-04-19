using MvvmBevezeto.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace MvvmBevezeto.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //az ObservableCollectionben már implementálva van az INotifyPropertyChanged interface
        public ObservableCollection<TaskItem> Tasks { get; set; }
        public TaskItem NewTask { get; set; }

        //Command, ami majd futtatni fogja a hozzátartozó metódust, ami az üzleti logikánkat tartalmazza
        public ICommand AddTaskCommand { get; }

        public TaskViewModel()
        {
            Tasks = new ObservableCollection<TaskItem>();
            NewTask = new TaskItem();

            AddTaskCommand = new Command(AddTask);
        }

        public void AddTask()
        {
            if (!string.IsNullOrEmpty(NewTask.Title))
            {
                Tasks.Add(new TaskItem
                {
                    Title = NewTask.Title,
                    Description = NewTask.Description,
                    IsCompleted = false
                });

                NewTask = new TaskItem();
                //mivel itt megváltozik a NewTask (üresre tesszük) ezért kell az OnPropertyChanged eventhandler
                OnPropertyChanged(nameof(NewTask));
            }
        }


    }
}
