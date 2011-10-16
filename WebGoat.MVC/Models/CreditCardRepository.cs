using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace WebGoat.MVC.Models
{ 
    public class CreditCardRepository : ICreditCardRepository
    {
        //WebGoatMVCContext context = new WebGoatMVCContext();
        MyCoolDbEntities context = new MyCoolDbEntities();

        public IQueryable<CreditCard> All
        {
            get { return context.CreditCards; }
        }

        public IQueryable<CreditCard> AllIncluding(params Expression<Func<CreditCard, object>>[] includeProperties)
        {
            IQueryable<CreditCard> query = context.CreditCards;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CreditCard Find(int id)
        {
            //return context.CreditCards.Find(id);
            return context.CreditCards.Where(c => c.Id == id).SingleOrDefault();
        }

        public void InsertOrUpdate(CreditCard creditcard)
        {
            if (creditcard.Id == default(int)) {
                // New entity
                //context.CreditCards.Add(creditcard);
                context.CreditCards.AddObject(creditcard);
            } else {
                // Existing entity
                //context.Entry(creditcard).State = EntityState.Modified;
                
            }
        }

        public void Delete(int id)
        {
            //var creditcard = context.CreditCards.Find(id);
            //context.CreditCards.Remove(creditcard);

            var creditcard = context.CreditCards.Where(c => c.Id == id).SingleOrDefault();
            context.CreditCards.DeleteObject(creditcard);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICreditCardRepository
    {
        IQueryable<CreditCard> All { get; }
        IQueryable<CreditCard> AllIncluding(params Expression<Func<CreditCard, object>>[] includeProperties);
        CreditCard Find(int id);
        void InsertOrUpdate(CreditCard creditcard);
        void Delete(int id);
        void Save();
    }
}