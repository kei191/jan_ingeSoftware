﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class MovieController : Controller
    {
 
        public IActionResult Index()
        {
            var movies = GetListOfMovies();
            ViewBag.MainTitle = " List of my favorite films";
            return View(movies);
        }
        private List <MovieModel> GetListOfMovies()
        {
            List<MovieModel> movies = new List<MovieModel>();
            movies.Add(new MovieModel { Id = 1, Name = " Pulp Fiction ", Genre = " Crime / Drama ",
                ReleasedDate = new DateTime(1994, 10, 14) });
            movies.Add(new MovieModel { Id = 2, Name = " Toy Story ", Genre = " Family / Comedy ",
                ReleasedDate = new DateTime(1995, 11, 22) });
            movies.Add(new MovieModel { Id = 3, Name = " Mulan ", Genre = " Family / Comedy ",
                ReleasedDate = new DateTime(1998, 06, 19) });
            return movies;
        }
    }
}
