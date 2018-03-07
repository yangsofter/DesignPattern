namespace Patterns.Chap7
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;

        public CustomerAccount()
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
        }

        public int NumberOfRentalsThisMonth { get; internal set; }

        /// <summary>
        /// 账号是否受限制
        /// </summary>
        public bool AccountActive { get; set; }
        /// <summary>
        /// 客户所欠总费用
        /// </summary>
        public decimal LateFees { get; set; }

        public bool CanRent()
        {
            return !_hasReachedRentalThreshold.IsSatisfiedBy(this);
        }
    }
}