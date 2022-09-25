namespace AbstractFactory
{
    public class StaffComputerFactory
    {
        public IComputerFactory Create(Staff staff)
        {
            IComputerFactory returnValue = null;
            if (staff.StaffType ==  Constants.StaffType.Permanent)
            {
                switch (staff.RoleType)
                {
                    case Constants.RoleType.Director:
                        returnValue = new MacLaptopFactory();
                        break;
                    case Constants.RoleType.Manager:
                        returnValue = new DellLaptopFactory();
                        break;
                    case Constants.RoleType.TeamLeader:
                        returnValue = new DellDesktopFactory();
                        break;
                    default:
                        break;
                }
            }
            else if (staff.StaffType ==  Constants.StaffType.Contractor)
            {
                if (staff.RoleType == Constants.RoleType.Manager)
                {
                    returnValue = new LenovoLaptopFactory();
                }
                else if (staff.RoleType == Constants.RoleType.TeamLeader)
                {
                    returnValue = new LenovoDesktopFactory();
                }
            }
            return returnValue;
        }
    }
}
