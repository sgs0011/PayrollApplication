using System;

public class PayRollTest//creating the PayRollTest class to run the application
{
    public static void Main()//main method
    {
        //Console.Write("Enter the name of the employee : ");
        //string eName = Console.ReadLine();

        PayRoll pr = new PayRoll("pr.1");//creating a new object from the PayRoll class

        pr.CalcGrossPay();//calling on the constructor
    }
}