using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade must be a positive number.");
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The min grade must be a positive number.");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The max grade must be bigger than the min grade.");
        }

        if (string.IsNullOrEmpty(comments))
        {
            throw new ArgumentNullException("There must be comments.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
