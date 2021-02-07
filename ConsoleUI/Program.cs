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
            //CarGetAllTest();
            //CarGetByIdTest();
            //CarGetCarsByModelYearTest();
            //CarAddTest();
            //CarDeleteTest();
            //CarUpdateTest();
            //ColorAddTest();
            //ColorDeleteTest();
            //ColorGetByIdTest();
            //ColorUpdateTest();
            //ColorGetAllTest();
            //BrandAddTest();
            //BrandDeleteTest();
            //BrandUpdateTest();
            //BrandGetAllTest();
            CarManager carManager = new CarManager(new EfCarDal());
            int i = 0;
            foreach (var cardetail in carManager.GetCarDetails())
            {
                i++;
                Console.WriteLine("{0})",i);
                Console.WriteLine("Brand Name: "+cardetail.BrandName);
                Console.WriteLine("Color Name: "+cardetail.ColorName);
                Console.WriteLine("Daily Price: "+cardetail.DailyPrice);
                Console.WriteLine("Description: "+cardetail.Description+"\n");
            }
        }

        private static void BrandGetAllTest()
        {
            Console.WriteLine("BrandGetAll" + "\n");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Brand Id:" + brand.BrandId + "---" + "Brand Name:" + brand.BrandName);
            }
        }

        private static void BrandUpdateTest()
        {
            Console.WriteLine("BrandUpdate" + "\n");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 1, BrandName = "Bmw" });
            Console.WriteLine("Güncellendi");
        }

        private static void BrandDeleteTest()
        {
            Console.WriteLine("BrandDelete" + "\n");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 2002 });
            Console.WriteLine("Silindi");
        }

        private static void BrandAddTest()
        {
            Console.WriteLine("BrandAdd" + "\n");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Bmw" });
            Console.WriteLine("Eklendi");
        }

        private static void ColorGetAllTest()
        {
            Console.WriteLine("ColorGetAll" + "\n");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine("Color Id: " + color.ColorId + "---" + "Color Name: " + color.ColorName);
            }
        }

        private static void ColorUpdateTest()
        {
            Console.WriteLine("ColorUpdate" + "\n");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 1, ColorName = "Orange" });
            Console.WriteLine("Güncellendi");
        }

        private static void ColorGetByIdTest()
        {
            Console.WriteLine("ColorGetById" + "\n");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetById(2);
            Console.WriteLine("Color Name:" + result.ColorName);
        }

        private static void ColorDeleteTest()
        {
            Console.WriteLine("ColorDelete" + "\n");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 1002 });
            Console.WriteLine("Silindi");
        }

        private static void ColorAddTest()
        {
            Console.WriteLine("ColorAdd" + "\n");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Green" });
            Console.WriteLine("Eklendi");
        }

        private static void CarUpdateTest()
        {
            Console.WriteLine("CarUpdate" + "\n");
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 1, BrandId = 2, ColorId = 1, DailyPrice = 200, ModelYear = new DateTime(2017, 01, 01) });
            Console.WriteLine("Güncellendi");
        }

        private static void CarDeleteTest()
        {
            Console.WriteLine("CarDelete" + "\n");
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Delete(new Car { Id = 6005 });
            Console.WriteLine("Silindi");
        }

        private static void CarAddTest()
        {
            Console.WriteLine("CarAdd" + "\n");
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, ModelYear = new DateTime(2017, 01, 01), DailyPrice = 200, Description = "Renault" });
            Console.WriteLine("Eklendi");
        }

        private static void CarGetCarsByModelYearTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("CarGetCarsByModelYear\n");
            foreach (var car in carManager.GetCarsByModelYear(2018))
            {
                Console.WriteLine("Model Year: " + car.ModelYear.Year);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description + "\n");
            }
        }

        private static void CarGetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("CarGetById\n");
            var result = carManager.GetById(1);
            Console.WriteLine("Id: " + result.Id);
            Console.WriteLine("Model Year: " + result.ModelYear.Year);
            Console.WriteLine("Daily Price: " + result.DailyPrice);
            Console.WriteLine("Description: " + result.Description + "\n");
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("CarManagerGetAll" + "\n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model Year: " + car.ModelYear.Year);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("Description: " + car.Description + "\n");
            }
        }

    }
}
