using Astromaze.Models.Conn;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Astromaze.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Astromaze()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void Index(object sender, EventArgs e) 
        {
            if (Conectar())
            {
                MessageBox.Show("A APLICAÇÃO ESTÁ CONECTADA AO BANCO");
            }
        }

        private bool Conectar()
        {
            var result = false;

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn))
                {
                    cn.Open();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha " + ex.Message);
            }

            return result;

        }
    }
}