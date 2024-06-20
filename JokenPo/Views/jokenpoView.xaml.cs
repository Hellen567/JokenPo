using JokenPo.ViewModels;

namespace JokenPo.Views;
public partial class jokenpoView : ContentPage
{
    public jokenpoView()
	{
        InitializeComponent();
        BindingContext = new jokenpoViewModel();
    }
}