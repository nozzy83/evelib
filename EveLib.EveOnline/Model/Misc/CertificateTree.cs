﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Misc {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class CertificateTree {
        [XmlElement("rowset")]
        public RowCollection<CertificateCategory> Categories { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class Certificate {
            [XmlAttribute("certificateID")]
            public long CertificateId { get; set; }

            [XmlAttribute("grade")]
            public int Grade { get; set; }

            [XmlAttribute("corporationID")]
            public long CorporationId { get; set; }

            [XmlAttribute("description")]
            public string Description { get; set; }

            [XmlElement("rowset")]
            public RowCollection<Skill> RequiredSkills { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class CertificateCategory {
            [XmlAttribute("categoryID")]
            public long CategoryId { get; set; }

            [XmlAttribute("categoryName")]
            public string CategoryName { get; set; }

            [XmlElement("rowset")]
            public RowCollection<CertificateClass> Classes { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class CertificateClass {
            [XmlAttribute("classID")]
            public long ClassId { get; set; }

            [XmlAttribute("className")]
            public string ClassName { get; set; }

            [XmlElement("rowset")]
            public RowCollection<Certificate> Certificates { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class Skill {
            [XmlAttribute("typeID")]
            public long TypeId { get; set; }

            [XmlAttribute("level")]
            public int Level { get; set; }
        }
    }
}