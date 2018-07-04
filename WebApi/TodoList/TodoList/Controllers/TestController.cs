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
            //Récupérer le doc XML
            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //Chercher la valeur max des ID des éléments "TEST"
            var idMax = doc.Descendants("Test").Max(x => int.Parse(x.Element("ID").Value));
            #region Max sans linq
            /*int max = 0;
            foreach (var elem in doc.Descendants("Test"))
            {
                int valeurID = int.Parse(elem.Element("ID").Value);
                if (valeurID > max)
                    max = valeurID;
            }*/
            #endregion
            //incrémentation
            idMax++;

            test.ID = idMax;

            //Création d'une balise XML "Test"
            XElement element = new XElement("Test");

            //Création des balises enfants "ID" et "Commentaire" avec les valeurs
            element.Add(new XElement("ID", test.ID));
            element.Add(new XElement("Commentaire", test.Commentaire));

            //Ajouter la nouvelle balise dans la balise "Tests"
            doc.Element("Tests").Add(element);

            //Sauvegarder le fichier
            doc.Save(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //Renvoyer un code 201 "Created" avec l'objet mis à jour
            return CreatedAtRoute("DefaultApi", new { id = test.ID }, test);
        }

        //PUT: api/test/1
        [ResponseType(typeof(TestModel))]
        public IHttpActionResult PutTest(int id, TestModel test)
        {
            //Tester l'id et id de test et retourner 400 si faux
            if (id != test.ID)
                return BadRequest();

            //Récupérer le doc XML
            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //Recherche un element par rapport à l'id
            var elementAModifie = doc.Descendants("Test").SingleOrDefault(x => int.Parse(x.Element("ID").Value) == id);

            if (elementAModifie == null)
                return BadRequest();

            //Remplacer la valeur de commentaire dans l'élément par celle du test
            elementAModifie.Element("Commentaire").Value = test.Commentaire;

            //Sauvegarder le doc
            doc.Save(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //retourer le code 204
            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(TestModel))]
        public IHttpActionResult DeleteTest(int id)
        {
            //Récupérer le doc XML
            XDocument doc = XDocument.Load(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //Recherche un element par rapport à l'id
            var elementASupprime = doc.Descendants("Test")
                .SingleOrDefault(x => int.Parse(x.Element("ID").Value) == id);

            if (elementASupprime == null)
                return BadRequest();

            //Supprimer l'élément
            elementASupprime.Remove();

            //Sauvegarder le doc
            doc.Save(System.Web.Hosting.HostingEnvironment.MapPath("~/donnees.xml"));

            //retourer le code 200 avec l'objet supprimé
            return Ok(new TestModel {
                ID = id,
                Commentaire = elementASupprime.Element("Commentaire").Value
            });
        }
    }
}
