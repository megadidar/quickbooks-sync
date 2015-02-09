﻿using System;
using System.Globalization;

namespace QbSync.QbXml.Type
{
    public class GuidType : IStringConvertible
    {
        private Guid value;

        public GuidType(string value)
        {
            this.value = Guid.Parse(value);
        }

        public GuidType(Guid value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value.ToString("B", CultureInfo.InvariantCulture);
        }

        public static implicit operator GuidType(Guid value)
        {
            return new GuidType(value);
        }
    }
}
