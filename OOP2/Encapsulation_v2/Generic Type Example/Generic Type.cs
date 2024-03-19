using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_v2
{
    internal class Generic_Type
    {
        public class Student<T>
        {
            
            public T data;

            
            public Student(T data)
            {
                this.data = data;
                Console.WriteLine("Data passed: " + this.data);
            }
        }

        class Program
        {
            
            
               
                Student<string> studentName = new Student<string>("Ahmet");

                
                Student<int> studentId = new Student<int>(20);
            
        }
    }
}
