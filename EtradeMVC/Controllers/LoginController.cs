using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Etrade.Business.Abstract;
using ETrade.DataAccess.Abstract;
using ETrade.Entities.Concrete;
using EtradeMVC.Filters;
using EtradeMVC.Models;

namespace EtradeMVC.Controllers
{
    public class LoginController : Controller
    {
      private IMemberService _memberService;
      private IMemberDal _memberDal;

      
        public LoginController(IMemberService memberService, IMemberDal memberDal)
        {
            _memberService = memberService;
            _memberDal = memberDal;
        }

        //Get:Login
        public ActionResult Login()
        {
            return View(new MemberAddViewModelcs());
        }

        [HttpPost]
      //  [ExceptionHandlerAttribute]
        public ActionResult Login(Member member)
        {
            if (_memberService.GetByUserNameAndPassword(member.UserName, member.Password) != null  )
            {
                if (_memberDal.Get(x=>x.RoleId==3)!=null)
                {
                    return Redirect("Home/Add");
                }

                return Redirect("Shoping/Index");

            }

            Response.Write("hatalı giriş yaptınız");
            return View(new MemberAddViewModelcs());
            
        }

    }
}
