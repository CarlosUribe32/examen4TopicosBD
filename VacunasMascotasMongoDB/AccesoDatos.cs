using System.Collections.Generic;
using System.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;
using VacunasMascotasMongoDB.Models;
using System.Data;

namespace VacunasMascotasMongoDB
{
    //Con Patron singleton
    class DB_Singleton {

        //Para obtener la conexion
        // Constantes para la cadena de conexion y nombre de Base de datos
        const string nombreDB = "VacunasMascotas";
        const string idStringConexion = "vacunasMascotasDB";

        /// <summary>
        /// Obtiene la cadena de conexión a partir de la configuración de la aplicación
        /// </summary>
        /// <param name="id">codigo del string de conexión</param>
        /// <returns>el string de conexión a utilizar</returns>
        private static string ObtieneCadenaConexion(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //Atributo con Unica Instancia
        private static DB_Singleton instancia;

        //Atributo de la clase
        private IMongoDatabase miDB;

        public IMongoDatabase MiDB { get => miDB;}

        //Constructor Privado
        private DB_Singleton()
        {
            string cadenaConexion = ObtieneCadenaConexion(idStringConexion);
            var clienteDB = new MongoClient(cadenaConexion);
            this.miDB = clienteDB.GetDatabase(nombreDB);
        }

        //La magia del Singleton
        public static DB_Singleton getInstance() {
            if (instancia == null)
            {
                instancia = new DB_Singleton();
            }
            return instancia;
        }

       
    }
    class AccesoDatos
    {
        /// <summary>
        /// Obtiene los registros de una colección mapeados a una lista del objeto especificado en el génerico
        /// </summary>
        /// <typeparam name="T">El objeto genérico especificado</typeparam>
        /// <param name="unaDB">la base de datos</param>
        /// <param name="nombreColeccion">La colección</param>
        /// <returns></returns>
        private static List<T> ObtenerRegistros<T>(IMongoDatabase unaDB, string nombreColeccion)
        {
            var unaColeccion = unaDB.GetCollection<T>(nombreColeccion);
            return (unaColeccion.Find(new BsonDocument()).ToList());
        }

        public static List<Especie> obtieneEspecies()
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            return ObtenerRegistros<Especie>(miDB.MiDB, "Especies");
        }

        public static List<string> obtieneNombreEspecies()
        {

            List<Especie> listaEspecies = obtieneEspecies();
            List<string> listaNombreEspecies = new List<string>();

            foreach (Especie unaEspecie in listaEspecies)
                listaNombreEspecies.Add(unaEspecie.Nombre);

            return listaNombreEspecies;
        }

        public static List<Veterinaria> obtieneVeterinarias()
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            return ObtenerRegistros<Veterinaria>(miDB.MiDB, "Veterinarias");
        }

        public static List<string> obtieneListaVeterinarias()
        {
            List<Veterinaria> listaVeterinarias= obtieneVeterinarias();
            List<string> listaNombreVeterinarias= new List<string>();

            foreach (Veterinaria veterinaria in listaVeterinarias)
                listaNombreVeterinarias.Add(veterinaria.Nombre);

            return listaNombreVeterinarias;
        }

        public static List<Raza> obtieneRazas()
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            return ObtenerRegistros<Raza>(miDB.MiDB, "Razas");
        }

        public static List<string> obtieneNombreRazas(string especie)
        {

            List<Raza> listaRazas = obtieneRazas();
            List<string> listaNombreRazas = new List<string>();

            foreach (Raza unaRaza in listaRazas)
                if (unaRaza.Especie == especie)
                    listaNombreRazas.Add(unaRaza.Nombre);

            return listaNombreRazas;
        }

        public static List<Vacuna> obtieneVacunas()
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            return ObtenerRegistros<Vacuna>(miDB.MiDB, "Vacunas");
        }

        public static List<string> obtieneVacunas(string especie)
        {
            List<Vacuna> listaVacunas = obtieneVacunas();
            List<string> listaNombreVacunas = new List<string>();

            foreach (Vacuna vacuna in listaVacunas)
                if (vacuna.Especie == especie)
                    listaNombreVacunas.Add(vacuna.Nombre);

            return listaNombreVacunas;
        }

        public static List<Mascota> obtieneMascotas()
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            return ObtenerRegistros<Mascota>(miDB.MiDB, "Mascotas");
        }

        public static List<Mascota> obtieneListaMascotas()
        {

            List<Mascota> listaMascotas = obtieneMascotas();
            return listaMascotas;
        }

        private static void insertarRegistro<T>(IMongoDatabase unaDB, string nombreColeccion, T unRegistro)
        {
            var unaColeccion = unaDB.GetCollection<T>(nombreColeccion);
            unaColeccion.InsertOne(unRegistro);
        }

        /// <summary>
        /// Inserta una nueva factura en la base de datos
        /// </summary>
        /// <param name="unaMascota">Factura a insertar</param>
        public static void insertarMascota(Mascota unaMascota)
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            insertarRegistro<Mascota>(miDB.MiDB, "Mascotas", unaMascota);
        }

        public static void actualizarMascota(Mascota mascota)
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            var unaColeccion = miDB.MiDB.GetCollection<Mascota>("Mascotas");
            unaColeccion.ReplaceOne(documento => documento.Id == mascota.Id, mascota);
        }
        public static void eliminarMascota(Mascota mascota)
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            var unaColeccion = miDB.MiDB.GetCollection<Mascota>("Mascotas");
            unaColeccion.DeleteOne(documento => documento.Id == mascota.Id);
        }

        public static DataTable obtieneDetalleConsultasMascotas(Mascota mascota)
        {
            DataTable tablaResultado = new DataTable();

            tablaResultado.Columns.Add(new DataColumn("Vacuna", typeof(string)));
            tablaResultado.Columns.Add(new DataColumn("Veterinaria", typeof(string)));
            tablaResultado.Columns.Add(new DataColumn("Fechas_vacunacion", typeof(string)));

            Mascota unaMascota = obtieneUnaMascota(mascota);

            if (unaMascota.Citas != null)
            {
                DataRow filaServicio;

                foreach (Citas cita in unaMascota.Citas)
                {
                    filaServicio = tablaResultado.NewRow();

                    filaServicio["Vacuna"] = cita.Vacuna;
                    filaServicio["Veterinaria"] = cita.Veterinaria;
                    filaServicio["Fechas_vacunacion"] = cita.Fecha_vacunacion;
                    tablaResultado.Rows.Add(filaServicio);
                }
            }
            return tablaResultado;
        }
        public static Mascota obtieneUnaMascota(Mascota mascota)
        {
            DB_Singleton miDB = DB_Singleton.getInstance();

            var unaColeccion = miDB.MiDB.GetCollection<Mascota>("Mascotas");


            var filtroMascota = new BsonDocument { { "_id", ObjectId.Parse(mascota.Id) } };

            var unaMascota = unaColeccion.Find(filtroMascota).FirstOrDefault();


            return unaMascota;
        }
    }
}
