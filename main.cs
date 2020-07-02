using System;

/* lecture 2: method override

string showname() {
  string name;
  return name;
}

void showname(string name) {

}

*/

/* Static

class Forest
{
  private static string definition;
  public static string Definition
  { 
    get { return definition; }
    set { definition = value; }
  }
}

static void Main(string[] args)
{
  Console.WriteLine(Forest.Definition);
}

Remember that static means “associated with the class, not an instance”. 

 */

/* Abstract class 
project idea: https://1000projects.org/online-blood-bank-a-c-net-project.html */
public abstract class Donator {

  public abstract void listDescrition();
}

public class Seattle : Donator {

  string name;
  string type;

  public override void listDescrition() {
    Console.WriteLine("I do nothing");
  }
  

}


public class Toronto : Donator {

  public override void listDescrition() {

    DateTime d1 = new DateTime(2019, 6, 1, 17, 30, 0);
    string last_donation = (d1.ToString()); // I do not know if I can do this
    Console.WriteLine(last_donation);
  }
}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Donator guy1 = new  Seattle();
    Donator guy2 = new Toronto();
    guy2.listDescrition();
  }
}