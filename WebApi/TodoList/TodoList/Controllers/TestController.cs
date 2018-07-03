using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Xml.Linq;

namespace TodoList.Controllers
{
    public class TestModel
    {
        public int ID { get; set; }
        public string Commentaire { get; set; }
    }

    public class TestController : ApiController
    {

        // GET: api/test
        public List<TestModel> GetTests()
        {
            //List<TestModel> liste = new List<TestModel>();
            /*liste.Add(new TestModel { ID = 42, Commentaire = "la réponse" });
            liste.Add(new TestModel { ID = 39, Commentaire = "température actuelle" });
            liste.Add(new TestModel { ID = 98, Commentaire = "au hasard" });*/

            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));
            #region caché!!!

            return (from x in doc.Descendants("Test")
                    select new TestModel
                    {
                        ID = int.Parse(x.Element("ID").Value),
                        Commentaire = x.Element("Commentaire").Value
                    }).ToList();

            /*return doc.Descendants("Test").Select(x => new TestModel
            {
                ID = int.Parse(x.Element("ID").Value),
                Commentaire = x.Element("Commentaire").Value
            }).ToList();


            var elements = doc.Root.Elements();
            foreach (var item in elements)
            {
                var test = new TestModel
                {
                    ID = int.Parse(item.Element("ID").Value),
                    Commentaire = item.Element("Commentaire").Value
                };
                liste.Add(test);
            }*/
            

            #endregion

            //return liste;
        }

        //GET: api/test/42
        [ResponseType(typeof(TestModel))]
        public IHttpActionResult GetTest(int id)
        {
            if(id == 42)
            {
                return NotFound();
            }

            return Ok(new TestModel { ID = id, Commentaire = "Bravo" });
        }


        //POST: api/test
        [ResponseType(typeof(TestModel))]
        public IHttpActionResult PostTest(TestModel test)
        {
            if(test.ID != 0)
            {
                return BadRequest();
            }
            test.ID = 101;

            return CreatedAtRoute("DefaultApi", new { id = test.ID }, test);
        }



    }
}
