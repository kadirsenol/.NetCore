using System.Threading.Channels;

namespace Delegate_Difference_Between_Invoke_and_DynamicInvoke_
{
    public delegate void NameHandler(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            NameHandler nameHandler = new NameHandler(TopOyna);
            nameHandler += SalonaGel;
            nameHandler += AntrenmanYap;

            #region Invoke
            //nameHandler.Invoke("Ali"); 
            #endregion

            foreach (Delegate dlgt in nameHandler.GetInvocationList())
            {
                #region DynamicInvoke
                //dlgt.DynamicInvoke("Ali"); 
                #endregion

                #region Invoke After Reflection
                NameHandler namehandler2 = (NameHandler)dlgt;
                namehandler2.Invoke("Ali"); 
                #endregion
            }
        }

        public static void TopOyna(string name)
        {
            Console.WriteLine($"{name} hazirlanip evden çikti");
        }
        public static void SalonaGel(string name)
        {
            Console.WriteLine($"{name} antrenman yapacağı salona geldi.");
        }
        public static void AntrenmanYap(string name)
        {
            Console.WriteLine($"{name} antrenmanini tamamladi. ");
        }
    }
}
