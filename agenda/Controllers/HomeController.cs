using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agenda.Models;
using agenda.DAO;

namespace agenda.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult index()
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            IList<Contato> contatos = contatoDAO.readContato();
            ViewBag.Contatos = contatos;
            return View();
        }
        public ActionResult form()
        {

            ViewBag.Contato = new Contato();
            return View();
        }
        [HttpPost]
        public ActionResult cadastro(Contato contato)
        {
            if (ModelState.IsValid)
            {
                ContatoDAO contatoDAO = new ContatoDAO();
                contatoDAO.createContato(contato);

                return RedirectToAction("index");
            }

            else
            {
                ViewBag.Contato=contato;
                return View("Form");
            }
        }
        [HttpGet]
        public ActionResult pesquisa(string termo)
        {
            ContatoDAO daoContato = new ContatoDAO();
            ViewBag.Busca=daoContato.searchContato(termo);

            return View();
        }

        public ActionResult deletar(int id)
        {

            ContatoDAO daoContato = new ContatoDAO();
            daoContato.deleteContato(daoContato.searchContatoById(id));
            return RedirectToAction("Index");
        }

        public ActionResult editar(int id)
        {
            ContatoDAO daoContato = new ContatoDAO();
            Contato contato = daoContato.searchContatoById(id);
            ViewBag.Contato = contato;
            return View(); 
        }
        [HttpPost]
        public ActionResult update(Contato contato)
        {
            if (ModelState.IsValid)
            {
                ContatoDAO daoContato = new ContatoDAO();
                daoContato.updateContato(contato);
                return RedirectToAction("index");
            }
            else
            {
                ViewBag.Contato = contato;
                return View("Editar");
            }

        }

    }
}
