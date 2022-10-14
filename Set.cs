//Corrected by <Hilary Gardiner>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Describe several debugging techniques and scenarios for their use.
//Lydia's code - find the errors!

namespace CST117_IC08_console
{
    class Set //
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {

            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
                // else return false; this is a logic error because if 'val' is not equal to the element it returns false
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }


        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            Set obj = new Set(); //created an object because you don't want to change the sets, the first set is added to the second set
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                obj.addElement(rhs.elements[i]);
                //this.addElement (rhs.elements[i]);
            }
            for (int i = 0; i < this.elements.Count; i++)
            {
                obj.addElement(this.elements[i]);
                // this.addElement (rhs.elements[i]);
            }
            return obj;
            //return rhs;
        }


    }


}

