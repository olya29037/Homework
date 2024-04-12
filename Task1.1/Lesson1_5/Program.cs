using Lesson1_5.Homework;

class Program
{
    static void Main()
    {
        CurriculumVitae cv1 = new CurriculumVitae();
        cv1.DisplayCV();

        CurriculumVitae cv2 = new CurriculumVitae("Game Design", "4 years");
        cv2.DisplayCV();

        Console.WriteLine("Years of experience: " + cv2.CalculateExperienceYears());
    }
}