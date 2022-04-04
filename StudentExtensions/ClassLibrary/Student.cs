using System;
namespace ClassLibrary
{
    public class Student
    {
        public Student(string fullName, string groupNo, byte age)
        {
            this.FullName = fullName;
            this.GroupNo = groupNo;
            this.Age = age;
        }

        private string _fullName;
        private string _groupNo;

        public string FullName {
            get=>_fullName;
            set
            {
                if (value.CheckFullname())
                {
                    _fullName = value;
                }
            }
        }

        public string GroupNo {
            get=>_groupNo;
            set
            {
                if (value.CheckGroupNo())
                {
                    _groupNo = value;
                }
            }
        }
        public byte Age { get; set; }
    }
}
