using HybridNavigationRouting1.Views;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace HybridNavigationRouting1.ViewModels
{
    public class HomeViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "Home Page";

        public IScreen HostScreen { get; }

        public RoutingState Router { get; } = new RoutingState();

        public ReactiveCommand<Unit, IRoutableViewModel> BackLoginCommand { get; }

        public HomeViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
            Locator.CurrentMutable.Register(() => new LoginView(), typeof(IViewFor<LoginViewModel>));
            BackLoginCommand = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new LoginViewModel()));
        }
    }
}
