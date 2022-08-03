namespace Zeiss.DataAccess
{
    public class PayDA
    {
        public int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            // connect to the database
            // execute stored procedure/query
            // get Basic Pay
            // close connection
            return 20000;
        }
    }

    public class EmployeeDA
    {
        public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;

        public EmployeeDA GetEmpDetails(string empID)
        {
            EmployeeDA emp = new EmployeeDA();
            // connect to the database
            // execute stored procedure/query
            // get employee details in emp instance and return emp instance
            emp.FirstName = "Raj";
            emp.LastName = "Kumar";
            emp.DOJ = "5-5-2015";
            // close connection
            return new EmployeeDA();
        }
    }

}