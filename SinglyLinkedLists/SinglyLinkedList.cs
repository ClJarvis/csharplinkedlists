using System;
using System.Collections;
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
            //test 6
            // int i = 0;
            // AddLast(values[i].ToString());
            for (int i = 0; i < values.Length; i++)
            {
               AddLast(values[i].ToString());
            }


        }

        private void publicSinglyLinkedList()
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get
            {
                return this.ElementAt(i);
            }
            set
            {
                var copy_of_list = new SinglyLinkedList();
                for (var k = 0; k < this.Count(); k++)
                {
                    if (k == i)
                    {
                        copy_of_list.AddLast(value);
                    }
                    else
                    {
                        copy_of_list.AddLast(this.ElementAt(k));
                    }
                }

                first_node = new SinglyLinkedListNode(copy_of_list.First());
                for (var Y = 1; Y < copy_of_list.Count(); Y++)
                {
                    this.AddLast(copy_of_list.ElementAt(Y));
                }
            }
        }

        public void AddAfter(string existingValue, string value)
        {
            var newNode = new SinglyLinkedListNode(value);
            var node = first_node;
            while (node != null)
            {
                if (node.Value == existingValue)
                {
                    if (node.IsLast())
                    {
                        node.Next = newNode;
                        return;
                    }
                    var capturePointer = node.Next;
                    node.Next = newNode;

                    newNode.Next = capturePointer;
                    return;
                }
                node = node.Next;
            }
            throw new ArgumentException();

        }


        public void AddFirst(string value) ////////////////Advanced linked list ///////////////
        {
            if (this.First() == null)
            {
                first_node = new SinglyLinkedListNode(value);
            }
            else
            {
                var newFirstNode = new SinglyLinkedListNode(value);

                newFirstNode.Next = this.first_node;
                first_node = newFirstNode;
            }

        }


        public void AddLast(string value)
        {
            if (this.First() == null)
            {
                first_node = new SinglyLinkedListNode(value);
            }
            else
            {
                var node = this.first_node;
                while (!node.IsLast()) //another way to do this.
                {
                    node = node.Next;
                }
                node.Next = new SinglyLinkedListNode(value);
            }
        }

        public void Last(string value)
        {
            if (this.First() == null)
            {
                first_node = new SinglyLinkedListNode(value);
            }
            else
            {
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
            if (this.First() == null)
            {
                return 0;
            }
            else
            {
                int length = 1;
                var node = this.first_node;
                //Complexity is O(n)
                while (node.Next != null)
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
            }
            else
            {

                var node = this.first_node;

                for (var i = 0; i <= index; i++)
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
            var node = this.first_node;
            if (this.Count() >= 1)
            {
                var i = 0;
                for (i = 0; i < this.Count(); i++)
                {
                    if (node.Value == value)
                    {
                        return i; //indexOf(foo??)
                    }
                     if (node.IsLast() && node.Value != value)
                    {
                       
                            return -1; //indexOf(bar&grille) 
                    }
                    node = node.Next;
                   
                }
               
            }
            if (this.Count() == 0)

                // node = node.Next;
                return -1; //changed from line above for test 15
                 {
                    var x = 0;
                    for (x = 0; x < this.Count(); x++) ;
                    return x ; //IndexOf(foo) 
                }
            
 
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
           SinglyLinkedListNode node = first_node;
            var newNode = new SinglyLinkedListNode(value);

            if (newNode.Value == value)
            {
                this.first_node = first_node.Next;
                
                return;
            }
            //  object node = null;
            while (true)
            {
                if (node.Next == null)
                {
                    return;
                }
                if (newNode.Next.Value == value)
                {
                    //return;
                    newNode.Next = newNode.Next.Next;
                    //  first_node.Next = newNode;
                    break;

                }
                newNode = node.Next;
            }
        }


        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
          var  array = new string[this.Count()];

          for (var i = 0; i <array.Length; i++)
          {
              array[i] = this.ElementAt(i);
          }
          return array;
  
        }
        ////////////////////////////////////// Homework pass test 26-28 using StringBuilder ////////////////
        ///////////////////////////////////// string Builder version 2 /////////////////////////////////////


        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            var opening = "{";
            var ending = "}";
            var space = " ";
            var quote = "\"";
            var comma = ",";
            var node = this.first_node;

            strBuilder.Append(opening).Append(space);
            if (this.Count() >= 1)
            {
                
                while (!node.IsLast()) //;
                {
                    strBuilder.Append(quote).Append(node.Value).Append(quote).Append(comma).Append(space);
                    node = node.Next;
                }
                strBuilder.Append(quote).Append(node.Value).Append(quote).Append(space);
            }

            strBuilder.Append(ending);
            var str = strBuilder.ToString();
            return strBuilder.ToString();
        }

        public static implicit operator string (SinglyLinkedList v)
        {
            throw new NotImplementedException();
        }
    }

    internal class SinglyLinkedList<T>
    {
        private SinglyLinkedList array;

        public SinglyLinkedList()
        {
        }

        public SinglyLinkedList(SinglyLinkedList array)
        {
            this.array = array;
        }
    }
}


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

//  return array.ToArray<string>();



///////////////////////////////////// string Builder version 1 /////////////////////////////////////
/*     public override string ToString()
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



         */
