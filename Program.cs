using DependencyInjectionExample;
using DependencyInjectionExample.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğretmeni elle oluştur ve DI container'a ekle
            var teacherInstance = new Teacher("John", "Doe");

            var serviceProvider = new ServiceCollection()
                .AddSingleton<IOgretmen>(teacherInstance)  // Elle oluşturulmuş teacher
                .AddSingleton<ClassRoom>()                 // ClassRoom da eklendi
                .BuildServiceProvider();

            // DI kullanarak ClassRoom nesnesini al
            var classRoom = serviceProvider.GetService<ClassRoom>();

            // Öğretmenin bilgilerini yazdır
            classRoom.GetTeacherInfo();

            Console.ReadLine(); // Konsolun hemen kapanmaması için
        }
    }
}
