using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssign_lijing
{
    public class Filter
    {
        public List<MyClass> SortAZ(List<MyClass> clist)
            // Access Modifier: public means when can call it from other classes(e.g. in Form1 on the SortAZ click event)
            // Return type:List<creature> means it will return a List of MyClass objects (e.g. what has been  read from file)
            // Method nameSortAZ .Parameter:(List<MyClass> clist).
            // Method has one parameter which is a List of MyClass objects called clist, this is the unsorted list that is passed in that needs to be sorted 
        {
            clist = clist.OrderBy(x => x.Name).ToList();//LINQ( x>=x.name) 是将关键字封装成方法来使用，查询方法一般是配合UPPER.Lambda表达式来使用
            //clist LINQ lambda expression .Sort the list A-Z by .Name
            //Overwrite clist (the unordered list which is the parameter  of method )with a Sorted version
            //Sort the list by A-Z by .Name calling the OrderBy method
            // The parameter is a lambda expression .
            //  Pronounced x goes to x.Name. We have a list of MyClass objects , we have called the OrderBy method,
            //  for it to work we need to tell it what property to order the clist by .X represents a single clist object,so we tell it to specifically use x.Name for sorting 
            // Tolsit : call the Tolist() method to convert the result from the LINQ lambda expression into a List(to match clist).Without this, an implicitly typed local variable will be returned.
            return clist;
        }

        public List<MyClass> SortNum(List<MyClass> clist)
            // Add a method to sort by the Salary
        {
            clist = (from x in clist
                     orderby x.Salary ascending// this uses a SQL  expression 
                     select x).ToList();
            return clist;
        }

        public List<MyClass> Search(List<MyClass>clist,string term)
            // Add a method to search by letter contained in Name
            // Access Modifier:public means when acn call it from other classes(e.g. in Form1 on the Search click event)
            // Return type: List<MyClass> means it will return a List of MyClass objects(e.g. the search results)
            // Method name:  Search  Parameters:(List<MyClass>cList,string term)
            //  Method has two parameters clist= a List of MyClass objects to search through, and term, a string which is the search term to use in searching
        {
            List<MyClass> results = new List<MyClass>();//local results
            //Declare and instantiate a new list of MyClass objects called "results"
            //List<MyClass>: is the object type
            //  new List<MyClass> :calling the List<> constructor
            // I will populate this currently empty list with MyClass objects for the clist parameter with MyClass that meet the search criteia
            foreach (MyClass s in clist) 
            {// foreach  :Loop through the ;list fo MyClass examing each one 
                //   MyClass s ,represent a new MyClass object from the loop each time through
                //   clist : the name of the List being looped through 
                if(s.Name.ToLower().Contains(term.ToLower()))
                //if statement :if the Name matches the search term add it to the results list
                //Achieved by calling the Contains method which returns true if the first string(s.Name)contains the parameter string (term,meaning the search term)
                // the ToLower() method are used to  make the search case-insensitive 
                {
                    results.Add(s);
                    //Add any matching "s" to  the result list 
                    //Achieved by calling the Add method and passing the MyClass object s (object with the matching name) in as a parameter
                }
            }
            return results;
            //Return the search results achieved by return the results List of MyClass objects that are created at the start of the method (empty to begin with)
            // and populated with matching search results by the loop
        }

    }
}
