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

        [TestMethod]
        public void ShouldSortStudentsDependingOnGeneralAverageGrade()
        {
            var students = new Student[] {
                new Student("Catalin", new Class[]{
                new Class("English", new double[] { 9, 10, 8 }),
                new Class("French", new double[] { 10, 8 }),
                new Class("Informatics", new double[] { 4, 6, 6, 4 })}),
                new Student("Raul", new Class[]{
                new Class("Math", new double[] { 5, 6, 4 }),
                new Class("Biology", new double[] { 7, 6, 8 }),
                new Class("Chemistry", new double[] { 5, 7, 6 }) }),
                new Student("Mircea", new Class[]{
                new Class("English", new double[] {6, 4, 8}),
                new Class("French", new double[] {6, 6})}),
                new Student("Andrei", new Class[]{
                new Class("Physics", new double[] { 7, 9 }),
                new Class("Spanish", new double[] { 9, 9 }),
                new Class("History", new double[] { 8, 10 }),
                new Class("Sports", new double[] { 10, 10 }),
                new Class("Economy", new double[] { 9, 1, 5 }) }),
                new Student("Paul", new Class[] {
                new Class("History", new double[] {4, 8}),
                new Class("French", new double[] {10, 2}) }) };
            Assert.AreEqual(new NameAndGeneralAverageGrade("Andrei", 8), Sort(students));
            CollectionAssert.AreEqual(new NameAndGeneralAverageGrade[] {
            new NameAndGeneralAverageGrade("Mircea", 6), new NameAndGeneralAverageGrade("Raul", 6), new NameAndGeneralAverageGrade("Paul", 6) }, FindTheSmallestGeneralAverageGrades(students));
        }

        [TestMethod]
        public void ShouldSortAlphabetically()
        {
            CollectionAssert.AreEqual(new string[] { "Andrei", "Bogdan", "Ciprian", "Daniel" }, SortAlphabetically(new string[] { "Ciprian", "Bogdan", "Daniel", "Andrei" }));
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

        public struct NameAndGeneralAverageGrade
        {
            public string name;
            public int generalAverageGrade;

            public NameAndGeneralAverageGrade(string name, int generalAverageGrade)
            {
                this.name = name;
                this.generalAverageGrade = generalAverageGrade;
            }
        }

        public static NameAndGeneralAverageGrade[] FindTheSmallestGeneralAverageGrades(Student[] students)
        {
            NameAndGeneralAverageGrade[] results = new NameAndGeneralAverageGrade[0];
            NameAndGeneralAverageGrade result = new NameAndGeneralAverageGrade(students[0].name, CalculateTheAverageGradeForOneStudent(students[0]));
            int averageGrade = 0;
            for (int i = 0; i < students.Length; i++)
            {
                int value = CalculateTheAverageGradeForOneStudent(students[i]);
                if (CalculateTheAverageGradeForOneStudent(students[i]) < result.generalAverageGrade)
                { 
                    result = new NameAndGeneralAverageGrade(students[i].name, value);
                    averageGrade = value;
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                int value = CalculateTheAverageGradeForOneStudent(students[i]);
                if (value == result.generalAverageGrade)
                {
                    Array.Resize(ref results, results.Length + 1);
                    results[results.Length - 1] = new NameAndGeneralAverageGrade(students[i].name, value);
                }
            }
            return results;
        }

        public static string[] SortAlphabetically(string[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length - 1; j++)
                {
                    if (String.Compare(students[j], students[j + 1]) > 0)
                        Swap(ref students[j], ref students[j + 1]);
                }
            }
            return students;
        }

        public static NameAndGeneralAverageGrade Sort(Student[] students)
        { 
            for (int i = 0; i < students.Length - 1; i++)
            {
                int maximum = i;
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (CalculateTheAverageGradeForOneStudent(students[j]) > CalculateTheAverageGradeForOneStudent(students[maximum]))
                        maximum = j;
                }
                if (maximum != i)
                    Swap(ref students[i], ref students[maximum]);
            }
            int bestGeneralAverageGrade = CalculateTheAverageGradeForOneStudent(students[0]);
            return new NameAndGeneralAverageGrade(students[0].name, bestGeneralAverageGrade);
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

        static void Swap(ref string first, ref string second)
        {
            string temp = first;
            first = second;
            second = temp;
        }

        static void Swap(ref Student first, ref Student second)
        {
            Student temp = first;
            first = second;
            second = temp;
        }
    }
}
