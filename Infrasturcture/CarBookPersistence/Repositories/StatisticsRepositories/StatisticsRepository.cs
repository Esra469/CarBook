using CarBook.Application.Interfaces.StatisticsInterfaces;
using CarBookPersistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookPersistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {

        private readonly CarBookContext _context;

        public StatisticsRepository(CarBookContext context)
        {
            _context = context;
        }

        public string GetBrandNameByMaxCar()
        {
            var values = _context.Cars.GroupBy(x => x.BrandID).Select(y => new
            {
                BrandID = y.Key,
                Count = y.Count(),

            }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();
            string brandName=_context.Brands.Where(x=>x.BrandID==values.BrandID).Select(y=>y.Name).FirstOrDefault();
            return brandName;

        }

        public string GetBrandTitleByMaxBlogComment()
        {
            var values = _context.Comments.GroupBy(x => x.BlogID).Select(y => new
            {
                BlogID=y.Key,
                Count= y.Count(),

            }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();
            string blogName=_context.Blogs.Where(x=>x.BlogID==values.BlogID).Select(y=>y.Title).FirstOrDefault();
            return blogName;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count() ;
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            int id = _context.Pricings.Where(y => y.Name == "Günlük").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            int id = _context.Pricings.Where(y => y.Name == "Haftalık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value= _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value=_context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            var result = _context.CarPricings
     .Where(x => x.Pricing.Name == "Günlük") // Günlük fiyatlandırmaya sahip olanlar
     .OrderByDescending(x => x.Amount)       // Fiyata göre büyükten küçüğe sırala
     .Select(y => y.Car.Brand.Name + " " + y.Car.Model) // Marka ve modeli birleştir
     .FirstOrDefault();                      // En yüksek fiyatlı ilk kaydı al (yoksa null döner)

            return result ?? "Veri Bulunamadı";
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            var result = _context.CarPricings
    .Where(x => x.Pricing.Name == "Günlük") // Günlük fiyatlandırmaya sahip olanlar
    .OrderBy(x => x.Amount)                 // Fiyata göre küçükten büyüğe sırala (En düşük fiyat)
    .Select(y => y.Car.Brand.Name + " " + y.Car.Model) // Marka ve modeli birleştir
    .FirstOrDefault();                      // En düşük fiyatlı ilk kaydı al (yoksa null döner)

            return result ?? "Veri Bulunamadı";

        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectirc()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen1000()
        {
            var value = _context.Cars.Where(x => x.Km <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value=_context.Locations.Count();
            return value;
        }
    }
}
