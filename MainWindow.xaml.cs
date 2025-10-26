using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using App1.DataAccess;
using App1.Model;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public class MainViewModel
        {
            // Dùng để thông báo khi thêm / xóa phần tử trong danh sách
            public ObservableCollection<Mobile> Mobiles { get; set; }

            public IRepository<Mobile> _repo =
                Utils.ServiceLocator.Get<IRepository<Mobile>>();

            public MainViewModel()
            {
                var mobiles = _repo.GetAll();
                Mobiles = new ObservableCollection<Mobile>(mobiles);
            }
        }

        public MainViewModel ViewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }
        
        //POCOF5 8800000 Xiaomi là điện thoại dùng để add
    }
}
