﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Agenda_Electronica
{
    internal class Conexion
    {
       public static SqlConnection Connection()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-M2RPPBF;Initial Catalog=formulario;Integrated Security=True");
            cn.Open();
            return cn;
        }

    }
}
