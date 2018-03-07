using System;

namespace Patterns.Chap7
{
    internal class NotSpecification<T> : ISpecification<T>
    {
        private CompositeSpecification<T> compositeSpecification;

        public NotSpecification(CompositeSpecification<T> compositeSpecification)
        {
            this.compositeSpecification = compositeSpecification;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return !compositeSpecification.IsSatisfiedBy(candidate);
        }
    }
}