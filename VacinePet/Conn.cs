using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Astromaze.Models.Conn
{
    static class Conn
    {
        static private string servidor = "BancoDeDados.mssql.somee.com";
        static private string bancoDados = "BancoDeDados";
        static private string usuario = "Astromaze_SQLLogin_1";
        static private string senha  = "346fwfsqsh";

        static public string strConn = "server=" + servidor + "; User Id=" + usuario + "; database=" + bancoDados + "; password=" + senha;
    }
}