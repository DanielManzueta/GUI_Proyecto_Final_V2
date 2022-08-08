using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Proyecto_Final_V2
{
    internal static class ClassCliente
    {
        //Atributos estaticos
        private static string Usuario="Un usuario.";
        private static string Nombre = "Un nombre.";
        private static string Apellido = "Un apellido.";
        private static string Correo = "Un correo.";
        private static string Contraseña = "Un password.";
        //Metodos Estaticos
        public static void setUsuario(string usuario)
        {
            Usuario = usuario;
        }
        public static void setNombre(string nombre)
        {
            Nombre =nombre;
        }
        public static void setApellido(string apellido)
        {
            Apellido=apellido;
        }
        public static void setCorreo(string correo)
        {
            Correo=correo;
        }
        public static void setContraseña(string contraseña)
        {
            Contraseña = contraseña;
        }
        public static string getUsuario() { return Usuario; }
        public static string getNombre() { return Nombre; }
        public static string getApellido() { return Apellido; }
        public static string getCorreo() { return Correo; }
        public static string getContraseña() { return Contraseña; }
    }
}
