using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace VacunasMascotasMongoDB.Models
{
    class Mascota
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nombre")]
        public string Nombre { get; set; }

        [BsonElement("Especie")]
        public string Especie { get; set; }

        [BsonElement("Raza")]
        public string Raza{ get; set; }

        [BsonElement("Año_nacimiento")]
        public int Año_nacimiento{ get; set; }

        [BsonElement("Citas")]
        public List<Citas> Citas{ get; set; }

        public string ToString() {
            return Nombre;
        }
    }
}
