using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyfirstWeb.Controllers
{
    [Route("/products")]
    public class ProductsController : Controller
    {
        [Route("Index")]
        public ActionResult Index()
        {
            return Content("Product Index");
        }
        [Route("Detalles")]
        public ActionResult Detalles()
        {
            return Content("Detalles");
        }
        [Route("List")]
        public ActionResult List()
        {
            return Content("Product list");
        }
        //__________________Atributo de ruteo____________________________
        [Route("{id}")]
        [Route("/product/{id}")]
        public ActionResult Details(int id)
        {
            return Content("Product details for #" + id);
        }
        //_________________Plantillas de ruteo__________________________
        /* [Route("blog/{entryId}/{slug}")]
         public IActionResult Blog(int entryId, string slug)
         {
             return Content($"Blog entry with ID #{entryId} requested (URL Slug: {slug})");
         }
         //__________________Parámetros Atrapa-todo (Catch-all)___________________
         [Route("blog/{entryId}/{*slug}")]
         public IActionResult Blogi(int entryId, string slug)
         {
             return Content($"Blog entry with ID #{entryId} requested (URL Slug: {slug})");
         }
         //_____________________Parámetros opcionales___________________________________
         [Route("blog/{entryId}/{slug?}")]
         public IActionResult Blogs(int entryId, string slug)
         {
             return Content($"Blog entry with ID #{entryId} requested (URL Slug: {slug})");
         }
         __________________________NULL________________________________
         [Route("blog/{entryId}/{slug?}")]
         public IActionResult Blogss(int entryId, string slug = "")
         {
            return Content($"Blog entry with ID #{entryId} requested (URL Slug: {slug})");
         }
         //___________________________Restricciones de tipo de dato____________________________
         [route("blog/{entryid:int}/{slug}")]
         public iactionresult blogg(int entryid, string slug)
         {
           return content($"blogg entry with id #{entryid} requested (url slug: {slug})");
         }
        //__________________________Restricciones de longitud y Rango________________
        [Route("blog/{entryId:min(3)}/{slug}")]
        public IActionResult Bloggi(int entryId, string slug)
        {
            return Content($"Bloggi entry with ID #{entryId} requested (URL Slug: {slug})");
        }
        [Route("blog/{entryId:range(1, 4)}/{slug}")]
        public IActionResult Blogd(int entryId, string slug)
        {
            return Content($"Blogd entry with ID #{entryId} requested (URL Slug: {slug})");
        }
        //______________________Combinar múltiples restricciones___________________________
        [Route("blog/{entryId:int:range(1, 2)}/{slug:minlength(3):maxlength(5)}")]
        public IActionResult Blog(int entryId, string slug)
        {
            return Content($"Blogd entry with ID #{entryId} requested (URL Slug: {slug})");
        }
        //____________________Restricciones con expresiones regulares____________________
        [Route(@"blog/{slug:regex(^[[0-9]]{{1,7}}\-[[a-z0-9\-]]{{3,50}}$)}")]
        public IActionResult Blog(string slug)
        {
            int hyphenPos = slug.IndexOf("-");
            int entryId = int.Parse(slug.Substring(0, hyphenPos));
            string slugPart = slug.Substring(hyphenPos + 1);
            return Content($"Blog entry with ID #{entryId} requested (URL Slug: {slug})");
        }*/
    }
}