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
            Assert.AreEqual(7, CalculateTheAverageGradeForOneStudent(new Student("Ion", new Class[] {
                new Class("Math", new double[] { 5, 6, 4 }),
                new Class("Biology", new double[] { 7, 6, 8 }),
                new Class("Chemistry", new double[] { 5, 7, 6 }),
                new Class("English", new double[] { 9, 10, 8 }),
                new Class("French", new double[] { 10, 8 }),
                new Class("Informatics", new double[] { 4, 6, 6, 4 }),
                new Class("Physics", new double[] { 7, 9 }),
                new Class("Spanish", new double[] { 9, 9 }),
                new Class("History", new double[] { 8, 10 }),
                new Class("Sports", new double[] { 10, 10 }),
                new Class("Economy", new double[] { 9, 1, 5 })})));
        }
        [TestMethod]
        public void ShouldReturnAverage()
        {
            Assert.AreEqual(3, CalculateTheAverageGradeForOneStudent(new Student("Ion", new Class[] {
                new Class("Math", new double[] { 1, 2, 3 }),
                new Class("Biology", new double[] { 2, 3, 4 }),
                new Class("Chemistry", new double[] { 3, 4, 5 }) })));
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
            public string name;
            public double[] grades;

            public Class(string name, double[] grades)
            {
                this.name = name;
                this.grades = grades;
            }
        }

        static int CalculateTheAverageGradeForOneStudent(Student student)
        {
            double totalGrade = 0;
            for (int i = 0; i < student.classes.Length; i++)
            {
                double domainGrade = CalculateDomainGrade(student.classes[i]);
                totalGrade += domainGrade;
            }
            return (int)totalGrade / student.classes.Length;
        }

        static double CalculateDomainGrade(Class domain)
        {
            double result = 0;
            for (int i = 0; i < domain.grades.Length; i++)
            {
                result += domain.grades[i];
            }
            result /= domain.grades.Length;
            return result;
        }

    }
}
