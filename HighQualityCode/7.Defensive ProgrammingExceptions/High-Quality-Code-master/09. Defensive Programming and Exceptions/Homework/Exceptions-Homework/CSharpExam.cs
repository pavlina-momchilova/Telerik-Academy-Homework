using System;

public class CSharpExam : Exam
{
    public const int MinScore = 0;
    public const int MaxScore = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (score < 0)
            {
                throw new NullReferenceException("Score must be greater or equal to 0!");
            }
            this.score = value;
        }
    }
    public override ExamResult Check()
    {
        if (this.Score < MinScore || this.Score > MaxScore)
        {
            throw new ArgumentOutOfRangeException("Score", "Score must be greater or equal to " + MinScore + " and smaller or equal to " + MaxScore + " !");
        }
        else
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}
