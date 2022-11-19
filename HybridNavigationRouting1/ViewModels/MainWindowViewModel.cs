using HybridNavigationRouting1.Views;
using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace HybridNavigationRouting1.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IScreen
    {
        // The Router associated with this Screen.
        // Required by the IScreen interface.
        public RoutingState Router { get; } = new RoutingState();


        public MainWindowViewModel()
        {
            //Puts login view next up on the stack
            Locator.CurrentMutable.Register(() => new LoginView(), typeof(IViewFor<LoginViewModel>));
            //When MainWindowViewModel is loaded, login view is automatically loaded
            Router.Navigate.Execute(new LoginViewModel());
        }
    }
}
