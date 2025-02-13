namespace SOLID.ISP
{
    interface IEntitlement
    {
        decimal CalculatePension();
        decimal CalculateHealthInsurance();
        decimal CalculateRentalSubsidy();
        decimal CalculateBonuses();
        decimal CalculateTransportationRimbursement();
    }
}
