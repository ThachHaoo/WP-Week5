using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Model;

namespace App1.DataAccess
{
    public class MockMobileRepository : IRepository<Mobile>
    {
        public List<Mobile> GetAll()
        {
            return new List<Mobile>()
            {
                new Mobile()
                {
                    Name="iPhone 15 Pro",
                    Image="Assets/iphone15pro.png",
                    Manufacturer="Apple",
                    Price=29990000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy S23 Ultra",
                    Image="Assets/samsunggalaxys23ultra.png",
                    Manufacturer="Samsung",
                    Price=24990000
                },
                new Mobile()
                {
                    Name="Google Pixel 8 Pro",
                    Image="Assets/googlepixel8pro.png",
                    Manufacturer="Google",
                    Price=23490000
                },
                new Mobile()
                {
                    Name="iPhone 15",
                    Image="Assets/iphone15.png",
                    Manufacturer="Apple",
                    Price=22490000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy Z Fold 5",
                    Image="Assets/zfold5.png",
                    Manufacturer="Samsung",
                    Price=32990000
                },
                new Mobile()
                {
                    Name="Google Pixel 8",
                    Image="Assets/googlepixel8.png",
                    Manufacturer="Google",
                    Price=17990000
                },
                new Mobile()
                {
                    Name="OnePlus 11",
                    Image="Assets/oneplus11.png",
                    Manufacturer="OnePlus",
                    Price=17490000
                },
                new Mobile()
                {
                    Name="Xiaomi 13 Pro",
                    Image="Assets/xiaomi13pro.png",
                    Manufacturer="Xiaomi",
                    Price=23990000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy S23",
                    Image="Assets/samsunggalaxys23.png",
                    Manufacturer="Samsung",
                    Price=16990000
                },
                new Mobile()
                {
                    Name="iPhone 14 Pro",
                    Image="Assets/iphone14pro.png",
                    Manufacturer="Apple",
                    Price=25990000
                },
                new Mobile()
                {
                    Name="Sony Xperia 1 V",
                    Image="Assets/xperia1v.png",
                    Manufacturer="Sony",
                    Price=34990000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy Z Flip 5",
                    Image="Assets/zflip5.png",
                    Manufacturer="Samsung",
                    Price=19990000
                },
                new Mobile()
                {
                    Name="Google Pixel 7a",
                    Image="Assets/pixel7a.png",
                    Manufacturer="Google",
                    Price=9990000
                },
                new Mobile()
                {
                    Name="Asus ROG Phone 7",
                    Image="Assets/rogphone7.png",
                    Manufacturer="Asus",
                    Price=24990000
                },
                new Mobile()
                {
                    Name="Motorola Razr+ (2023)",
                    Image="Assets/motorolarazrplus.png",
                    Manufacturer="Motorola",
                    Price=24990000
                },
                new Mobile()
                {
                    Name="Oppo Find X6 Pro",
                    Image="Assets/oppofindx6pro.png",
                    Manufacturer="Oppo",
                    Price=27490000
                },
                new Mobile()
                {
                    Name="iPhone SE (2022)",
                    Image="Assets/iphonese2022.png",
                    Manufacturer="Apple",
                    Price=11490000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy A54",
                    Image="Assets/galaxya54.png",
                    Manufacturer="Samsung",
                    Price=8990000
                },
                new Mobile()
                {
                    Name="Xiaomi 13T Pro",
                    Image="Assets/xiaomi13tpro.png",
                    Manufacturer="Xiaomi",
                    Price=14990000
                },
                new Mobile()
                {
                    Name="OnePlus Nord 3",
                    Image="Assets/oneplusnord3.png",
                    Manufacturer="OnePlus",
                    Price=9490000
                },
                new Mobile()
                {
                    Name="Google Pixel Fold",
                    Image="Assets/googlepixelfold.png",
                    Manufacturer="Google",
                    Price=44990000
                },
                new Mobile()
                {
                    Name="Samsung Galaxy S23 FE",
                    Image="Assets/samsungs23fe.png",
                    Manufacturer="Samsung",
                    Price=11990000
                }
            };
        }
        //public Mobile GetById()
        //{
        //    throw new NotImplementedException();
        //}
        //public int DeleteById(int id)
        //{
        //    throw new NotImplementedException();
        //}
        //public int Insert(int id)
        //{
        //    throw new NotImplementedException();
        //}
        //public int Update(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
