using GameDeckBusiness;
using Modele;
using Modele.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDeckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Manager.GetInstance().GetAllJeux();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
