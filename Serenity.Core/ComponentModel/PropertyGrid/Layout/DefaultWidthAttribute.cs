﻿using System;

namespace Serenity.ComponentModel
{
    /// <summary>
    /// Resets form field width to null. It maybe used to cancel UntilNext flag of a prior width attribute.
    /// </summary>
    public class DefaultWidthAttribute : FormCssClassAttribute
    {
        public DefaultWidthAttribute()
            : base(null)
        {
        }
    }
}