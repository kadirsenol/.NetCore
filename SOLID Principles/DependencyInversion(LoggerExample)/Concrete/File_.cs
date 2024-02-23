using soliD_DependencyInversionPrincible_.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soliD_DependencyInversionPrincible_.Concrete
{
    public class File_ : ILoglanabilir
    {
        
        public void Loglan(string msg)
        {
            List<string> files = new List<string>();
            if (!File.Exists($@"C:\Users\kdrsn\OneDrive\Masaüstü\LogFile\dosya.txt"))
            {
                files.Add(msg);
                File.WriteAllLines($@"C:\Users\kdrsn\OneDrive\Masaüstü\LogFile\dosya.txt", files);
            }
            else
            {
                files.AddRange(File.ReadAllLines($@"C:\Users\kdrsn\OneDrive\Masaüstü\LogFile\dosya.txt"));
                files.Add(msg);
                File.WriteAllLines($@"C:\Users\kdrsn\OneDrive\Masaüstü\LogFile\dosya.txt", files);
            }
            
            
            
            
        }
    }
}
