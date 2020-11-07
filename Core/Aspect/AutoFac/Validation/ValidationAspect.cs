using Castle.DynamicProxy;
using Core.Utilitis.InterCeptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.ValidationTool.FluentValidation;

namespace Core.Aspect.AutoFac.Validation
{
    public class ValidationAspect:MethodInterCeptor
    {
        Type validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
                throw new Exception("wrong validate type");
            this.validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = Activator.CreateInstance(validatorType);
            var entityType = validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach(var entity in entities)
            {
                ValidationTool.FluentValidation.ValidationTool.Validate((IValidator)validator, entity);
            }

        }
    }
}
