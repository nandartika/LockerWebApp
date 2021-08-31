using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LockerWebApp.Data;
using LockerWebApp.Models;

namespace LockerWebApp.Controllers
{
    public class LockersController : Controller
    {
        private readonly LockerWebAppContext _context;

        public LockersController(LockerWebAppContext context)
        {
            _context = context;
        }

        // GET: Lockers/ShowSearch
        public ActionResult ShowSearch()
        {
            return View();
        }

        // POST: Lockers/ShowSearch
        public ActionResult ShowSearchResult(int SearchFloor)
        {
            Locker model = new Locker();

            List<int> LockerList = new List<int>
            {
                9, 3, 7, 2
            };

            model.Floor = 0;
            int Now = 0;
            int x = 0;

            while (SearchFloor > Now) // Jika kondisi tidak terpenuhi maka looping akan berhenti
            {
                if (x >= LockerList.Count) x = 0;
                Now += LockerList[x];
                model.Floor++;
                x++;
            }

            return View("ShowSearch", model);
        }
    }
}
