namespace HeritageEmployeesPayment.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() : base() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour ,double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return 1.1 * AdditionalCharge + base.Payment();
        }
    }
}
