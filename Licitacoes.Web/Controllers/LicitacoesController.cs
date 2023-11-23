using Licitacoes.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Licitacoes.Web.Controllers
{
    public class LicitacoesController : Controller
    {
        private readonly LicitacoesService LicitacoesService = new LicitacoesService();
        public IActionResult Index()
        {
            List<Core.Models.Licitacoes> ListLicitacoes = LicitacoesService.RepositoryLicitacoes.GetAll();
            return View(ListLicitacoes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Core.Models.Licitacoes model)
        {
            if (!ModelState.IsValid)
                return View();

            LicitacoesService.RepositoryLicitacoes.Insert(model);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(LicitacoesService.RepositoryLicitacoes.GetOne(id));
        }

        public IActionResult Edit(int id)
        {
            return View(LicitacoesService.RepositoryLicitacoes.GetOne(id));
        }

        [HttpPost]
        public IActionResult Edit(Core.Models.Licitacoes model)
        {
            if (!ModelState.IsValid)
                return View();

            var obj = LicitacoesService.RepositoryLicitacoes.Update(model);
            return RedirectToAction("Details", new {obj.Id});
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            LicitacoesService.RepositoryLicitacoes.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
