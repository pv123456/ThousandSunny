using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffFullName { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsAdmin { get; set; }
        public string StaffEmail { get; set; }
        public string StaffPassword { get; set; }
    }
}