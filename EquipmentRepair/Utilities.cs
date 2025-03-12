namespace EquipmentRepair
{
    public class Utilities
    {
        // private EqipmentRepairEntities _db = new EqipmentRepairEntities();
        public int Authorizaton(string login, string password)
        {
            if (login.Length <= 1)
                return 0;
            if (password.Length <= 1)
                return 0;

            // var client = _db.Client.Where(c => c.Surename == login && c.Phone == password).FirstOrDefault();


            // var employee = _db.Employee.Where(e => e.Surename == login && e.Phone == password).FirstOrDefault();


            // if (client == null && employee == null)
            //  return -1;

            // 1 - клиент, 2 - сотрудник, 3 - администратор

            // if (client != null)
            //return 1;

            // if (employee != null && !employee.IsAdmin)
                //return 2;

            // if (employee != null && employee.IsAdmin)
            //return 3;

            return 0;
        }
    }
}
