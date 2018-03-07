using System;

namespace Patterns.Chap4
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState baseState)
        {
            _orderState = baseState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrdereDate { get; set; }
        public OrderStatus Status()
        {

            return _orderState.Status;

        }

        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }

        public void Cancel()
        {
            if (CanCancel())
            {
                _orderState.Cancel(this);
            }
        }

        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }

        public void Ship()
        {
            if (CanShip())
            {
                _orderState.Ship(this);
            }
        }

        internal void Change(IOrderState orderState)
        {
            _orderState = orderState;
        }
    }
}