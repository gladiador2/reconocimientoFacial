using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using Reconocimiento_facial.Modelos;

namespace Reconocimiento_facial.Clases
{
   public  class Personas
    {
       public Personas()
       {

       }
        public List<Personas> Listar()
        {
            using (ReconocimientoEntities1 db = new ReconocimientoEntities1())
            {
                /* var  persona = db.Personas.ToList();
                  List<PersonasModelo> oPersona = (from a in persona
                                             select
                                             new PersonasModelo(

                                                 )).ToList();
                List<DALC.Personas> oPersona = persona.ToList();*/
                return db.Personas.ToList();
            } 
        }
        public static void  guardar(Hashtable campos, bool insertarNuevo)
       {
            DALC.Personas personas = new DALC.Personas();
            
           using(ReconocimientoEntities1 db = new ReconocimientoEntities1())
           {
                try
                {
                    personas.Nombre = campos[Nombre].ToString();
                    personas.Apellido = campos[Apellido].ToString();
                    personas.Telefono = campos[Telefono].ToString();
                    personas.DescripcionFisica = campos[DescripcionFisica].ToString();
                    personas.Email = campos[Email].ToString();
                    personas.Nivel = campos[Nivel].ToString();
                    personas.fechaNacimiento = DateTime.Parse(campos[fechaNacimiento].ToString());
                    personas.ciudadId = int.Parse(campos[ciudadId].ToString());
                    if (insertarNuevo)
                    {
                        db.Personas.Add(personas);
                        db.SaveChanges();
                    }
                    else
                    {
                        personas.id = int.Parse(campos["id"].ToString());
                        db.Entry(personas).State = System.Data.Entity.EntityState.Modified; 
                        db.SaveChanges();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    
                }
                
            }
       
       }
        public const string id = "id";
        public const string Nombre = "Nombre";
       public const string  Apellido = "Apellido";
       public const string  Telefono = "Telefono";
       public const string  DescripcionFisica = "DescripcionFisica";
       public const string  Email = "Email";
       public const string  Nivel = "Nivel";
        public const string fechaNacimiento = "";
        public const string ciudadId = "ciudadId";
        public const string AntecedentesId = "";

        public const string Antecedentes = "Antecedentes";
        public const string Fotos = "Fotos";
    }
    
}
