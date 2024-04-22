using System;
namespace Lesson_10
{
    public interface IPersonManagement<T>
    {
        List<T> GetAll();
        void DisplayPerson(T person);
    }

}