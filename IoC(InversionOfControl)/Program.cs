using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;
using Unity;
using Unity.Injection;

namespace IoC_InversionOfControl_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IoC of Unity

            //Servis ve conteynır işlerini merkezileştiriyor.

            IUnityContainer unitycontainer = new UnityContainer();
            unitycontainer.RegisterType<ICar, Audi>("Audi");
            unitycontainer.RegisterType<ICar, Bmw>("Bmw");
            unitycontainer.RegisterType<Driver>("AudiDriver", new InjectionConstructor(new Audi()));
            unitycontainer.RegisterType<Driver>("BmwDriver", new InjectionConstructor(new Bmw()));

            ICar bmwcar = unitycontainer.Resolve<ICar>("Bmw");
            bmwcar.Run();
            Driver bmwcardriver = unitycontainer.Resolve<Driver>("BmwDriver");
            bmwcardriver.RunCar();

            #endregion

            #region IoC of Mic.Ex.DependencyInjection
            //eklenen hizmetin Constructor injection ları otomatik olarak built in dependency injection
            //yani enjekte edilecek bağımlılıkları otomatik inşa eder ve sağlar.
            //String etiket girerek aynı yetenekte birden fazla bagımlılık nesnesi girisi yapılamıyor, yapılması denendiginde en son kayıtı hafızada tutar.

            ServiceCollection service = new ServiceCollection();
            service.AddScoped<ICar, Audi>(); /* service.AddSingleton<Driver>(new Driver(new Audi())); bagimliliklarin elle manuel verilmesi, tercih edilmez !*/
            service.AddTransient<Driver>();  /* service.AddSingleton<Audi>(new Audi()); bagimliliklarin elle manuel verilmesi, tercih edilmez !*/
            
            IServiceProvider serviceProvider = service.BuildServiceProvider();
            ICar audi = serviceProvider.GetService<ICar>();
            audi.Run();
            Driver driver = serviceProvider.GetService<Driver>();
            driver.RunCar();

            #endregion
        }

        public interface ICar
        {
            public void Run();
        }

        public class Audi : ICar
        {
            public void Run()
            {
                Console.WriteLine("Run of Audi");
            }
        }
        public  class Bmw : ICar
        {
            public void Run()
            {
                Console.WriteLine("Run of Bmw");
            }
        }
        
        public class Driver
        {
            private readonly ICar _car;
            public Driver(ICar car)
            {
               _car = car;
            }
            public void RunCar()
            {
                _car.Run();
            }
        }
    }
}
