using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase06
{
    class Cliente
    {
        /*CREAR ALIAS: CREA EL ALIAS CONCATENANDO UN NUMERO RANDON DE CUATRO CIFRAS
         * CON LA NACIONALIDAD Y EL TIPO DE CLIENTE, INVOCARLO A ESTE METODO
         * EN EL CONSTUCTOR POR DEFECTO.
         * GET ALIAS: RETORNA EL ALIAS.
         * RETORNAR DATOS(DE INSTANCIA Y PRIVADO): RETORNA UN STRING CON TODOS LOS DATOS.
         * RETORNAR DATOS(ESTATICO Y PUBLICO): RETORNA UN STRING CON TODOS LOS DATOS,
         * UTILIZAR EL METODO DE INSTANCIA.
         */
        private string _aliasParaIncognito;
        private string _nacionalidad;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            CrearAlias();
        }

        public Cliente(eTipoCliente cliente, string nombre)
        {
            this._tipoDeCliente = cliente;
            this._nombre = nombre;
            
        }

        public Cliente(eTipoCliente cliente, string nombre, string nacionalidad)
        {
            this._tipoDeCliente = cliente;
            this._nombre = nombre;
            this._nacionalidad = nacionalidad;
        }

        public Cliente(string nombre)
        {
            this._nombre = nombre;
        }

        private void CrearAlias()
        {
            Random numero = new Random();
            this._aliasParaIncognito = numero.Next(1000, 9999) + this._nacionalidad + this._tipoDeCliente;
            

        }

        public string GetAlias()
        {


            return this._aliasParaIncognito;//
        }

        private string RetornarDatos()
        {
            string datos = this._nombre + this._nacionalidad + this._tipoDeCliente + GetAlias();
            return datos;
        }

        public string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }

        
    }

    public enum eTipoCliente
    {
        PoliticoCorrupto,
        EmpresarioCorrupto,
        JugadorDeFutbol,
        Financista,
        MaestroRural
    }
}
