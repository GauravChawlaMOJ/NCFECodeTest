namespace Ncfe.CodeTest
{
    public class LearnerResponse
    {
        public bool IsArchived { get; set; }

        public Learner Learner { get; set; }
        public LearnerResponse(int learnerId)
        {
            Learner = new Learner(learnerId);
        }
    }
}
