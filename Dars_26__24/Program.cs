// See https://aka.ms/new-console-template for more information

using Dars_26__24.N24_T1;
using Dars_26__24.Practic;
using Newtonsoft.Json;

Console.WriteLine("Dars_26");

#region Practic
const string _filePath = @"/Users/azamamonov/RiderProjects/ClassWork/Dars_26__24/Practic/Person.txt";
const string _sourceDataPath = @"/Users/azamamonov/RiderProjects/ClassWork/Dars_26__24/Practic/PersonData.txt";

string json = JsonConvert.SerializeObject(_sourceDataPath, Formatting.Indented);
File.WriteAllText(_filePath, json);

string source = File.ReadAllText(_sourceDataPath);
List<Person>? persons = JsonConvert.DeserializeObject<List<Person>>(source);

persons?.ForEach(Console.WriteLine);
#endregion

#region ClassWork_1
// EmployeeService employeeService = new EmployeeService();
//
// int pageToken = 1;
// int pageSize = 4;
//
// var employees = null as List<Employee>;
//
// while ((employees = employeeService.GetBySalary(pageSize, pageToken++)).Count > 0)
// {
//     Console.WriteLine($"\nPage: {pageToken-1}");
//     employees.ForEach(Console.WriteLine);
// }

#endregion

#region ClassWork_2



#endregion

