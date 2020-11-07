using Castle.DynamicProxy;
using System;
using System.Reflection;
using System.Linq;

namespace Core.Utilitis.InterCeptors
{
    public class AspectInterCeptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAtributes = type.GetCustomAttributes<MethodInterceptionBaseAtribute>(inherit: true).ToList();
            var methodAtributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAtribute>(inherit: true);
            classAtributes.AddRange(methodAtributes);
            return classAtributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
