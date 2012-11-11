using System.Web.Mvc;
using ITAD_2012.Models;
using ITAD_2012.Repositories;
using ITAD_2012.Repositories.Abstract;
using ITAD_2012.ViewModels.Questionnaire;

namespace ITAD_2012.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireRepository _repository;

        public QuestionnaireController()
        {
            _repository = new QuestionnaireRepository();
        }

        public ActionResult Index()
        {
            return View(CreateIndexViewModel(_repository.GetQuestionnaire()));
        }

        [HttpPost]
        public ActionResult Save(Questionnaire questionnaire)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(questionnaire);

                return RedirectToAction("Index");
            }

            return View("Index", CreateIndexViewModel(questionnaire));
        }

        private Index CreateIndexViewModel(Questionnaire questionnaire)
        {
            QuestionnaireStatus questionnaireStatus = _repository.GetQuestionnaireStatus();

            return new Index { Questionnaire = questionnaire, QuestionnaireStatus = questionnaireStatus };
        }
    }
}