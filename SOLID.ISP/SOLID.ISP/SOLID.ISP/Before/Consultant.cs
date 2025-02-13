namespace SOLID.ISP.Before
{
    class Consultant : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => throw new NotSupportedException("consultant employee not supported ");

        public decimal CalculateRentalSubsidy() => throw new NotSupportedException("consultant employee not supported ");

        public decimal CalculateTransportationRimbursement() => 150;

        public override string PrintSalarySlip()
        {
            return $"\n -- {nameof(Consultant)}--" +
                $"\n NO. {EmployeeNO} " +
                $"\n Name: {Name} " +
                $"\n Basic Salary: {Salary.ToString("C2")} " +
                $"\n Bonuses: {CalculateBonuses().ToString("C2")} " +
                $"\n Health Insurance: {CalculateHealthInsurance().ToString("C2")} " +
                $"\n Transportation Reimbursement: {CalculateTransportationRimbursement().ToString("C2")} " +
                $"\n ----------------------------------------" +
                $"\n Net Salary: {CalculateNetSalary().ToString("C2")} ";

        }

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateBonuses()
                + CalculateHealthInsurance()
                + CalculateTransportationRimbursement();
        }
    }
}
