using Ninject.Syntax;

namespace Nerdle.AutoConfig.Ninject
{
    public static class AutoConfigNinjectExtensions
    {
        public static IBindingWhenInNamedWithOrOnSyntax<T> ToConfig<T>(this IBindingToSyntax<T> bind, string sectionName = null)
        {
            var config = AutoConfig.Map<T>(sectionName);
            return bind.ToConstant(config);
        }
    }
}
