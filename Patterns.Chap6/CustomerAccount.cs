namespace Patterns.Chap6
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;

        public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
        }

        public int NumberOfRentalsThisMonth { get; internal set; }

        public bool CanRent()
        {
            return !_hasReachedRentalThreshold.IsSatisfiedBy(this);
        }
    }
}