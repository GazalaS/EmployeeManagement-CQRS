using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Languages
    {
        public string LangaugeSpoken { get; set; }

        [Range(1, 5)]
        public int Proficiency { get; set; }

    }
}
