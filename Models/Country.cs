using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pokemon_review_App.Models
{
    public class Country
    {
        // THESE ACT LIKE OUR MODELS

        public int Countryid { get; set; }
        public int name { get; set; }

        //        <Owner>: The angle brackets<Owner> denote that ICollection is a collection of objects of type Owner.In this case, Owner is likely another class in your application representing an entity related to a Country.

        //In the context of the Country class, ICollection<Owner> represents a collection of Owner objects associated with a particular country.This suggests a one-to-many relationship where a country can have multiple owners.The ICollection interface provides methods and properties for working with this collection, such as adding, removing, and accessing elements.
        public ICollection<Owner> owners { get; set; }
    }
}
