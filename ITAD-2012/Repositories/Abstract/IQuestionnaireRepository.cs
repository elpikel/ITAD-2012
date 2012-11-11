using System.Collections.Generic;
using ITAD_2012.Models;

namespace ITAD_2012.Repositories.Abstract
{
    public interface IQuestionnaireRepository
    {
        List<Questionnaire> GetAllQuestionnaires();
        void Save(Questionnaire questionnaire);
        Questionnaire GetQuestionnaire();
        QuestionnaireStatus GetQuestionnaireStatus();
    }
}