﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase06
{
    class CuentaOffShore
    {

    /* EN ESTA CLASE EL CONSTRUCTOR POR DEFECTO DEBERA SUMAR 1 AL ATRIBUTO ESTATICO CANTIDAD DE CUENTAS
     * Y EL LUGAR POR DEFECTO SERA BAHAMAS, NO REPETIR LINEAS DE CODIGO.
     * CONSTRUCTOR DE CLASE EN ESTA CLASE SERA EL ENCARGADO DE INICIALIZAR LAS CANTIDADES DE CUENTAS A 0
     * 
     */
        private eTipoBeneficio beneficio;
        public static int cantidadDeCuentas;
        private List<Cliente> _listadoClientes;
        private eParaisosFiscales lugar;

        public CuentaOffShore()
        {
            cantidadDeCuentas++;
            this.lugar = eParaisosFiscales.Bahamas;
            this._listadoClientes = new List<Cliente>();//
        }

        static CuentaOffShore()
        {
            //this.beneficio = beneficio;
            //this.lugar = lugar;
            cantidadDeCuentas = 0;
        }      

        //private CuentaOffShore()
        //{
            
        //}

        public CuentaOffShore(eParaisosFiscales lugar)
        {
            this.lugar = lugar;
            //this.beneficio = beneficio;
            //this.cantidadDeCuentas = cantidadDeCuentas;
        }

        public CuentaOffShore(eParaisosFiscales lugar, eTipoBeneficio beneficio)
        {
            this.lugar = lugar;
            this.beneficio = beneficio;
            //this.cantidadDeCuentas = cantidadDeCuentas;
            
        }     
    }

    enum eParaisosFiscales
    {
        Anguila,
        Bahamas,
        Belice,
        Delaware,
        Gibraltar,
        Hong_Kong,
        Mauricio,
        Panama,
        Seychelles,
        Singapur,
        Suiza
    }

    public enum eTipoProducto
    {
        cuentas_bancarias,
        polizas_de_seguros,
        inversiones_inmobiliarias,
        sociedades_extranjeras,
        fondos_de_inversion
    }

    public enum eTipoBeneficio
    {
        secreto_bancario,
        beneficios_fiscales,
        secreto_bancario_y_beneficios_fiscales
    }
}
