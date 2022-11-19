using Avalonia.Controls;
using Avalonia.ReactiveUI;
using HybridNavigationRouting1.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace HybridNavigationRouting1.Views
{
    public partial class HomeView : ReactiveUserControl<HomeViewModel>
    {
        public HomeView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.HomeText.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
