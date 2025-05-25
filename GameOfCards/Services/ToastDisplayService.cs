

namespace GameOfCards.Services
{
    internal class ToastDisplayService : IToastDisplay
    {
        private string name = string.Empty; 

        public string Name { get => name; set => name = value; }
    }
}
