﻿using System;
namespace questAPI.DataLogic
{
    public class DatabaseProperties
    {
        public string DataSource { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string InitialCatalog { get; set; }

        public DatabaseProperties()
        {
        }
    
    }
}
