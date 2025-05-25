namespace GameOfCards.ViewModels;

internal class BaseViewModel
{
    private readonly IErrorHandler _errorHandler;
    public BaseViewModel(IErrorHandler errorHandler)
    {
        _errorHandler = errorHandler;
    }
}
