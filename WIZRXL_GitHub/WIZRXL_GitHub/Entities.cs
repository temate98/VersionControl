﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIZRXL_GitHub
{
    class Entities
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format(
                    "{0} {1}",
                    LastName,
                    FirstName);
            }
        }

        // Ugyanaz a FullName property kompaktabb formában is írható
        /*
        public string FullName
            => string.Format(
                "{0} {1}",
                LastName,
                FirstName);
        */
    }

}