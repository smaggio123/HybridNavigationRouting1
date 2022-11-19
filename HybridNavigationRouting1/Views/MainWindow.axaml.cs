using Avalonia.Controls;
using Avalonia.ReactiveUI;
using HybridNavigationRouting1.ViewModels;
using ReactiveUI;

namespace HybridNavigationRouting1.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new MainWindowViewModel();
            this.WhenActivated(disposables =>
            {
                
                // Bind the view model router to RoutedViewHost.Router property.
                //this.OneWayBind(ViewModel, x => x.Router, x => x.RoutedViewHost.Router)
                  //  .DisposeWith(disposables);
                
            });
        }
    }
}
