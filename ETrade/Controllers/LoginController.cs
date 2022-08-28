using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Etrade.Business.Abstract;
using ETrade.Entities.Concrete;
using MemberRegistration.MvcWebUı.Models;

namespace ETrade.Controllers
{
    public class LoginController : Controller
    {
        private IMemberService _memberService;
      
        public LoginController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        //Get:Login
        public ActionResult Login()
        {
            return View(new MemberAddViewModel());
        }
        [HttpPost]
        public ActionResult Login(Member member)
        {
            if (_memberService.GetByUserNameAndPassword(member.UserName, member.Password) != null)
            {
                return Redirect("HomePage/HomePage");
            }
            return View(new MemberAddViewModel());
        }
    }
}