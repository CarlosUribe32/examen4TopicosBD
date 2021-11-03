using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace VacunasMascotasMongoDB.Models
{
    class Citas
    {
        [BsonElement("Vacuna")]
        public string Vacuna{ get; set; }

        [BsonElement("Veterinaria")]
        public string Veterinaria{ get; set; }

        [BsonElement("Fecha_vacunacion")]
        public string Fecha_vacunacion{ get; set; }



    }
}
