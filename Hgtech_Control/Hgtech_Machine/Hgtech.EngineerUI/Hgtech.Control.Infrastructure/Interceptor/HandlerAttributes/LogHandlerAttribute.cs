using Hgtech.Control.Infrastructure.Interceptor.Handlers;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace Hgtech.Control.Infrastructure.Interceptor.HandlerAttributes
{
    /// <summary>
    /// 
    /// </summary>
    public class LogHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new LogHandler() { Order = this.Order };
        }
    }
}
