/*using System;
using System.Collections;
namespace practiceDay3
{
    /*
    class program
    {
        static void Main(string[] args)
        {


            /*
            ArrayList al = new ArrayList();
            Console.WriteLine("Initial Capacity: " + al.Capacity);
            al.Add(10);
            Console.WriteLine("Capacity after adding first item: " + al.Capacity);
            al.Add("hello");
            al.Add(true);
            al.Add(3.14f);
            Console.WriteLine("Capacity after adding fourth item: " + al.Capacity);
            al.Add('A');
            Console.WriteLine("Capacity after adding 5th element: " + al.Capacity);
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + " ");
            }
            Console.WriteLine();
            al.Remove(true);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Insert(2, false);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            ArrayList coll = new ArrayList(al);
            Console.WriteLine("Initial capacity of new array list collection:" + coll.Capacity);
            foreach (object obj in coll)
            {
                Console.Write(obj + " ");
            }
            Console.ReadKey();
            }*/

//-----------------------------------------------------------------------------

/*

 Hashtable ht = new Hashtable();
 ht.Add("Eid", 1001);
 ht.Add("name", "james");
 ht.Add("job", "developer");
 ht.Add("salary", 3500);
 ht.Add("location", "mumbai");
 ht.Add("dept", "IT");
 ht.Add("EmailId", "a@a.com");
 Console.WriteLine("printing using foreach loop");
 foreach (object obj in ht.Keys)
 {
     Console.WriteLine(obj + ":" + ht[obj]);

 }
 Console.WriteLine();
 Console.WriteLine("printing using keys");
 Console.WriteLine("location" + ht["location"]);
 Console.WriteLine("emailId" + ht["EmailId"]);

 Console.WriteLine("is emailid key exist" + ht.ContainsKey("EmailId"));
 Console.WriteLine("is department key exists" + ht.ContainsKey("department"));
 Console.WriteLine("is mumbai value exists" + ht.ContainsKey("mumbai"));
 Console.WriteLine("is technology value exists" + ht.ContainsKey("technology"));
 Console.ReadKey();

*/

//--------------------------------------------------------------------------------------------
/*
Stack s = new Stack();
s.Push(20);
s.Push("hi");
s.Push(3.14f);
s.Push(true);
s.Push(12.3);
s.Push('P');
foreach (object obj in s)
{
    Console.Write(obj + " ");
}
Console.WriteLine();
Console.WriteLine($"No of Elements in the Collection : {s.Count}");
Console.WriteLine();
Console.WriteLine($"Is the value hi present in the collection : {s.Contains("hi")}");
Console.WriteLine();
s.Clear();
Console.WriteLine($"No of Elements in the Collection after Clear() method : {s.Count}");
Console.ReadKey();

*/

//---------------------------------------------------------------------------
/*
 Queue q = new Queue();
 q.Enqueue(10);
 q.Enqueue("hello");
 q.Enqueue(3.14f);
 q.Enqueue(true);
 q.Enqueue(67.8);
 q.Enqueue('A');
 foreach (object obj in q)
 {
     Console.Write(obj + " ");
 }
 Console.WriteLine();
 Console.WriteLine(q.Dequeue());
 Console.WriteLine();
 foreach (object obj in q)
 {
     Console.Write(obj + " ");
 }
 Console.WriteLine();
 Console.WriteLine(q.Peek());
 Console.WriteLine();
 foreach (object obj in q)
 {
     Console.Write(obj + " ");
 }
   Console.ReadKey();
   */

//--------------------------------------------------------------------------------------------
/*
Queue q = new Queue();
q.Enqueue(10);
q.Enqueue("hi");
q.Enqueue(3.14f);
q.Enqueue(true);
q.Enqueue(67.8);
q.Enqueue('A');

foreach (object obj in q)
{
    Console.Write(obj + " ");
}
Console.WriteLine();
Console.WriteLine($"No of Elements Present in the Collection : {q.Count}");
Console.WriteLine();

Console.WriteLine($"Is the value hi present in the collection : {q.Contains("hi")}");
Console.WriteLine();
q.Clear();
Console.WriteLine($"No of Elements in the Collection after Clear() method : {q.Count}");
Console.ReadKey();



}
}
} */

//=============================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
public class Customer
{
    public int ID { get; set; }
    public string Name{ get; set;}
    public int Salary { get; set; }
}

    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "pam",
                Salary = 7000
            };
            Customer customer3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            Customer[] arrayCustomers = new Customer[2];
            arrayCustomers[0] = customer1;
            arrayCustomers[1] = customer2;

            List<Customer> listCustomer = new List<Customer>();

                Console.WriteLine("ID ={0},name={1},Salary{2}",
                    customer.iD, customer.Name, customer.Salary);

        }
    }
    
}


