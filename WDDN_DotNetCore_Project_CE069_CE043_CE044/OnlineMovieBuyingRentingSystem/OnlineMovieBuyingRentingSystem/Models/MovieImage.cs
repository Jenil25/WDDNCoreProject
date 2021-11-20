﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieBuyingRentingSystem.Models
{
    public class MovieImage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Select Movie")] 
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public string Path { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
