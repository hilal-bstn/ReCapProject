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
            //CarDetailGetAllTest();
            //UserGetAllTest();
            //UserGetByIdTest();
            //UserAddTest();
            //RentalAddTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Update(new Rental {Id=5015,CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 03, 14), ReturnDate=new DateTime(2021,02,13) });
            Console.WriteLine(result.Message);

        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental { CarId = 2, CustomerId = 2, RentDate = new DateTime(2021, 03, 14) });
            Console.WriteLine(result.Message);
        }

        //private static void UserAddTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var result = userManager.Add(new User { FirstName = "Hilal", LastName = "B", Email = "Hilal@", Password = "123" });
            
        //}

        //private static void UserGetByIdTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var result = userManager.GetById(1);
        //    if (result.Success == true)
        //    {
        //        Console.WriteLine(result.Data.FirstName + " " + result.Data.LastName);
        //    }
        //}

        //private static void UserGetAllTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    var result = userManager.GetAll();
        //    if (result.Success == true)
        //    {
        //        foreach (var user in result.Data)
        //        {
        //            Console.WriteLine(user.UserId + "\t" + user.FirstName);
        //        }
        //    }
        //}

        private static void CarDetailGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();


            if (result.Success == true)
            {
                int i = 0;
                foreach (var cardetail in result.Data)
                {
                    i++;
                    Console.WriteLine("{0})", i);
                    Console.WriteLine("Brand Name: " + cardetail.BrandName);
                    Console.WriteLine("Color Name: " + cardetail.ColorName);
                    Console.WriteLine("Daily Price: " + cardetail.DailyPrice);
                    Console.WriteLine("Description: " + cardetail.Description + "\n");
                }
                Console.WriteLine(result.Message);

            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        

    }
}
