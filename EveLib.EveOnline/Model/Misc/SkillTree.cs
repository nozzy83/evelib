﻿using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace eZet.EveLib.EveOnline.Model.Misc {
    [Serializable]
    [XmlRoot("result", IsNullable = false)]
    public class SkillTree {
        [XmlElement("rowset")]
        public RowCollection<SkillGroup> Groups { get; set; }

        [Serializable]
        [XmlRoot("requiredAttributes")]
        public class RequiredAttribute {
            [XmlElement("primaryAttribute")]
            public string PrimaryAttribute { get; set; }

            [XmlElement("secondaryAttribute")]
            public string SecondaryAttribute { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class RequiredSkill {
            [XmlAttribute("skillLevel")]
            public int SkillLevel { get; set; }

            [XmlAttribute("typeID")]
            public long TypeId { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class Skill : IXmlSerializable {
            [XmlAttribute("groupID")]
            public long GroupId { get; set; }

            [XmlAttribute("published")]
            public bool Published { get; set; }

            [XmlAttribute("typeID")]
            public long TypeId { get; set; }

            [XmlAttribute("typeName")]
            public string TypeName { get; set; }

            [XmlElement("description")]
            public string Description { get; set; }

            [XmlElement("rank")]
            public int Rank { get; set; }

            [XmlElement("requiredAttributes")]
            public RequiredAttribute RequiredAttributes { get; set; }

            [XmlElement("rowset")]
            public RowCollection<RequiredSkill> RequiredSkills { get; set; }

            [XmlElement("rowset")]
            public RowCollection<SkillBonus> SkillBonuses { get; set; }

            public XmlSchema GetSchema() {
                throw new NotImplementedException();
            }

            public void ReadXml(XmlReader reader) {
                var xml = new XmlHelper(reader);
                GroupId = xml.getLongAttribute("groupID");
                Published = xml.getBoolAttribute("published") ?? false;
                TypeId = xml.getLongAttribute("typeID");
                TypeName = xml.getStringAttribute("typeName");
                Description = xml.getString("description");
                Rank = xml.getInt("rank");
                RequiredSkills = xml.deserializeRowSet<RequiredSkill>("requiredSkills");
                RequiredAttributes = xml.deserialize<RequiredAttribute>("requiredAttributes");
                SkillBonuses = xml.deserializeRowSet<SkillBonus>("skillBonusCollection");
            }

            public void WriteXml(XmlWriter writer) {
                throw new NotImplementedException();
            }
        }

        [Serializable]
        [XmlRoot("row")]
        public class SkillBonus {
            [XmlAttribute("bonusType")]
            public string BonusType { get; set; }

            [XmlAttribute("bonusValue")]
            public string BonusValue { get; set; }
        }

        [Serializable]
        [XmlRoot("row")]
        public class SkillGroup {
            [XmlAttribute("groupID")]
            public int GroupId { get; set; }

            [XmlAttribute("groupName")]
            public string CorporationName { get; set; }

            [XmlElement("rowset")]
            public RowCollection<Skill> Skills { get; set; }
        }
    }
}