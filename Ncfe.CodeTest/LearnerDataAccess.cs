﻿namespace Ncfe.CodeTest
{
    public class LearnerDataAccess
    {
        public LearnerResponse LoadLearner(int learnerId)
        {
            // rettrieve learner from 3rd party webservice
            LearnerResponse learnerResponse = new LearnerResponse(learnerId);
            return learnerResponse;
        }
    }
}
