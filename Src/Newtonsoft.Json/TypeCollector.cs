using System;

namespace Newtonsoft.Json
{
    public interface ITypeCollector
    {
        void Collect(Type type);
    }

    public static class TypeCollectorProxy
    {
        public static ITypeCollector TypeCollector { get; set; }

        public static void Collect(Type type)
        {
            TypeCollector?.Collect(type);
        }
    }
}
