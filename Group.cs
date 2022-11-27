using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Account
{
    internal class Group
    {
        private static int _counter = 0;
        private Student[] _students = new Student[0];
        private int _studentLimit;
        private string _groupNo;

        public string GroupNo 
        {
            get 
            {
                return _groupNo;
            }
            set 
            {
                if (CheckGroupNo(value)==true)
                {
                    this._groupNo = value;
                }
                else
                {
                    Console.WriteLine("wrong group No");
                }
            }
        }


        public Group(int StudentLimit,string GroupNo)
        {
            this.StudentLimit = StudentLimit;
            this.GroupNo = GroupNo;
            Array.Resize(ref _students, _studentLimit);
        }


        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (StudentLimit>=5||StudentLimit<=18)
                {
                    this._studentLimit = value;
                }
                else
                {
                    Console.WriteLine("wrong student limit");
                }
            }
        }

        public bool CheckGroupNo(string groupNo)
        {
            Regex num = new Regex(@"[0-9]+");
            Regex up = new Regex(@"[A-Z]+");

            if (num.IsMatch(groupNo.Substring(2, 3)) && up.IsMatch(groupNo.Substring(0, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddStudent(Student student)
        {

            if (_counter!=_studentLimit)
            {
                _students[0+_counter] = student;
            }
            else
            {
                Console.WriteLine("limit of the students!");
            }
            _counter++;
        }

        public Student GetStudent(int id)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id==id)
                {
                    return _students[i];
                }
            }
            return null;    
        }

        public Student[] GetAllStudents()
        {
            return _students;
        }
    }
}
