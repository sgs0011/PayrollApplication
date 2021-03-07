using System;//Steven Shetler, The purpose of the program is to create a payroll slip for a salaried or hourly WVU employee 

public class PayRoll
{//creating instance variables
    public string EmployeeName { get; set; }

    public int GrossPay { get; set; }

    public string EmployeeType { get; set; }
 
    public PayRoll(string eName)//creating constructor for PayRoll class
    {
        EmployeeName = eName;
    }
    //creating a method that will Calculate Gross Pay for employees
    public void CalcGrossPay()
    {//explaining to user the application's purpose
        Console.WriteLine("This application calculates the salary of an employee\nbased on their employment status");
        Console.WriteLine("-----------------------------------------------------\n");
        //prompting user for employee name
        Console.Write("Enter the name of the employee : ");
        string eName = Console.ReadLine();
        //prompting user for employee type
        Console.Write("Enter the employee type (H for hourly, S for salaried): ");
        string eType = (Console.ReadLine());
        //implementing if/else statement to differentiate between a salaried or hourly employee and calculate pay accordingly
        if (eType == "S")
        {//local variables being created and assigned
            int grossPay = 4000;
            int healthInsurance = 300;
            decimal retirement = (grossPay * .06m);
            decimal contributions = (retirement + healthInsurance);
            decimal payAfter = (grossPay - contributions);
            decimal fedTax = (payAfter * .15m);
            decimal stateTax = (payAfter * .05m);
            decimal tax = (fedTax + stateTax);
            decimal netPay = (payAfter - tax);
            //application printing out salaried employee information
            Console.WriteLine("-----------------------------------------------------\n");
            Console.WriteLine($"Payslip - {eName}");
            Console.WriteLine($"\nGross Pay               : {grossPay:c}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Contributions");
            Console.WriteLine($"Health Insurance        : {healthInsurance:c}");
            Console.WriteLine($"Retirement Plan (6%)    : {retirement:c}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Pay After Contributions : {payAfter:c} ");
            Console.WriteLine($"Federal tax (15%)       : {fedTax:c}");
            Console.WriteLine($"State Tax (5%)          : {stateTax:c}\n");
            Console.WriteLine($"Net Pay                 : {netPay:c}");
        }
        else if(eType == "H")
        {//prompting user for hours worked
            Console.Write("\nPlease enter the number of hours worked : ");
            int hours = int.Parse(Console.ReadLine());
            //prompting user for hourly rate
            Console.Write("Please enter the hourly rate : ");
            decimal rate = decimal.Parse(Console.ReadLine());
            //local variable creation and assignment
            decimal grossPay = (hours * rate);
            int healthInsurance = 300;
            decimal retirement = (grossPay * .06m);
            decimal contributions = (retirement + healthInsurance);
            decimal payAfter = (grossPay - contributions);
            decimal fedTax = (payAfter * .15m);
            decimal stateTax = (payAfter * .05m);
            decimal tax = (fedTax + stateTax);
            decimal netPay = (payAfter - tax);
            //application printing out hourly employee pay information
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"\n\nPayslip - {eName}");
            Console.WriteLine($"\nGross Pay               : {grossPay:c}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Contributions");
            Console.WriteLine($"Health Insurance        : {healthInsurance:c}");
            Console.WriteLine($"Retirement Plan (6%)    : {retirement:c}");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine($"Pay After Contributions : {payAfter:c} ");
            Console.WriteLine($"Federal tax (15%)       : {fedTax:c}");
            Console.WriteLine($"State Tax (5%)          : {stateTax:c}\n");
            Console.WriteLine($"Net Pay                 : {netPay:c}");
        }
    }
}
