using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete.Ef;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listele\n".ToUpper());
            CarManager carManager = new CarManager(new EfCarDal());
            int i = 0;
            foreach (var car in carManager.GetAll())
            {
                i++;
                Console.WriteLine("{0}. Araba", i);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }

            Console.WriteLine("BrandId ye göre Listele\n".ToUpper());
            int Id = 1;
            foreach (var car in carManager.GetCarsByBrandId(Id))
            {
                
                Console.WriteLine("BrandId:"+car.BrandId);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük Ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description+"\n");
            }
            Console.WriteLine("ColorId ye göre Listele\n".ToUpper());
         
            foreach (var car in carManager.GetCarsByColorId(Id))
            {
               
                Console.WriteLine("ColorId:" + car.ColorId);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük Ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }

            //Console.WriteLine("******Yeni Araç Ekleme********\n");

            //carManager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = new DateTime(2019, 11, 12), DailyPrice = 250, Description = "Mercedes" });
            //carManager.Add(new Car { BrandId = 3, ColorId = 2, ModelYear = new DateTime(2017, 11, 12), DailyPrice = 180, Description = "A" });
            //Console.WriteLine("*********Araç Güncelleme*******\n");
            //carManager.Update(new Car { Id = 1,BrandId=3,ColorId=1 ,ModelYear = new DateTime(2018, 11, 12), DailyPrice = 300, Description = "Ford" });
            //Console.WriteLine("Araç özellikleri gücellendi\n");

            //Console.WriteLine("***********Araç Silme*********\n");
            //carManager.Delete(new Car { Id = 2 });
            //Console.WriteLine("Araç Silindi\n");

            //Console.WriteLine("*******İşlemler sonrası oluşan yeni liste*****\n");

            
            Console.WriteLine("Model yılına göre listeleme\n".ToUpper());
            
            int t = 0;
            foreach (var car in carManager.GetCarsByModelYear(2018))
            {
                t++;
                Console.WriteLine("{0}. Araba", t);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("iki model yılı arasındaki araçları listeleme\n".ToUpper());
            int s = 0;

            foreach (var car in carManager.GetCarsModelYears(2018,2020))
            {
                s++;
                Console.WriteLine("{0}. Araba", s);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }
        }
    }
}
