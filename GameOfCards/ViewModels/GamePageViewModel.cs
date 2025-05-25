
using GameOfCards.Services;

namespace GameOfCards.ViewModels;
internal class GamePageViewModel : BaseViewModel
{
    private readonly IToastDisplay _toastDisplay;
    public GamePageViewModel(IErrorHandler errorHandler, IToastDisplay toastDisplay) : base(errorHandler)
    {
        _toastDisplay = toastDisplay;
        var asdas = new ToastDisplayService();
        asdas.Name = string.Empty;
    }

}
