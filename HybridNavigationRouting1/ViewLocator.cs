using Avalonia.Controls;
using Avalonia.Controls.Templates;
using HybridNavigationRouting1.ViewModels;
using HybridNavigationRouting1.Views;
using ReactiveUI;
using System;

namespace HybridNavigationRouting1
{
    
    public class ViewLocator : IDataTemplate//, ReactiveUI.IViewLocator
    {
        public IControl Build(object data)
        {
            var name = data.GetType().FullName!.Replace("ViewModel", "View");
            var type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
