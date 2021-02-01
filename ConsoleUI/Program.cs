using Business.Concrete;
using DataAccess.Abstarct;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Listele*****\n");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            int i = 0;
            foreach (var car in carManager.GetAll())
            {
                i++;
                Console.WriteLine("{0}. Araba", i);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }

            Console.WriteLine("********Id ye göre Listele*********\n");
            int Id = 1;
            foreach (var car in carManager.GetById(Id))
            {
                Console.WriteLine("{0} nolu Arabanın Özellikleri", Id);
                Console.WriteLine("Model Yılı: " + car.ModelYear.Year);
                Console.WriteLine("Günlük Ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description+"\n");
            }

            Console.WriteLine("******Yeni Araç Ekleme********\n");

            carManager.Add(new Car { Id = 6, BrandId = 6, ColorId = 3, ModelYear = new DateTime(2019, 11, 12), DailyPrice = 250, Description = "Mercedes" });
            Console.WriteLine(" Yeni araç listeye eklendi\n");
            Console.WriteLine("*********Araç Güncelleme*******\n");
            carManager.Update(new Car { Id = 1, BrandId = 4, ColorId = 2, ModelYear = new DateTime(2018, 11, 12), DailyPrice = 300, Description = "Audi" });
            Console.WriteLine("Araç özellikleri gücellendi\n");

            Console.WriteLine("***********Araç Silme*********\n");
            carManager.Delete(new Car { Id = 2 });
            Console.WriteLine("Araç Silindi\n");

            Console.WriteLine("*******İşlemler sonrası oluşan yeni liste*****\n");

            int x = 0;
            foreach (var car in carManager.GetAll())
            {
                x++;
                Console.WriteLine("{0}. Araba", x);
                Console.WriteLine("Brand Id: " + car.BrandId);
                Console.WriteLine("Günlük ücreti: " + car.DailyPrice);
                Console.WriteLine("Açıklaması: " + car.Description + "\n");
            }
        }
    }
}
