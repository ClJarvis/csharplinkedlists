using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private IEnumerable<object> collection;
        private SinglyLinkedListNode first_node;

      

        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(string value)
        {
            if (this.First() == null)
            { 
            first_node = new SinglyLinkedListNode(value);
            }
            else {
                var node = this.first_node;
                while (!node.IsLast()) //another way to do this.
                {
                    node = node.Next;
                }
                node.Next = new SinglyLinkedListNode(value);
            }
    }
        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
        //if the list is empty
        // this.Count() == 0
        if  (this.First() == null)
            {
                return 0;
            } else
            {
                int length = 1;
                var node = this.first_node;
                //Complexity is O(n)
                while(node.Next != null)
                {
                    length++;
                    node = node.Next;
                }
                return length; 
            }
                    //provide a scecond Implementation for homework
        }

        public string ElementAt(int index)
        {
            if (this.First() == null)
            {
                throw new ArgumentOutOfRangeException();
            } else
            {

                var node = this.first_node;

                for (var i = 0; i <=index; i++)
                {
                    if (i == index)
                    {
                        break;
                    }
                    node = node.Next;
                }
                return node.Value;
            }
        }


        public string First()
        {
            if (this.first_node == null)
            {
                return null;
            }
            else
            {
                return this.first_node.Value;
            }
            // return this.first_node ? null : this.first_node.Value;
        }
        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {

            //step 1 Do I need to loop???
            //Step 2 If Yes do I alredy have the code an example of how? MOST IMPORTANT if dont undertsand code but knows what it does.
            //step 3 How can i modify the previous examples
            //4 write what I think works
            //5 rebuld/ rerun test
            //6 rinse and repeat

            var node = this.first_node;
            if (node == null)
            {
                return null;
            } else
            {
                while (!node.IsLast())
                {
                    node = node.Next;
                }
                return node.Value;
            }

        }

        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
          Array  Array = new Array [0];
            var node = this.first_node;
            if (node == null) ;
                return null;
        }

        /// Homework pass test 26-28 using StringBuilder /////////////////////

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            //  { "{", " ", "\"", ",", "foo" };
            // strBuilder.Append("{");
           // strBuilder.Append(" ");
            var opening = "{";
            var ending = "}";
            var space = " ";
            var output = "";  //EXCESS ?
            var quote = "\"";
            var comma = "," + space;
            var node = this.first_node;
            // output += opening;
            strBuilder.Append(opening); //.Append(space).Append(ending);
            if (this.Count() >= 1)
            {
               strBuilder.Append(space);
                while (!node.IsLast()) //;
                {
                    strBuilder.Append(quote).Append(node.Value).Append(quote).Append(comma);
                    node = node.Next;
                }
                strBuilder.Append(quote).Append(this.Last()).Append(quote);
            }
            strBuilder.Append(space);
            strBuilder.Append(ending);

            return strBuilder.ToString();

        }




            /*     foreach (row in strBuilder)
                {
                    str.Append(row.strBuilder);
                }

                string finalName = sb.ToString();

               int count = 0;
                    foreach (var item in collection)
                    {
                        count += 1;
                        return strBuilder.ToString();
                    } */

            /* strBuilder.Append("\"");
             strBuilder.Append("foo"); 
             strBuilder.Append("\"");
             strBuilder.Append(" ");
             strBuilder.Append("\"");
             strBuilder.Append("bar");
             strBuilder.Append("\"");
             strBuilder.Append(" ");
             strBuilder.Append("\"");
             strBuilder.Append("grille");
             strBuilder.Append("\"");
             strBuilder.Append(" "); */
        }
   
    }


        /*
        foreach (var item in collection)
                {
                return strBuilder.ToString();
            }
            */

        /* strBuilder.Append("}");
           strBuilder.Append(" ");
           strBuilder.Append("");
           strBuilder.Append("\"");
           strBuilder.Append(",");
           strBuilder.Append(" "); */



        ///// To String works IN Class///////////////////////////////////
        /*
        public override string ToString()
        {
            var opening = "{";
            var ending = "}";
            var space = " ";
            var output = "";
            var quote = "\"";
            var comma = "," + space;
            var node = this.first_node;
            output += opening;
            if (this.Count() >= 1)
            {
                output += space;
                    while (!node.IsLast())
                    {
                        output += quote + node.Value + quote + comma;
                        node = node.Next;
                    }
                output += quote + this.Last() + quote;
            }
            output += space;
            output += ending;
            return output;
        }
        */
    //}
//}
