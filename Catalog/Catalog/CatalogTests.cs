using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Catalog
{
    [TestClass]
    public class CatalogTests
    {
        [TestMethod]
        public void ShouldCalculateGeneralAverageGradeOfOneStudent()
        {
            Assert.AreEqual(7.5, CalculateTheAverageGradeForOneStudent(new Student("Ion", new Class[] {
                new Class(Domain.Math, new int[] { 5, 6, 4 }),
                new Class(Domain.Biology, new int[] { 7, 6, 8 }),
                new Class(Domain.Chemistry, new int[] { 5, 7, 6 }),
                new Class(Domain.English, new int[] { 9, 10, 8 }),
                new Class(Domain.French, new int[] { 10, 8 }),
                new Class(Domain.Informatics, new int[] { 4, 6, 6, 4 }),
                new Class(Domain.Physics, new int[] { 7, 9 }),
                new Class(Domain.Spanish, new int[] { 9, 9 }),
                new Class(Domain.Philosophy, new int[] { 9, 7 }),
                new Class(Domain.History, new int[] { 8, 10 }),
                new Class(Domain.Sports, new int[] { 10, 10 }),
                new Class(Domain.Economy, new int[] { 9, 1, 5 })})));
        }
        [TestMethod]
        public void ShouldReturnAverage()
        {
            Assert.AreEqual(3, CalculateTheAverageGradeForOneStudent(new Student("Ion", new Class[] {
                new Class(Domain.Math, new int[] { 1, 2, 3 }),
                new Class(Domain.Biology, new int[] { 2, 3, 4 }),
                new Class(Domain.Chemistry, new int[] { 3, 4, 5 }) })));
        }
        
        public struct Student
        {
            public string name;
            public Class[] classes;

            public Student(string name, Class[] classes)
            {
                this.name = name;
                this.classes = classes;
            }
        }

        public struct Class
        {
            public Domain name;
            public int[] grades;

            public Class(Domain name, int[] grades)
            { 
                this.name = name;
                this.grades = grades;
            }
        }

        public enum Domain
        {
            Math,
            Physics,
            Chemistry,
            Biology,
            English,
            French,
            Spanish,
            Informatics,
            Economy,
            Philosophy,
            History,
            Sports
        }

        static double CalculateTheAverageGradeForOneStudent(Student student)
        {
            double totalGrade = 0;
            for (int i = 0; i < student.classes.Length; i++)
            {
                int domainGrade = 0;
                for (int j = 0; j < student.classes[i].grades.Length; j++)
                {
                    domainGrade += student.classes[i].grades[j];
                }
                domainGrade /= student.classes[i].grades.Length;
                totalGrade += domainGrade;
            }
            return totalGrade / student.classes.Length;
        }
    }
}
