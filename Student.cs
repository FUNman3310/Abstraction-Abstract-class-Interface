using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Account
{
    internal class Student
    {
        private static int _counter;
        private int _id;
        public int Id { get { return this._id; } }
        public string Fullname;
        public double Point;

        public Student(string fullname, double point)
        {
            _counter++;
            this.Point = point;
            this.Fullname = fullname;
            this._id = _counter;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"Fullname {this.Fullname} Id {this._id} Point {this.Point}");
        }



    }
}
