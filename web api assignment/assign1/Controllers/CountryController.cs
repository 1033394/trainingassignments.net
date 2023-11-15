using assign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.AspNetCore;

namespace assign1.Controllers
{
    public class CountriesController : ApiController
    {
        // Country repository
        List<Country> countries = new List<Country>(){
            new Country{
                ID=1,CountryName="USA",Capital="Washington"
            },
            new Country{
                ID=2,CountryName="India", Capital="New Delhi"
            }
        };
        // GET All Countries
        public IEnumerable<Country> GetCountries()
        {
            return countries;
        }

        // GET Country By ID
        public Country GetCountry(int id)
        {
            return countries.Find(c => c.ID == id);
        }

        // POST a new Country
        public HttpResponseMessage PostCountry(Country country)
        {
            countries.Add(country);
            var response = Request.CreateResponse(HttpStatusCode.Created, country);
            return response;
        }

        // PUT update country
        public HttpResponseMessage PutCountry(int id, Country country)
        {
            var countryToUpdate = countries.Find(c => c.ID == id);
            if (countryToUpdate != null)
            {
                countryToUpdate.CountryName = country.CountryName;
                countryToUpdate.Capital = country.Capital;
                return Request.CreateResponse(HttpStatusCode.OK, countryToUpdate);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Country not found");
            }
        }

        // DELETE country
        public HttpResponseMessage DeleteCountry(int id)
        {
            var countryToDelete = countries.Find(c => c.ID == id);
            if (countryToDelete != null)
            {
                countries.Remove(countryToDelete);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Country not found");
            }
        }
    }

}