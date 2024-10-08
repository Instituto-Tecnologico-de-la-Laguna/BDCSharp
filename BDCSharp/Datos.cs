﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDCSharp
{
    class Datos
    {
        string cadenaConexion = 
            @"Data Source=DESKTOP-H69TC9M\SQLEXPRESS;
            Integrated Security=true;Database=Escolar";
        SqlConnection con;

        private SqlConnection conexion(){
            try {
                con = new SqlConnection(cadenaConexion);
                con.Open();
                return con;
            }
            catch (Exception ex) { return null; }
        }

        public bool ejecutarComando(string comando)
        {
            try {
                SqlCommand cmd = new SqlCommand(comando, conexion());
                cmd.ExecuteNonQuery();
                return true;                    
            }
            catch (Exception ex) { return false; }
        
        }

        public DataSet informacion(string comando)
        {
            try { 
                DataSet ds= new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(comando,conexion());
                dataAdapter.Fill(ds);
                return ds;
            }
            catch (Exception ex) { return null; }
        }
    }
}
