using Zeiss.DataAccess;

namespace Zeiss.BL
{
    public class PayBL
    {
        public int GetBasicPay(string empID, Int16 Month, Int16 Year)
        {
            PayDA payDa = new PayDA();
            int basicPay = payDa.GetBasicPay(empID, Month, Year);
            return basicPay;        
        }

        public int CalculateDA(string empID, Int16 Month, Int16 Year)
        {
            int basicPay = GetBasicPay(empID, Month, Year);
            int da = 0;
            if (basicPay > 25000)
                da = basicPay * 30 / 100;
            else
                da = basicPay * 40 / 100;
            return da;
        }

       
        
    }
    public class EmployeeBL
    {
        public string empID;
        public string FirstName;
        public string LastName;
        public string DOJ;

        public EmployeeBL GetEmpDetails(string empID)
        {
            // get emp details
            EmployeeDA empD1 = new EmployeeDA();
            empD1 = empD1.GetEmpDetails(empID);

            // Populate BL object from DA object
            EmployeeBL empB1 = new EmployeeBL();
            empB1.EmpID = empD1.empID;
            empB1.FirstName = empD1.FirstName;
            empB1.LastName = empD1.LastName;
            empB1.DOJ = empD1.DOJ;

            return empB1;

        }
    }
}
