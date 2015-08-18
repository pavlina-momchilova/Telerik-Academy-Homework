using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName 
    {
        get
        {
            return this.firstName;
        }

        set
        {
            if (this.firstName == null)
            {
                throw new ArgumentNullException("firstname", "firstname cannot be null!");
            }

            if (this.firstName == string.Empty)
            {
                throw new ArgumentException("firstname cannot be empty!");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }

        set
        {
            if (this.lastName == null)
            {
                throw new ArgumentNullException("firstname", "firstname cannot be null!");
            }

            if (this.lastName == string.Empty)
            {
                throw new ArgumentException("firstname cannot be empty!");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get
        {
            return this.exams;
        }

        set
        {
            if (this.exams == null)
            {
                throw new ArgumentNullException("Exam", "Exam cannot be null!");
            }

            this.exams = value;
        } 
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();

        if (this.exams.Count == 0)
        {
            Console.WriteLine("The student has no exams!");
            return null;
        }

        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams == null)
        {
            // Cannot calculate average on missing exams
            throw new ArgumentNullException("Exam", "Exam cannot be null!");
        }

        if (this.Exams.Count == 0)
        {
            return 0;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
