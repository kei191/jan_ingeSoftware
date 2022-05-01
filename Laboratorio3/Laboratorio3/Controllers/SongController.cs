using Microsoft.AspNetCore.Mvc;
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
    public class SongController : Controller
    {
        public IActionResult Index()
        {
                var songs = GetListOfSongs();
                ViewBag.MainTitle = " List of my favorite songs";
                return View(songs);

        }
        private List<SongModel> GetListOfSongs()
        {
            List<SongModel> songs = new List<SongModel>();
            songs.Add(new SongModel
            {
                Id = 1,
                Title = " 결국 ",
                Genre = " Pop ",
                Singer = "G-Dragon",
                Language = "Korean/English",
                ReleasedDate = new DateTime(2015, 5, 30)
            });
            songs.Add(new SongModel
            {
                Id = 2,
                Title = " ジグソーパズル ",
                Genre = " Pop/Electronic ",
                Singer = "鏡音レン",
                Language = "Japanese",
                ReleasedDate = new DateTime(2018, 11, 24)
            });
            songs.Add(new SongModel
            {
                Id = 3,
                Title = " Nakakapagpabagabag ",
                Genre = " Pop/Electronic ",
                Singer = "鏡音レン",
                Language = "Tagalog",
                ReleasedDate = new DateTime(2016, 5, 27)
            });
            return songs;
        }
    }
}
