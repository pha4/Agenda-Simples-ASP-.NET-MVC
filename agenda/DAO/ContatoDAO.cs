using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using agenda.Models;

namespace agenda.DAO
{
    public class ContatoDAO
    {
        private AgendaContext contextEF;

        public ContatoDAO(){

            this.contextEF = new AgendaContext();
        }

        public void createContato(Contato contato)
        {
            this.contextEF.Contatos.Add(contato);
            this.contextEF.SaveChanges();
            this.contextEF.Dispose();
        }

        public IList<Contato> readContato()
        {
            return this.contextEF.Contatos.ToList();

        }

        public IList<Contato> searchContato(string termo)
        {

            var busca = from contato in this.contextEF.Contatos where contato.nomeCompleto==termo select contato;
            
            return busca.ToList();


        }

        public Contato searchContatoById(int id)
        {
            return this.contextEF.Contatos.Find(id);
        }

        public void deleteContato(Contato contato)
        {
            this.contextEF.Contatos.Remove(contato);
            this.contextEF.SaveChanges();
            this.contextEF.Dispose();
        }

        public void updateContato(Contato contato)
        {
           
            this.contextEF.Entry(contato).State = System.Data.Entity.EntityState.Modified;
            this.contextEF.SaveChanges();
            this.contextEF.Dispose();
        }


    }
}