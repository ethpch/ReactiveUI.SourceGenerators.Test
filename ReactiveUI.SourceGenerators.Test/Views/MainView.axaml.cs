using Avalonia.Controls;
using ReactiveUI.SourceGenerators;

namespace ReactiveUI.SourceGenerators.Test.Views;

[IViewFor<ViewModels.MainViewModel>]
public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
}
