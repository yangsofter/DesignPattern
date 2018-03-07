using System;

namespace Patterns.Chap7
{
    internal class AndSpecification<T> : ISpecification<T>
    {
        private CompositeSpecification<T> compositeSpecification;
        private ISpecification<T> other;

        public AndSpecification(CompositeSpecification<T> compositeSpecification, ISpecification<T> other)
        {
            this.compositeSpecification = compositeSpecification;
            this.other = other;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return compositeSpecification.IsSatisfiedBy(candidate) && other.IsSatisfiedBy(candidate);
        }
    }
}