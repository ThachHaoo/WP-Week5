using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Utils
{
    //Thầy bảo cái này tên là Container, nhưng lúc em search thì lại ra ServiceLocater nên em sẽ sử dụng nó
    public class ServiceLocator
    {
        private static readonly Dictionary<Type, object> _services = new();

        public static void Register<Parent, Child>()
        {
            Type parent = typeof(Parent);
            Type child = typeof(Child);

            // Kiểm tra xem Child có kế thừa hoặc triển khai Parent hay không
            if (!parent.IsAssignableFrom(child))
                throw new InvalidOperationException(
                    $"{child.Name} does not implement or inherit from {parent.Name}");

            // Kiểm tra xem kiểu Parent đã được đăng ký hay chưa
            if (_services.ContainsKey(parent))
                throw new InvalidOperationException($"{parent.Name} is already registered.");

            _services.Add(parent, Activator.CreateInstance(child)!);
        }

        public static Parent Get<Parent>()
        {
            Type parent = typeof(Parent);
            // Kiểm tra xem kiểu Parent đã được đăng ký hay chưa
            if (!_services.TryGetValue(parent, out var instance))
                throw new InvalidOperationException($"{parent.Name} is not registered.");

            return (Parent)instance;
        }
    }
}
