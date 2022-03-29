using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Subject
    {
        private int _position;
        public Subject()
        { }
        public Subject(string name, string teacher, int position)
        {
            Name = name;
            Teacher = teacher;
            Position = position;
        }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _position = value;
            }
        }
    }
}