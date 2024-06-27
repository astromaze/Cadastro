using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Astromaze.Models;

namespace Astromaze.Controllers
{
    public class ClienteController : Controller
    {
        public void IniciarLista()
        {
            if (Session["Clientes"] == null)
                Session["Clientes"] = new List<Cliente>();
        }
        // GET: Cliente
        public ActionResult Index()
        {
            IniciarLista();
            return View(Session["Clientes"]);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            IniciarLista();
            return View((Session["Clientes"] as List<Cliente>).ElementAt(id));
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {

            var listSexo = new List<SelectListItem>();
            listSexo.Add(new SelectListItem() { Text = "Homem", Value = "Homem" });
            listSexo.Add(new SelectListItem() { Text = "Mulher", Value = "Mulher" });
            listSexo.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            ViewBag.listSexo = listSexo;

            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                IniciarLista();
                (Session["Clientes"] as List<Cliente>).Add(cliente);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {

            IniciarLista();
            var clientes = Session["Clientes"] as List<Cliente>;
            var cliente = clientes.ElementAt(id);

            var listSexo = new List<SelectListItem>();
            listSexo.Add(new SelectListItem() { Text = "Homem", Value = "Homem" });
            listSexo.Add(new SelectListItem() { Text = "Mulher", Value = "Mulher" });
            listSexo.Add(new SelectListItem() { Text = "Selecione uma opção", Value = "", Selected = true });

            ViewBag.listSexo = listSexo;

            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Cliente cliente)
        {
            try
            {
                IniciarLista();
                var lista = Session["Clientes"] as List<Cliente>;
                var listaExistente = lista.ElementAt(id);
                listaExistente.Nome = cliente.Nome;
                listaExistente.Sexo = cliente.Sexo;
                listaExistente.Idade = cliente.Idade;
                listaExistente.Tel = cliente.Tel;


                return RedirectToAction("Index");
              
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {

            IniciarLista();
            return View((Session["Clientes"] as List<Cliente>).ElementAt(id));
        
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                IniciarLista();
                var lista = Session["Clientes"] as List<Cliente>;
                lista.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
