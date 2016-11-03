using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKurs
{
    class Student : IComparable<Student>
    {
        String _nameStud;
        String _groupStud;
        int _age;

        public Student(String name, String group, int age)
        {
            _nameStud = name;
            _groupStud = group;
            _age = age;
        }
        public String GetName()
        {
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

        class Teacher
        {
            String _nameTeach;
            List<Student> _students;
            public Teacher(String name)
            {
                _nameTeach = name;
                _students = new List<Student>();
            }

            //add new stud
            public void AddStudent(Student a)
            {
                _students.Add(a);
            }
         
            // delete student by Name
            public void DeleteStudent(String b)
            {
            int _indx = -1;
            int _id = 0;
            foreach (Student i in _students)
            {
                if (b.Equals(i.GetName())) { _indx = _id; }
            }

            if (_indx>-1) {
                _students.Remove(_students[_indx]);
            }
            else { Console.WriteLine("Element not found"); }
            }

            public void SortByName()
            {
                _students.Sort();
            }

            

           public void Output()
        {
            Console.WriteLine("{0} teaches these students: ", _nameTeach);
            foreach (Student i in _students)
                {
                    Console.WriteLine(" " + i);
                }
            Console.WriteLine();
        }



        
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher("Albert Velosupedenko"));
            teachers.Add(new Teacher("Olexandr Kostulyov"));

            Student Andr = new Student("Andrij Kuziw","SP-41", 23);
            Student Serg = new Student("Sergiy Shmalenko", "SB-22", 19);
            Student Rom = new Student("Roman Petrosyan", "SP-11", 20);
            teachers[0].AddStudent(Andr);
            teachers[0].AddStudent(Serg);
            teachers[0].AddStudent(Rom);


            Student Oleg = new Student("Oleg Gluh", "SP-31", 22);
            Student Alina = new Student("Alina Stasyuk", "SIs-32", 21);
            Student Vit = new Student("Vitaliy Volochay", "SPs-41", 25);
            teachers[1].AddStudent(Oleg);
            teachers[1].AddStudent(Alina);
            teachers[1].AddStudent(Vit);

            teachers[0].Output();
            teachers[1].Output();
            teachers[0].SortByName();
            teachers[0].Output();
            Console.ReadKey();

        }
    }
}
