using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik___Abstraction
{
    public abstract class Person
    {
        public string _ad {  get; set; }

        public string _soyad {  get; set; }

        public string _departman {  get; set; }

        public abstract void Görev();
        public void BilgileriYazdır()
        {
            Console.WriteLine($"Adım : {_ad}  ,  Soyadım : {_soyad}  , Departman : {_departman}");
        }
    }
    public class Patron : Person
    {
        public override void Görev()
        {
            Console.WriteLine("Yapı Var !!!");
        }
    }
    public class ProjeYonetimi : Person
    {
        public override void Görev()
        {
            Console.WriteLine("Benim Görevim Proje Yönetimi");
        }
    }
    public class Yazilimci : Person
    {
        public override void Görev()
        {
            Console.WriteLine("Ben yazılımcıyım");
        }
    }
}
