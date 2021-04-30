using Hgtech.Control.Infrastructure;
using Prism.Mvvm;


namespace Hgtech.Control.MainModule.ViewModels
{
    public class TopViewModel : BindableBase
    {
        private ICompositeCommands _compositeCommand;

        public ICompositeCommands CompositeCommands
        {
            get { return _compositeCommand; }
            set { SetProperty(ref _compositeCommand, value); }
        }

        public TopViewModel(ICompositeCommands compositeCommands)
        {
            CompositeCommands = compositeCommands;
        }
    }
}
