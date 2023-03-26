using System.Collections.Generic;
using System.Xml.Serialization;
using Threading_in_C.Entities;

namespace Threading_in_C.Converters
{
    public class EntityConverters
    {
        [XmlRoot("EntityList")]
        public class EntityList
        {
            [XmlElement("Entity")]
            public List<Entity> Entities { get; set; }
        }
    }


    /*
        string testData =@"<EntityList>
            <Entity>
                <Name>Name1</Name>
                <Health>1</Health>
                <Movement>2</Movement>
                <Strength>3</Strength>
                <Dexterity>4</Dexterity>
                <Constitution>5</Constitution>
                <Intelligence>6</Intelligence>
                <Wisdom>7</Wisdom>
                <Charisma>8</Charisma>
                <AR>9</AR>
                <BP>0</BP>
            </Entity>
        </EntityList>";
    XmlSerializer serializer = new XmlSerializer(typeof(EntityList));
            using (TextReader reader = new StringReader(testData))
            {
                EntityList result = (EntityList)serializer.Deserialize(reader);
                Debug.WriteLine(result.Entities[0].Health);
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(result.Entities[0]))
                {
                    string name = descriptor.Name;
                    object value = descriptor.GetValue(result.Entities[0]);
                    Console.WriteLine("{0}={1}", name, value);
                }
            }

     Code for testing the XML converter
        Entity entity = new Entity()
        {
            Name="naam",
            Health = 0,
            Movement= 1,
            Strength= 2,
            Dexterity= 3,
            Constitution= 4,
            Intelligence= 5,
            Wisdom= 6,
            Charisma= 7,
            AR= 8,
            BP= 9
        };
        using (var stringWriter = new System.IO.StringWriter())
        {
            var serializer = new XmlSerializer(entity.GetType());
            serializer.Serialize(stringWriter, entity);
            Debug.WriteLine(stringWriter.ToString());
        }
     */
}
