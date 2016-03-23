using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void ShouldCalculateGeneralAverageGrade()
        {
            Assert.AreEqual(9, CalculateTheAverageGradeForOneSubject(new Student("Ion", new int[] { 9, 8, 10 })));
        }
        
        public struct Student
        {
            public string name;
            public int[] grades;

            public Student(string name, int[] grades)
            {
                this.name = name;
                this.grades = grades;
            }
        }

        static int CalculateTheAverageGradeForOneSubject(Student student)
        {
            int totalGrade = 0;
            for (int i = 0; i < student.grades.Length; i++)
            {
                totalGrade += student.grades[i];
            }
            return totalGrade / student.grades.Length;
        }
    }
}
