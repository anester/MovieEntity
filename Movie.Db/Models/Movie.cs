using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Movie.Db
{
    public enum MediaTypeEnum 
    {
        Dvd, 
        BluRay,
        Digital,
        Service
    }

    public enum LocationTypeEnum
    {
        Physical, 
        Virtual
    }
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }
        public string Description { get; set; }

    }

    public class Location 
    {
        [Key]
        public int LocationId { get; set; }    
        public LocationTypeEnum LocationType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public int? VirtualAddressId { get; set; }
        public VirtualAddress VirtualAddress { get; set; }
    }

    public class Media
    {
        [Key]
        public int MediaId { get; set; }
        public MediaTypeEnum MediaType { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }

    public class VirtualAddress
    {
        [Key]
        public int VirtualAddressId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
