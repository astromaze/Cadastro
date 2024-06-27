using Microsoft.EntityFrameworkCore;
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Astromaze.Models.Conn
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        
    }
}