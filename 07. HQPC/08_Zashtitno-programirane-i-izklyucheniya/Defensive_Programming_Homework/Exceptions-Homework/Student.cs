using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams)
    {
        if (firstName == null || firstName == string.Empty)
        {
            throw new ArgumentNullException("firstName must not be empty string or null");
        }

        if (lastName == null || lastName == string.Empty)
        {
            throw new ArgumentNullException("lastName must not be empty string or null.");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        if (this.Exams == null)
        {
            throw new ArgumentNullException("Exam is null.");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("The student has no exams!");
        }

        IList<ExamResult> results = new List<ExamResult>();

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
            throw new ArgumentNullException("Exams == null. Cannot calculate average on missing exams");
        }

        if (this.Exams.Count == 0)
        {
            throw new ArgumentNullException("Exams.Count == 0. Cannot calculate average on missing exams");
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = ((double)examResults[i].Grade - examResults[i].MinGrade) / (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}