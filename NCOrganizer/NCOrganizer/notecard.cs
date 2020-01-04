using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCOrganizer
{
    class Notecard
    {
        private string title;
        private string location;
        private string category;
        private string date;

        public void setTitle(string t)
        {
            this.title = t;
        }

        public void setLocation(string l)
        {
            this.location = l;
        }

        public void setCategory(string c)
        {
            this.category = c;
        }

        public void setDate(string d)
        {
            this.date = d;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getLocation()
        {
            return this.location;
        }

        public string getCategory()
        {
            return this.category;
        }

        public string getDate()
        {
            return this.date;
        }
    }
}
