using Lesson1_5.Homework;

namespace Lesson1_5.Homework;

    class CurriculumVitae
    {
        public const string Name = "Olya Terebei";

        public string Education { get; set; }
        public string Experience { get; set; }

        public CurriculumVitae()
        {
            Education = "Law";
            Experience = "Game Designer";
        }

        public CurriculumVitae(string education, string experience)
        {
            Education = education;
            Experience = experience;
        }

        public void DisplayCV()
        {
            Console.WriteLine("Curriculum Vitae:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Education: " + Education);
            Console.WriteLine("Experience: " + Experience);
        }

        public void FillCV(string education, string experience)
        {
            Education = education;
            Experience = experience;
        }

        public int CalculateExperienceYears()
        {
            int index = Experience.IndexOf(" years");
            if (index != -1)
            {
                string yearsString = Experience.Substring(0, index);
                int years;
                if (int.TryParse(yearsString, out years))
                {
                    return years;
                }
            }
            return 0;
        }
    }

    class Curriculum
    {
        static void Calculate()
        {
            CurriculumVitae cv1 = new CurriculumVitae();
            cv1.DisplayCV();

            CurriculumVitae cv2 = new CurriculumVitae("Game Design", "4 years");
            cv2.DisplayCV();

            Console.WriteLine("Years of experience: " + cv2.CalculateExperienceYears());
        }
    }