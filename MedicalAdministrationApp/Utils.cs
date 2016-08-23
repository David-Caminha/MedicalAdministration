using System;
using System.Data.SqlClient;

namespace MedicalAdministrationApp
{
    public static class Utils
    {
        public static string SafeGetString(SqlDataReader reader, string fieldname)
        {
            int colIndex = reader.GetOrdinal(fieldname);
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }

        public static DateTime? SafeGetDate(SqlDataReader reader, string fieldname)
        {
            int colIndex = reader.GetOrdinal(fieldname);
            if (!reader.IsDBNull(colIndex))
                return reader.GetDateTime(colIndex);
            return null;
        }

        public static int SafeGetInt(SqlDataReader reader, string fieldname)
        {
            int colIndex = reader.GetOrdinal(fieldname);
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return -1;
        }
    }
}
