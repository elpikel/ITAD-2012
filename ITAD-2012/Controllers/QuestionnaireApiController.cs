using System.Collections.Generic;
using System.Web.Http;
using ITAD_2012.Models;
using ITAD_2012.Repositories;
using ITAD_2012.Repositories.Abstract;

namespace ITAD_2012.Controllers
{
    public class QuestionnaireApiController : ApiController
    {
        private readonly IQuestionnaireRepository _repository;

        public QuestionnaireApiController()
        {
            _repository = new QuestionnaireRepository();
        }

        public IEnumerable<Questionnaire> Get()
        {
            return _repository.GetAllQuestionnaires();
        }

        public bool Save([FromBody]Questionnaire questionnaire)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(questionnaire);

                return true;
            }

            return false;
        }
    }
}