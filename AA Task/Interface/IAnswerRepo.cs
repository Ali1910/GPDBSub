﻿namespace AA_Task.Interface
{
    public interface IAnswerRepo
    {
        Tuple<bool,string> answerQuestion(int doctorId,int questionId, string content);
    }
}
