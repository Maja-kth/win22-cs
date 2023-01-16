using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_MVVM.MVVM.Models;
using WpfApp_MVVM.Services;

namespace WpfApp_MVVM.MVVM.ViewModels
{
    public partial class AddTodoViewModel : ObservableObject
    {
        private readonly FileService fileService;
        public AddTodoViewModel()
        {
            fileService = new FileService();
        }

        [ObservableProperty]
        private string pageTitle = "Add Todos";

        [ObservableProperty]
        private string todo = string.Empty;

        [RelayCommand]
        private void Add()
        {
            fileService.AddToList(new TodoModel { Text = Todo });
            Todo = string.Empty;
        }
    }
}
