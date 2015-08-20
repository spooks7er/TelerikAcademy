using System;

namespace StudentGroups
{
    public class Group
    {
        private int groupNumber;
        private Department departmentName;


        public Group(int num, Department dept)
        {
            this.GroupNumber = num;
            this.DepartmentName = dept;
        }


        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public Department DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }


    }
}
