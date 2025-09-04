using ContactDataAccess;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactBusinessLayer
{
    public class Country
    {
        private enum Mode{ addNew,update};
        private Mode _mode;
        public int Id { get; set; }
        public string CountryName { get; set; }

        public string code { get; set; }
        public string phoneCode { get; set; }

        public Country()
        {

            _mode = Mode.addNew;
            code = "";
            phoneCode = "";


        }
        private Country(int Id, string CountryName, string code, string phoneCode)
        {
            this.Id = Id;
            this.CountryName = CountryName;
            _mode = Mode.update;
            this.code = code;
            this.phoneCode = phoneCode;
        }
        public string Print()
        {
            return ($"Id:{this.Id} , Country Name:{this.CountryName} , Code:{this.code} , Phone Code:{this.phoneCode}");
        }
        public static Country findCountryByName(string CountryName)
        {
            string code = ""; 
            string phoneCode = "";
            int id = CountryData.findCountryByName(CountryName, ref code, ref phoneCode);
            if (id> 0)
            {
                return new Country(id, CountryName,code,phoneCode);
            }

            return null;
        }
        public static DataTable getCountries()
        {
            
            return CountryData.getAllCountries();
       
        }
        private bool _addCountry()
        {
            this.Id = CountryData.addNewCountry(this.CountryName,this.code,this.phoneCode);
            return this.Id > 0;
        }
        private bool _updateCountry()
        {
            return CountryData.updateCountry(this.Id, this.CountryName,this.code,this.phoneCode);
        }
        public static Country findById(int id)
        {
            string CountryName = "";
            string code = "";
            string phoneCode = "";
            if (CountryData.findById(id, ref CountryName,ref code,ref phoneCode))
            {

               return new Country(id, CountryName,code,phoneCode);
            }
            return null;
        }
        public static bool isExist(string countryName)
        {
            return CountryData.isExist(countryName);
        }

        public bool save()
        {
            switch (_mode)
            {
                case Mode.addNew:
                    if (_addCountry())
                    {
                        _mode = Mode.update;
                        return true;
                    }
                    return false;
                case Mode.update:
                    return _updateCountry();
            }
            return false;
        }

    }
}
