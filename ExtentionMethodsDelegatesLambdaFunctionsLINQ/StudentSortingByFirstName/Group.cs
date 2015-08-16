using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSortingByFirstName
{
    public class Group
    {
        private int groupNumber;
        private string departamentName;
        private string groupName;

        public Group(string groupName, int groupNumber)
        {
            this.groupName = groupName;
            this.groupNumber = groupNumber;
        }
        public Group(int groupNumber, string departamentName)
        {
            this.groupNumber = groupNumber;
            this.departamentName = departamentName;
        }

        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set {this.groupNumber = value; }
        }
        public string DepartamentName
        {
            get { return this.departamentName; }
            set { this.departamentName = value; }
        }
    }
}
