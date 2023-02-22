using System.Xml.Serialization;

namespace Threading_in_C.Entities
{
    public class Entity
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Health")]
        public string HealthAsText {
            get { return Health.ToString(); }
            set { Health = int.Parse(value); }
        }
        [XmlElement("HealthInt")]
        public int Health { get; set; }
        [XmlElement("Movement")]
        public string MovementAsText
        {
            get { return Movement.ToString(); }
            set { Movement = int.Parse(value); }
        }
        [XmlElement("MovementInt")]
        public int Movement { get; set; }
        [XmlElement("Strength")]
        public string StrengthAsText
        {
            get { return Strength.ToString(); }
            set { Strength = int.Parse(value); }
        }
        [XmlElement("StrengthInt")]
        public int Strength { get; set; }
        [XmlElement("Dexterity")]
        public string DexterityAsText
        {
            get { return Dexterity.ToString(); }
            set { Dexterity = int.Parse(value); }
        }
        [XmlElement("DexterityInt")]
        public int Dexterity { get; set; }
        [XmlElement("Constitution")]
        public string ConstitutionAsText
        {
            get { return Constitution.ToString(); }
            set { Constitution = int.Parse(value); }
        }
        [XmlElement("ConstitutionInt")]
        public int Constitution { get; set; }
        [XmlElement("Intelligence")]
        public string IntelligenceAsText
        {
            get { return Intelligence.ToString(); }
            set { Intelligence = int.Parse(value); }
        }
        [XmlElement("IntelligenceInt")]
        public int Intelligence { get; set; }
        [XmlElement("Wisdom")]
        public string WisdomAsText
        {
            get { return Wisdom.ToString(); }
            set { Wisdom = int.Parse(value); }
        }
        [XmlElement("WisdomInt")]
        public int Wisdom { get; set; }
        [XmlElement("Charisma")]
        public string CharismaAsText
        {
            get { return Charisma.ToString(); }
            set { Charisma = int.Parse(value); }
        }
        [XmlElement("CharismaInt")]
        public int Charisma { get; set; }
        [XmlElement("AR")]
        public string ARAsText
        {
            get { return AR.ToString(); }
            set { AR = int.Parse(value); }
        }
        [XmlElement("ARInt")]
        public int AR { get; set; }
        [XmlElement("BP")]
        public string BPAsText
        {
            get { return BP.ToString(); }
            set { BP = int.Parse(value); }
        }
        [XmlElement("BPInt")]
        public int BP { get; set; }
    }
}
