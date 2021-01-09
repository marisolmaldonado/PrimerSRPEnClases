using System;

namespace SRPejemplos
{
    public class AdministradorMiembro
    {

        public void Aumentar(Miembro miembro)
        {
        }

        public void Aumentar(string nombre, string apellido, string cedula)
        {
            try
            {
                //aqui va nuestro codigo 
                System.IO.File.AppendAllText("\\datos\\data.tex", string.Format("nombre:{0}, apellido:{1}, cedula:{2}", nombre, apellido, cedula));
            }
            catch(Exception ex)
            {

                System.Diagnostics.Trace.Fail(ex.Message);
            }
        }
    }

            public void Eliminar(string cedula)
            {
        //aqui va el codigo
             }
}
