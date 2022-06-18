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
            var result = monManager.GetAllEditeurs();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(List<EditeurDto>));
        }

        [TestMethod]
        public void GetOneEditeur()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void AddEditeur()
        {
            var addItem = new EditeurDto { Nom = "Ubisoft" };
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void UpdateEditeur()
        {
            Assert.IsTrue(false);
        }

        [TestMethod]
        public void DeleteEditeur()
        {
            Assert.IsTrue(false);
        }
    }
}
