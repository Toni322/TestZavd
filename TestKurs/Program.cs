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
        public string GetName() {
            return _nameStud;
            }



        public override string ToString()
        { 
            return String.Format("Name: {0}, goup: {1}, age: {2}", _nameStud, _groupStud, _age);
        }
      
        //sort by name
        public int CompareTo(Student obj)
        {
            return _nameStud.CompareTo(obj._nameStud);
        }

    }

    class Teacher {
        String _nameTeach ;
        List<Student> _students;
        public Teacher(String name)
        {
            _nameTeach = name;
            _students = new List<Student>();
        }
        
        //add new stud
        public void AddStudent(Student a) {
            _students.Add(a);
        }

        public void SortByName() {
            _students.Sort();
        }

        public void Output() {
            foreach (Student i in _students)
            {
                Console.WriteLine(" " + i);
            }
        }
       


    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher tch = new Teacher("Karl");
            Student qwe = new Student("sss","fff", 25);
            //Console.WriteLine(qwe);
            Console.WriteLine(qwe);


            Console.ReadKey();

        }
    }
}
