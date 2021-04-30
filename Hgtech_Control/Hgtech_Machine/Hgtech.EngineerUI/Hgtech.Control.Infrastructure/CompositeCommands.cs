using Prism.Commands;

namespace Hgtech.Control.Infrastructure
{
    public interface ICompositeCommands
    {
        CompositeCommand DoCommand { get; }
    }

    public class CompositeCommands : ICompositeCommands
    {
        private CompositeCommand _doCommand = new CompositeCommand();
        public CompositeCommand DoCommand
        {
            get { return _doCommand; }
        }
    }
}
