﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Corporation {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class OutpostServiceDetails {
        [XmlElement("rowset")]
        public RowCollection<Service> Services { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class Service {
            [XmlAttribute("stationID")]
            public long StationId { get; set; }

            [XmlAttribute("ownerID")]
            public long OwnerId { get; set; }

            [XmlAttribute("serviceName")]
            public string ServiceName { get; set; }

            [XmlAttribute("minStanding")]
            public double MinStanding { get; set; }

            [XmlAttribute("surchargePerBadStanding")]
            public double SurchargePerBadStanding { get; set; }

            [XmlAttribute("discountPerGoodStanding")]
            public double DiscountPerGoodStanding { get; set; }
        }
    }
}