using Newtonsoft.Json;
namespace Dars_35_C30.Practic;

public class StudentService
{
    private const string LocationPath =
                    @"/Users/azamamonov/RiderProjects/ClassWork/Dars_35_C30/Practic/Data/Location.json";
    
    private const string SpecialityPath = 
                    @"/Users/azamamonov/RiderProjects/ClassWork/Dars_35_C30/Practic/Data/Speciality.json";

    private const string StudentPath = 
                    @"/Users/azamamonov/RiderProjects/ClassWork/Dars_35_C30/Practic/Data/Student.json";

    static string StudentSource = File.ReadAllText(StudentPath);
    static string LocationSource = File.ReadAllText(LocationPath);
    static string SpecialitySource = File.ReadAllText(SpecialityPath);
    
     List<Student> _students = JsonConvert.DeserializeObject<List<Student>>(StudentSource);
     List<Speciality> _specialities = JsonConvert.DeserializeObject<List<Speciality>>(SpecialitySource);
     List<Location> _location = JsonConvert.DeserializeObject<List<Location>>(LocationSource);

     public void StudentCountBySpeciality()
     {
         
     }

}