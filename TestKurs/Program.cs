using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKurs
{
    class Student : IComparable <Student> {
        String _nameStud; 
        String _groupStud;
        int _age;

        public Student(String name, String group,int age) {
            _nameStud = name;
            _groupStud = group;
            _age = age;
        }
        public string getName() {
            return _nameStud;
            }

        public override string ToString()
        { 
            return String.Format("Name: {0}, goup: {1}, age: {2}", _nameStud, _groupStud, _age);
        }

        public int CompareTo(Student obj)
        {
            return _nameStud.CompareTo(obj._nameStud);
        }

    }

    class Teacher {
        String _nameTeach;
        List<Student> _students;
        public Teacher()
        {
            _students = new List<Student>();

            Student Q = new Student("qwe", "rty", 12);
            Student Z = new Student("asd", "bbb", 21);
            _students.Add(Q);
            _students.Add(Z);
           
            _students.Sort();

            foreach (Student i in _students) {
                Console.WriteLine(" " + i);
            }
        }


       


    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher tch = new Teacher();
            Student qwe = new Student("sss","fff", 25);
            Console.WriteLine(qwe);

            Console.ReadKey();
        }
    }
}
