using System;

public class ExamResult
{
    private int grade; 
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get
        {
            return this.grade;
        }

        private set
        {
            if (this.grade < 0)
            {
                throw new ArgumentException("Grade cannot be less than zero!");
            }

            this.grade = value;
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (this.minGrade < 0)
            {
                throw new ArgumentException("minGrade cannot be less than zero");
            }

            this.minGrade = value;
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (this.maxGrade <= this.minGrade)
            {
                throw new ArgumentException("max grade must bi greater than min grade");
            }

            this.maxGrade = value;
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (this.comments == null)
            {
                throw new ArgumentNullException("comments cannot be null!");
            }

            if (this.comments == string.Empty)
            {
                throw new ArgumentException("comments cannot be empty!");
            }

            this.comments = value;
        }
    }
}
