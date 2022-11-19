using Avalonia.Controls;
using Avalonia.ReactiveUI;
using HybridNavigationRouting1.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace HybridNavigationRouting1.Views
{
    public partial class LoginView : ReactiveUserControl<LoginViewModel>
    {
        public LoginView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, x => x.UrlPathSegment, x => x.LoginText.Text)
                    .DisposeWith(disposables);
            });
        }
    }
}
