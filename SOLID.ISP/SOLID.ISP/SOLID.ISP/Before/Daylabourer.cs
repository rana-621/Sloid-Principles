﻿namespace SOLID.ISP.Before
{
    class Daylabourer : Employee, IEntitlement
    {
        public decimal CalculateBonuses() => throw new NotSupportedException("Day labourer Bonuses not supported");

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() =>
            throw new NotSupportedException("Day labourer Pension not supported");

        public decimal CalculateRentalSubsidy() =>
            throw new NotSupportedException("Day labourer Rental Subsidy not supported");

        public decimal CalculateTransportationRimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportationRimbursement();

        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Daylabourer)} ---" +
                   $"\n  No.: {EmployeeNO}" +
                   $"\n  Name: {Name}" +
                   $"\n  Basic Salary: {Salary.ToString("C2")}" +
                   $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                   $"\n  Transportation Reimbursement: {CalculateTransportationRimbursement().ToString("C2")}" +
                   $"\n  ----------------------------------------------" +
                   $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}