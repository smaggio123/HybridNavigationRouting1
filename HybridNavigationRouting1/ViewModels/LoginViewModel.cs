using HybridNavigationRouting1.Views;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace HybridNavigationRouting1.ViewModels
{
    public class LoginViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Login";

        public IScreen HostScreen { get; }

        public RoutingState Router { get; } = new RoutingState();

        public ReactiveCommand<Unit, IRoutableViewModel> LoginCommand { get; }

        public LoginViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
            Locator.CurrentMutable.Register(() => new HomeView(), typeof(IViewFor<HomeViewModel>));
            LoginCommand = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new HomeViewModel()));
        }
    }
}
