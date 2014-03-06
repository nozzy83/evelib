﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnlineLib.Model.Core {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class ReferenceTypes : XmlElement {
        [XmlElement("rowset")]
        public XmlRowSet<ReferenceType> RefTypes { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class ReferenceType {
            [XmlAttribute("refTypeID")]
            public int RefTypeId { get; set; }

            [XmlAttribute("refTypeName")]
            public string RefTypeName { get; set; }
        }
    }
}