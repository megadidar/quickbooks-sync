﻿using QbSync.QbXml.Type;

namespace QbSync.QbXml.Objects
{
    public class Address : AddressBlock
    {
        public StrType City { get; set; }
        public StrType State { get; set; }
        public StrType PostalCode { get; set; }
        public StrType Country { get; set; }
        public StrType Note { get; set; }
    }
}
