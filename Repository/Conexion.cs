﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Repository
{
    public class Conexion
    {
        public static string sqlServer = ConfigurationManager.ConnectionStrings["sqlserver"].ToString();
    }
}
