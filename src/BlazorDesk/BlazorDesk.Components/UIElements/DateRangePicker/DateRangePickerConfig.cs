using System;

namespace BlazorDesk.Components
{
    public class DateRangePickerConfig
    {
        public DateRangePickerLocale Locale { get; set; }
        public DateRangePickerSettings Settings { get; set; }
    }

    public class DateRangePickerLocale
    {
        public string Format { get; set; }
        public string ApplyLabel { get; set; }
        public string CancelLabel { get; set; }


        public string Language { get; set; }
    }

    public class DateRangePickerSettings
    {
        //public bool ShowTimePicker { get; set; }

    }
}
