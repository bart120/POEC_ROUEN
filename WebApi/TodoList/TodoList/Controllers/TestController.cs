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
            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));
            /*
            TestModel test = null;

            var elements = doc.Root.Elements();
            foreach (var item in elements)
            {
                if(int.Parse(item.Element("ID").Value) == id)
                {
                    test = new TestModel
                    {
                        ID = int.Parse(item.Element("ID").Value),
                        Commentaire = item.Element("Commentaire").Value
                    };
                }
            }

            if (test == null)
            {
                return NotFound();
            }
            return Ok(test);
            */
            
            var test = doc.Descendants("Test").SingleOrDefault(
                        x => int.Parse(x.Element("ID").Value) == id);

            if (test == null)
            {
                return NotFound();
            }

            return Ok(new TestModel { ID = int.Parse(test.Element("ID").Value),
                Commentaire = test.Element("Commentaire").Value });
        }


        //POST: api/test
        [ResponseType(typeof(TestModel))]
        public IHttpActionResult PostTest(TestModel test)
        {
            if(test.ID != 0)
            {
                return BadRequest();
            }
            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));
            var idMax = doc.Descendants("Test").Max(x => int.Parse(x.Element("ID").Value));
            idMax++;
            test.ID = idMax;


            XElement element = new XElement("Test");
            element.Add(new XElement("ID", test.ID));
            element.Add(new XElement("Commentaire", test.Commentaire));
            doc.Element("Tests").Add(element);
            doc.Save(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));


            return CreatedAtRoute("DefaultApi", new { id = test.ID }, test);
        }



    }
}
