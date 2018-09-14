using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.DAL
{
    public class exAddressExt
    {
        public int exAddressExtId { get; set; }
        public string ApartmentOffice { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Country { get; set; }
        public string House { get; set; }
        public string Housing { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }

        public exAddressExt GetFullAddress()
        {
            exAddressExt addressExt = new exAddressExt();

            addressExt.CityId = CityId;
            addressExt.City = City;
            addressExt.CityName = CityName;
            addressExt.Country = Country;
            addressExt.CountryName = CountryName;
            addressExt.House = House;
            addressExt.Housing = Housing;
            addressExt.PostCode = PostCode;
            addressExt.Street = Street;
            addressExt.ApartmentOffice = ApartmentOffice;

            return addressExt;
        }

        public override string ToString()
        {
            return string.Format($"Country: {Country}\n" +
                $"Country Name: {Country}\n" +
                $"City id: {CityId}\n" +
                $"City: {City}\n" +
                $"City name: {CityName}\n" +
                $"House: {House}\n" +
                $"Housing: {Housing}\n" +
                $"Street: {Street}\n" +
                $"Apartment Office: {ApartmentOffice}\n" +
                $"Post code: {PostCode}\n");
        }
    }
}
