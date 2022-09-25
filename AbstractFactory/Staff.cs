using static AbstractFactory.Constants;

namespace AbstractFactory
{
    public class Staff
    {
        public string FullName { get; set; }
        public StaffType StaffType { get; set; }
        public RoleType RoleType { get; set; }
        public string ComputerDetails { get; set; }
    }
}
