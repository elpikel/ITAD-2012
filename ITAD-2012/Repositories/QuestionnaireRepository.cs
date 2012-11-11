using System;
using System.Collections.Generic;
using System.Linq;
using ITAD_2012.Models;
using ITAD_2012.Repositories.Abstract;

namespace ITAD_2012.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly List<Questionnaire> _questionnaires;

        public QuestionnaireRepository()
        {
            _questionnaires = new List<Questionnaire>
                {
                    new Questionnaire
                        {
                            Id = Guid.NewGuid(),
                            Question = "Are you gay?",
                            Answer = false
                        }
                };
        }

        public List<Questionnaire> GetAllQuestionnaires()
        {
            return _questionnaires;
        }

        public Questionnaire GetQuestionnaire()
        {
            return _questionnaires.First();
        }

        public QuestionnaireStatus GetQuestionnaireStatus()
        {
            return new QuestionnaireStatus { Yes = 10, No = 15 };
        }

        public void Save(Questionnaire questionnaire)
        {
            _questionnaires.Add(questionnaire);
        }
    }
}