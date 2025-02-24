using Android.Health.Connect.DataTypes.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik.Model
{
    public class Student(int id, string firstName, string lastName, double percentage)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Percentage = percentage;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Percentage { get; set; }
}
