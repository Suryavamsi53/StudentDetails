using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataRetrieve
{

   
        internal class StudentData
        {
            static void Main(string[] args)
            {
                string filePath = "A:/FileHandling/Student.txt";

                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The data file does not exist. Please ensure the file is available.");
                }

                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        Console.WriteLine("Rainbow School Students Data System........ ");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine(" Student ID | Student Name | Student Age | Student Gender | Student Address | Student Courses | Student Grades");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] data = line.Split(',');

                            if (data.Length == 7)
                            {
                                if (data[0].Trim().Equals("Student Name", StringComparison.OrdinalIgnoreCase))
                            { 
                                    continue;
                                }

                              
                                string studentId = data[0].Trim();
                                string studentName = data[1].Trim();
                                string studentAge = data[2].Trim();
                                string studentGender = data[3].Trim();
                                string studentAddress = data[4].Trim();
                                string studentCourses = data[5].Trim();
                                string studentGrades = data[6].Trim();

                            Console.WriteLine($"{studentId,-10} | {studentName,-14} | {studentAge,-11} | {studentGender,-14} | {studentAddress,-15} | {studentCourses,-15} | {studentGrades,-6}");
                        }
                            else
                            {
                                Console.WriteLine("Invalid data: " + line);
                            }
                        }

                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An Error Exception Occurred: " + e.Message);
                }
            }
        }
    }
