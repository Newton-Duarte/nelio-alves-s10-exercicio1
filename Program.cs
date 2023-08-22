using System.Globalization;

System.Console.Write("Enter the number of employees: ");
var answer = int.Parse(Console.ReadLine());
var counter = 1;

List<Employee> employees = new();

while (counter <= answer)
{
  System.Console.WriteLine($"Employee #{counter} data:");
  System.Console.Write("Outsourced (y/n)? ");
  var outsourced = Console.ReadLine();

  System.Console.Write("Name: ");
  var name = Console.ReadLine();
  
  System.Console.Write("Hours: ");
  var hours = int.Parse(Console.ReadLine());
  
  System.Console.Write("Value per hour: ");
  var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  
  if (outsourced.ToLower() == "y")
  {
    System.Console.Write("Additional charge: ");
    var additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    var employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);

    employees.Add(employee);
  }
  else
  {
    var employee = new Employee(name, hours, valuePerHour);
    employees.Add(employee);
  }

  counter++;
}

System.Console.WriteLine("PAYMENTS:");
foreach(var employee in employees)
{
  System.Console.WriteLine($"{employee.Name} - {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}