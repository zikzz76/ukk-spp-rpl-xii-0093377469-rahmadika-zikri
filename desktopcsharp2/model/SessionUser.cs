using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktopcsharp2.model
{
    
    public class SessionUser
    {
        public SessionUser(int idPetugas, string username, string namaPetugas, string level, bool isLoggediN)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
            IsLoggediN = isLoggediN;
        }

        public int IdPetugas { get; set; }
        public string Username { get; set; }
        public string NamaPetugas { get; set; }
        public string Level { get; set; }
        public bool IsLoggediN { get; set; }


        public static void SetSession(int idPetugas, string username, string namaPetugas, string level, bool isLoggediN)
        {
            IdPetugas = idPetugas;
            Username = username;
            NamaPetugas = namaPetugas;
            Level = level;
            IsLoggediN = isLoggediN;
        }

        public static void ClearSession(int idPetugas, string username, string namaPetugas, string level, bool isLoggediN)
        {
            idPetugas= 0;
            username = null;
            namaPetugas = null;
            level = null;
            isLoggediN = true;

        }

    }
}
