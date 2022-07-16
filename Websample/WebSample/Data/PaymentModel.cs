using System;
using Jexpa.Model.Entity;

namespace WebSample.Data
{
    public class PaymentModel : PaymentEntity
    {
        protected DateTimeOffset? _uiPaymentDate;
        protected DateTimeOffset? _uiCompletedDate;
        public DateTimeOffset? UIPaymentDate
        {
            get
            {
                if (_paymentDate != null)
                {
                    _uiPaymentDate = DateTime.SpecifyKind(_paymentDate.GetValueOrDefault(), DateTimeKind.Utc);
                }
                return _uiPaymentDate;
            }
            set
            {
                if (value == null)
                {
                    _uiPaymentDate = null;
                    _paymentDate = null;
                }
                else
                {
                    _uiPaymentDate = value;
                    _paymentDate = value.Value.UtcDateTime;
                }
            }
        }
        public DateTimeOffset? UICompletedDate
        {
            get
            {
                if (_completedDate != null)
                {
                    _uiCompletedDate = DateTime.SpecifyKind(_completedDate.GetValueOrDefault(), DateTimeKind.Utc);
                }
                return _uiCompletedDate;
            }
            set
            {
                if (value == null)
                {
                    _uiCompletedDate = null;
                    _completedDate = null;
                }
                else
                {
                    _uiCompletedDate = value;
                    _completedDate = value.Value.UtcDateTime;
                }
            }
        }
    }
}