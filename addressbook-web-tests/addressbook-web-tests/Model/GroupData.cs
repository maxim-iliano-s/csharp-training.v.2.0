﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addressbook_web_tests
{
    public class GroupData : IEquatable<GroupData> , IComparable<GroupData>
    {
        private string name = "";
        private string header = "";
        private string footer = "";

		public GroupData(string name)
        {
            this.name = name;
        }

        public GroupData(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }

        //public string Name  {get => name; set => name = value;}
        public string Name { get => name; set => name = value; }
        public string Header { get => header; set => header = value; }
        public string Footer { get => footer; set => footer = value; }
        public string Id{ get; set; }


        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                MessageBox.Show("In 'Equals' if second value = null ", "GroupData");
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                MessageBox.Show("In 'Equals' if second value is the first ", "GroupData");
                return true;
            }
            MessageBox.Show("In 'Equals' if second value == the first ", "GroupData");
            return Name == other.Name;
        }

        public override int GetHashCode()
        {
            MessageBox.Show("In 'GetHashCode' ", "GroupData");
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return "name=" + Name; 
        }

        public int CompareTo(GroupData other)
        {
            if(Object.ReferenceEquals(other, null))
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }

    }
}