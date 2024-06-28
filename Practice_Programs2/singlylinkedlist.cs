using System;  
using System.Collections.Generic;  
  
public class LinkedListExample  
{  
    public static void Main(string[] args)  
    {  
        // Create a list of strings  
        var names = new LinkedList<string>();  
        names.AddLast("A");  
        names.AddLast("B");  
        names.AddLast("C");  
        names.AddLast("D");  
          
        //insert new element before C
        LinkedListNode<String> node=names.Find("C");  
        names.AddBefore(node, "E");  
        names.AddAfter(node, "F");  
  
        // Iterate list element using foreach loop  
        foreach (var name in names)  
        {  
            Console.WriteLine(name);  
        }  
    }  
}  