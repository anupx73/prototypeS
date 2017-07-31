﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrototypeS.Controllers
{
    class Settings
    {
        public Boolean UpdatePic(string Path)
        {
            Boolean success = false;
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("Logo", "'" + Path + "'");
            SqlDataReader reader = Program.db.get("Company");
            if (reader.HasRows)
            {
                //Update the Table
                success = Program.db.update("Company", d, " where Id = 1");
            }
            else
            {
                success = Program.db.insert("Company", d);
            }

            reader.Close();
            return false;
        }

        public Boolean UpdateCompany(string name, string ph, string email, string add, string aemail, string stno)
        {
             Boolean success = false;
            Dictionary<string, string> d = new Dictionary<string, string>();
            if(!string.IsNullOrWhiteSpace(name))
            {
                 d.Add("Name", "'" + name + "'");
            }
            if(!string.IsNullOrWhiteSpace(ph))
            {
                 d.Add("Phone", "'" + ph + "'");
            }
           
            if(!string.IsNullOrWhiteSpace(email))
            {
                 d.Add("Email", "'" + email + "'");
            }

            if(!string.IsNullOrWhiteSpace(add))
            {
                 d.Add("Address", "'" + add + "'");
            }
            if(!string.IsNullOrWhiteSpace(aemail))
            {
                 d.Add("AdminEmail", "'" + aemail + "'");
            }
            if(!string.IsNullOrWhiteSpace(stno))
            {
               d.Add("STaxNumber", "'" + stno + "'");
            }
            if(d.Count > 0)
            {
                SqlDataReader reader = Program.db.get("Company");
                if (reader.HasRows)
                {
                    success = Program.db.update("Company", d, " where id = 1");
                }
                else
                {
                    success = Program.db.insert("Company", d);
                }

            }
            return success;

        }

        public SqlDataReader GetCompanyDetails()
        {
            SqlDataReader reader = Program.db.get("Company");
            return reader;
        }
    }
}
