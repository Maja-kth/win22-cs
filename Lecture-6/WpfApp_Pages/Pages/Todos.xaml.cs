using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp_Pages.Models;
using WpfApp_Pages.Services;

namespace WpfApp_Pages.Pages
{
    /// <summary>
    /// Interaction logic for Todos.xaml
    /// </summary>
    public partial class Todos : Page
    {
        private readonly FileService fileService;

        public Todos()
        {
            InitializeComponent();
            fileService = new FileService();
            lv_Todos.ItemsSource = fileService.Todos();
        }

    }
}
