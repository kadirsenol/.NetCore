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
            //Service ve container lar, "Dependency Inversion" islerini merkezileştiriyor.

            #region IoC of Unity
            //Istenilen hizmetlerin tamamını kayıt sirasinda Constructor Injection lari dahil bizim belirlediğimiz bir konteynırdır.
            //String etiket girerek aynı yetenekte birden fazla bagımlılık nesnesi girisi yapılabiliyor. (Tercih nedenidir.)

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
            //Eklenen hizmet istenildiğinde, Constructor injection larını(enjekte edilecek bağımlılıkları) built in dependency injection ozelligi ile servis içerisine eklenen-
            //hizmetlerden otomatik inşa eder ve sağlar, bu nedenle kayıt sirasinda Constructor Injection lar belirtilmez. (Tercih nedenidir.)
            //String etiket girerek aynı yetenekte birden fazla bagımlılık nesnesi girisi yapılamıyor, yapılması denendiginde en son kayıtı hafızada tutar ve onu dondurur.

            ServiceCollection service = new ServiceCollection();
            service.AddScoped<ICar, Audi>(); /* service.AddSingleton<Audi>(new Audi()); bagimliliklarin manuel verilmesi, tercih edilmez !*/    
            service.AddTransient<Driver>();  /* service.AddSingleton<Driver>(new Driver(new Audi())); bagimliliklarin manuel verilmesi, tercih edilmez !*/
            

            IServiceProvider serviceProvider = service.BuildServiceProvider();
            ICar audi = serviceProvider.GetService<ICar>();
            audi.Run();
            Driver driver = serviceProvider.GetService<Driver>(); //Driver' in Constructor Injection larını, servise eklediğimiz <ICar,Audi> hizmetinden built in ederek sağlayacaktır.
            driver.RunCar();                                      //Bu ozellige, Built in Dependency Injection denir. (Enjekte edilecek bağımlılıkları inşa etmek)

            #endregion
        }

        #region Using for MainMethod
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
        public class Bmw : ICar
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
        #endregion
    }
}
