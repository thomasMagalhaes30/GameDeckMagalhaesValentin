using GameDeckBusiness;
using GameDeckDto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GameDeckTest.TestBLL
{
    [TestClass]
    public class CrudEditeurUnitTest
    {
        [TestMethod]
        public void GetAllEditeurs()
        {
            IManager monManager = Manager.GetInstance();
            List<EditeurDto> result = monManager.GetAllEditeurs();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<EditeurDto>));
        }

        [TestMethod]
        public void GetOneEditeur()
        {
            // Ajout, get, delete
            IManager monManager = Manager.GetInstance();
            EditeurDto dto = new EditeurDto { Nom = "Bugisoft" };
            int result = monManager.AddEditeur(dto);

            EditeurDto one = monManager.GetOneEditeur(result);
            Assert.IsNotNull(one);
            Assert.IsInstanceOfType(one, typeof(EditeurDto));
            Assert.AreEqual(one.Nom, dto.Nom);

            monManager.DeleteEditeur(result);
        }

        [TestMethod]
        public void AddEditeur()
        {
            // Ajout, get, delete
            IManager monManager = Manager.GetInstance();
            EditeurDto dto = new EditeurDto { Nom = "Bugisoft" };

            int result = monManager.AddEditeur(dto);
            EditeurDto one = monManager.GetOneEditeur(result);
            Assert.IsNotNull(one);
            Assert.IsInstanceOfType(one, typeof(EditeurDto));
            Assert.AreEqual(one.Nom, dto.Nom);

            monManager.DeleteEditeur(result);
        }

        [TestMethod]
        public void UpdateEditeur()
        {
            // Ajout, upate, get, delete
            IManager monManager = Manager.GetInstance();
            EditeurDto dto = new EditeurDto { Nom = "Bugisoft" };
            int result = monManager.AddEditeur(dto);

            dto.Id = result;
            dto.Nom = "nitendort";
            monManager.UpdateEditeur(dto);

            EditeurDto one = monManager.GetOneEditeur(result);
            Assert.IsNotNull(one);
            Assert.IsInstanceOfType(one, typeof(EditeurDto));
            Assert.AreEqual(one.Nom, "nitendort");

            monManager.DeleteEditeur(result);
        }

        [TestMethod]
        public void DeleteEditeur()
        {
            // Ajout, get, delete
            IManager monManager = Manager.GetInstance();
            EditeurDto dto = new EditeurDto { Nom = "Bugisoft" };
            int result = monManager.AddEditeur(dto);
            monManager.DeleteEditeur(result);

            EditeurDto one = monManager.GetOneEditeur(result);
            Assert.IsNull(one);
        }
    }
}
