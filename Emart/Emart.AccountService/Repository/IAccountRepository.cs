using Emart.AccountService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emart.AccountService.Repository
{
    public interface IAccountRepository
    {
      Buyer BuyerLogin(string uname, string pswd);
       Seller SellerLogin(string uname, string pswd);

        void SellerRegister(Seller sobj);
        void BuyerRegister(Buyer bobj);

    }
}
