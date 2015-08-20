using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("Grade must be greater than 0.");
        }
        if (minGrade < 0)
        {
            throw new ArgumentException("Min Grade must be greater than 0.");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("Max Grade must be higher than Min Grade.");
        }
        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("Comments must not be empty string or null.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
