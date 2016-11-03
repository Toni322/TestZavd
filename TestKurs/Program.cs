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

        public String GetName() {
            return _nameTeach;
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

            foreach (Teacher t in teachers) { t.Output(); } 

            int i = -1;
            while (i != 0) {

                Console.WriteLine("Menu:");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Choose teacher");
                Console.WriteLine("2 - Add teacher");
                Console.WriteLine("3 - Show all students");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        c:
                        Console.WriteLine("Make you choise: ");
                        int k = -1;
                        int lich = 0;                     // dlya sh4o znizu :) 
                        foreach (Teacher t in teachers) {  Console.WriteLine(lich+"-"+t.GetName()); lich++; }
                        k = Convert.ToInt32(Console.ReadLine());
                        if (k>=lich)
                        {
                            Console.WriteLine("The wrong choice");
                            Console.WriteLine("Try again");
                            goto c; } 
                        a:
                        Console.WriteLine("1 - Show students");
                        Console.WriteLine("2 - Add student");
                        int sw = -1;
                        sw = Convert.ToInt32(Console.ReadLine());
                        switch (sw) {
                            case 1:
                                teachers[k].Output();
                                break;
                            case 2:
                                Console.WriteLine("Enter the name of the student");
                                String nameS = Console.ReadLine();
                                Console.WriteLine("Enter the group of the student");
                                String group = Console.ReadLine();
                                Console.WriteLine("Enter the age of the student");
                                int age = Convert.ToInt32(Console.ReadLine());
                                teachers[k].AddStudent(new Student(nameS,group,age));

                                break;
                            default:
                                Console.WriteLine("The wrong choice");
                                Console.WriteLine("Try again");
                                goto a;
                                break;

                        }
                     break;

                    case 2:
                        Console.WriteLine("Enter the name of the teacher");
                        String nameT = Console.ReadLine();
                        Teacher nov = new Teacher(nameT);
                        teachers.Add(nov);

                        b:
                        Console.WriteLine("Add new student?");
                        Console.WriteLine("1-Yes");
                        Console.WriteLine("2-No");
                        int sw1 = Convert.ToInt32(Console.ReadLine());

                        switch (sw1) {
                            case 1:
                                Console.WriteLine("Enter the name of the student");
                                String nameS1 = Console.ReadLine();
                                Console.WriteLine("Enter the group of the student");
                                String group1 = Console.ReadLine();
                                Console.WriteLine("Enter the age of the student");
                                int age1 = Convert.ToInt32(Console.ReadLine());
                                nov.AddStudent(new Student (nameS1,group1,age1));
                                goto b;
                                break;

                            case 2:

                                break;

                        }
                        break;
                    case 3:
                        foreach (Teacher t in teachers) { t.Output(); }
                        break;
                }

            }
                        /////
        }
    }
}
