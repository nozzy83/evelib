﻿using System;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Character {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class MailingLists {
        [XmlElement("rowset")]
        public RowCollection<List> Lists { get; set; }

        [Serializable]
        [XmlRoot("row")]
        public class List {
            [XmlAttribute("listID")]
            public long ListId { get; set; }

            [XmlAttribute("displayName")]
            public string DisplayName { get; set; }
        }
    }
}