using Akka.Actor;
using Akka.DependencyInjection;

namespace Servus.Akka;

public static class PropsExtensions
{
    public static Props Props<T>(this ActorSystem system, params object[] args)
        where T : ActorBase => DependencyResolver.For(system).Props<T>(args);
    
    public static Props Props<T>(this IUntypedActorContext context, params object[] args)
        where T: ActorBase => DependencyResolver.For(context.System).Props<T>(args);
}