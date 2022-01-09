using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SpaDayDesktop.Controllers
{
    public class SpaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public bool CheckSkinType(string skinType, string facialType)
        {

            if (facialType != "Microdermabrasion")
            {
                if (skinType == "oily" && facialType != "Rejuvenating")
                {
                    return false;
                }
                else if (skinType == "combination" && (facialType != "Rejuvenating" || facialType != "Enzyme Peel"))
                {
                    return false;
                }
                else if (skinType == "dry" && facialType != "Hydrofacial")
                {
                    return false;
                }
            }

            return true;

        }

        static List<string> facials = new List<string>()
        {
            "Microdermabrasion", "Hydrofacial", "Rejuvenating", "Enzyme Peel"
        };

        [HttpPost]
        [Route("/spa/menu")]
        public IActionResult Menu(string name, 
            string skintype, string manipedi)
        {
            ViewBag.clientName = name;
            ViewBag.clientSkintype = skintype;

            List<string> appropriateFacials = new List<string>();
            for (int i=0; i<facials.Count; i++)
            {
                if (CheckSkinType(skintype, facials[i]))
                {
                    appropriateFacials.Add(facials[i]);
                }
            }

            ViewBag.goodFacialsForClient = appropriateFacials;
            ViewBag.maniOrPedi = manipedi;
            return View();
        }
    }
}
