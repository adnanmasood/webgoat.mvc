using System.Collections.Generic;
using System.Linq;

namespace WebGoat.MVC.Models.Repositories
{
    public class CreditCardRepository : ICreditCardRepository
    {
        private MyCoolDbEntities _db = null;

        public CreditCardRepository()
        {
            
        }

        #region IRepository<CreditCard> Members


        public CreditCard GetById(int id)
        {
            using (_db = new MyCoolDbEntities())
            {
                return _db.CreditCards.Where(c => c.Id == id).SingleOrDefault();
            }
        }

        public void Insert(CreditCard model)
        {
            using (_db = new MyCoolDbEntities())
            {
                _db.CreditCards.AddObject(model);
                _db.SaveChanges();
                
            }
        }

        public void Delete(CreditCard model)
        {
            using (_db = new MyCoolDbEntities())
            {
                var entity = _db.CreditCards.Where(c => c.Id == model.Id).SingleOrDefault();
                _db.CreditCards.DeleteObject(entity);
                _db.SaveChanges();
            }
        }

        public void Update(CreditCard entity)
        {
            using (_db = new MyCoolDbEntities())
            {
                _db.CreditCards.Attach(entity);
                _db.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                _db.CreditCards.ApplyCurrentValues(entity);
                _db.SaveChanges();
            }
        }

        #endregion


        #region IRepository<CreditCard> Members

        public List<CreditCard> GetAll()
        {
            using (_db = new MyCoolDbEntities())
            {
                return _db.CreditCards.ToList();
            }
        }

        #endregion
    }
}