using System;
using System.Collections.Generic;

#nullable disable

namespace EncryptionWebAPI.Models
{
    public partial class DimDate
    {
        public string DwDateKey { get; set; }
        public string FullDate { get; set; }
        public string DisplayDate { get; set; }
        public string DayName { get; set; }
        public string DayShortName { get; set; }
        public string YearWeek { get; set; }
        public string WeekInYear { get; set; }
        public string MonthShortName { get; set; }
        public string MonthName { get; set; }
        public string MonthNumber { get; set; }
        public string DayInMonth { get; set; }
        public string DayInYear { get; set; }
        public string Year { get; set; }
        public string CalendarYearMonth { get; set; }
        public string FinancialYearMonth { get; set; }
        public string CalendarQuarter { get; set; }
        public string FinancialQuarter { get; set; }
        public string CalendarYearQuarter { get; set; }
        public string FinancialYearQuarter { get; set; }
        public string CalendarHalfYear { get; set; }
        public string FinancialHalfYear { get; set; }
        public string CalendarYearHalfYear { get; set; }
        public string FinancialYearHalfYear { get; set; }
        public string HolidayIndicator { get; set; }
        public string HolidayName { get; set; }
        public string LastDayInMonthIndicator { get; set; }
        public string WeekendIndicator { get; set; }
        public string DwStartDatetime { get; set; }
        public string DwEndDatetime { get; set; }
        public string DwStatusFlag { get; set; }
        public string WeekInYearOpcom { get; set; }
        public string PKey { get; set; }
        public string BbgWeekInMonth { get; set; }
        public string OrdinalWorkingDays { get; set; }
        public string Weekinmonth { get; set; }
        public string BbgWk { get; set; }
    }
}
