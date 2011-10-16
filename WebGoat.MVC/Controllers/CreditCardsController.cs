using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGoat.MVC.Models;
using WebGoat.MVC.Models.Repositories;
using WebGoat.MVC.Code;

namespace WebGoat.MVC.Controllers
{
    public class CreditCardsController : Controller
    {
        private readonly ICreditCardRepository creditcardRepository;

        // If you are using Dependency Injection, you can delete the following constructor
        public CreditCardsController()
            : this(new CreditCardRepository())
        {
        }

        public CreditCardsController(ICreditCardRepository creditcardRepository)
        {
            this.creditcardRepository = creditcardRepository;
        }

        //
        // GET: /CreditCards/

        public ViewResult Index()
        {
            var list = creditcardRepository.GetAll();

            List<CreditCardViewModel> listModel = new List<CreditCardViewModel>();
            foreach (var item in list)
            {
                listModel.Add(new CreditCardViewModel()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    CreditCardNumber = item.CreditCardNumber
                });

            }

            return View(listModel);
        }

        //
        // GET: /CreditCards/Details/5

        public ViewResult Details(int id)
        {
            return View(creditcardRepository.GetById(id));
        }

        //
        // GET: /CreditCards/Create

        public ActionResult Create()
        {
            return View(new CreditCard());
        }

        //
        // POST: /CreditCards/Create

        [HttpPost]
        public ActionResult Create(CreditCard creditcard)
        {
            if (ModelState.IsValid)
            {
                //creditcard.CreditCardNumber = Utility.Encrypt(creditcard.CreditCardNumber);
                //creditcard.IV = Utility.GetIV();

                creditcardRepository.Insert(creditcard);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /CreditCards/Edit/5

        public ActionResult Edit(int id)
        {
            var creditcard = creditcardRepository.GetById(id);
            //creditcard.CreditCardNumber = Utility.Decrypt(creditcard.CreditCardNumber, creditcard.IV);

            return View(creditcard);
        }

        //
        // POST: /CreditCards/Edit/5

        [HttpPost]
        public ActionResult Edit(CreditCard creditcard)
        {
            if (ModelState.IsValid)
            {
                //creditcard.CreditCardNumber = Utility.Encrypt(creditcard.CreditCardNumber);
                //creditcard.IV = Utility.GetIV();

                creditcardRepository.Update(creditcard);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /CreditCards/Delete/5

        public ActionResult Delete(int id)
        {
            var creditcard = creditcardRepository.GetById(id);

            //creditcard.CreditCardNumber = Utility.MaskCreditCardNumber(Utility.Decrypt(creditcard.CreditCardNumber, creditcard.IV));

            return View(creditcard);
        }

        //
        // POST: /CreditCards/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            var model = creditcardRepository.GetById(id);

            creditcardRepository.Delete(model);

            return RedirectToAction("Index");
        }
    }
}

