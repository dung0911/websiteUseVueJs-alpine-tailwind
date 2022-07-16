using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Jexpa.Core;
using Jexpa.Model.Entity;

namespace WebSample.Data
{
    public class CouponModel : CouponEntity
    {
        protected DateTimeOffset? _uiStartDate;
        protected DateTimeOffset? _uiEndDate;
        public DateTimeOffset? UIStartDate
        {
            get
            {
                if (_startDate != null)
                {
                    _uiStartDate = DateTime.SpecifyKind(_startDate.GetValueOrDefault(), DateTimeKind.Utc);
                }
                return _uiStartDate;
            }
            set
            {
                if (value == null)
                {
                    _uiStartDate = null;
                    _startDate = null;
                }
                else
                {
                    _uiStartDate = value;
                    _startDate = value.Value.UtcDateTime;
                }
            }
        }
        public DateTimeOffset? UIEndDate
        {
            get
            {
                if (_endDate != null)
                {
                    _uiEndDate = DateTime.SpecifyKind(_endDate.GetValueOrDefault(), DateTimeKind.Utc);
                }
                return _uiEndDate;
            }
            set
            {
                if (value == null)
                {
                    _uiEndDate = null;
                    _endDate = null;
                }
                else
                {
                    _uiEndDate = value;
                    _endDate = value.Value.UtcDateTime;
                }
            }
        }
    }
}