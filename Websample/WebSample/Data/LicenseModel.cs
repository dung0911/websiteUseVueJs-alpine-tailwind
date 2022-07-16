using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using Jexpa.Core;
using Jexpa.Model.Entity;


namespace WebSample.Data
{
    public class LicenseModel : LicenseEntity
    {
        [Required(ErrorMessage = "License Start Date is required")]
        protected DateTimeOffset? _uiStartDate;
        [Required(ErrorMessage = "License End Date is required")]
        protected DateTimeOffset? _uiEndDate;
        protected DateTimeOffset? _uiUsedDate;
        public DateTimeOffset? UIStartDate
        {
            get
            {
                if (_startDate != SqlDateTime.MinValue.Value)
                {
                    _uiStartDate = DateTime.SpecifyKind(_startDate, DateTimeKind.Utc);
                }
                return _uiStartDate;
            }
            set
            {
                if (value == null)
                {
                    _uiStartDate = null;
                    _startDate = SqlDateTime.MinValue.Value;
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
                if (_endDate != SqlDateTime.MinValue.Value)
                {
                    _uiEndDate = DateTime.SpecifyKind(_endDate, DateTimeKind.Utc);
                }
                return _uiEndDate;
            }
            set
            {
                if (value == null)
                {
                    _uiEndDate = null;
                    _endDate = SqlDateTime.MinValue.Value;
                }
                else
                {
                    _uiEndDate = value;
                    _endDate = value.Value.UtcDateTime;
                }
            }
        }
        public DateTimeOffset? UIUsedDate
        {
            get
            {
                if (_usedDate != null)
                {
                    _uiUsedDate = DateTime.SpecifyKind(_usedDate.GetValueOrDefault(), DateTimeKind.Utc);
                }
                return _uiUsedDate;
            }
            set
            {
                if (value == null)
                {
                    _uiUsedDate = null;
                    _usedDate = null;
                }
                else
                {
                    _uiUsedDate = value;
                    _usedDate = value.Value.UtcDateTime;
                }
            }
        }
    }
}