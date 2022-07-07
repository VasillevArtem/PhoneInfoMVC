using Microsoft.AspNetCore.Mvc;
using PhoneInfoMVC.Models;

namespace PhoneInfoMVC.Controllers
{
    public class TellInfoController : Controller
    {
        private ITellInfoRepository repository;

        public TellInfoController(ITellInfoRepository repo)
        {
            repository = repo; 
        }

        public ViewResult List() => View(repository.TellInfo);
    }
}
