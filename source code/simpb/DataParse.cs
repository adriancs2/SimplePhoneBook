using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


public class DataParse
{
    public static decimal DecimalParse(object ob)
    {
        if (ob == null)
            return 0;
        if (ob is DBNull)
            return 0;

        decimal a = 0;
        if (ob.GetType() == typeof(bool))
        {
            if ((bool)ob)
                return 1;
            else
                return 0;
        }
        else if (decimal.TryParse(ob + "", out a))
        {

        }
        return a;
    }

    public static decimal DecimalParse(System.DBNull ob)
    {
        return 0;
    }

    public static bool BoolParse(object ob)
    {
        double a = 0;
        if (ob == null || ob is DBNull)
            return false;
        else if (Double.TryParse(ob.ToString(), out a))
        {
            if (a > 0)
                return true;
        }
        else if ((ob + "").ToUpper() == "TRUE")
            return true;
        else if ((ob + "").ToUpper() == "YES")
            return true;

        return false;
    }

    public static bool BoolParse(System.DBNull ob)
    {
        return false;
    }

    public static int IntParse(System.DBNull ob)
    {
        return 0;
    }

    public static int IntParse(object ob)
    {
        int a = 0;
        if (ob == null || ob is DBNull)
            return 0;
        else if (ob.GetType() == typeof(bool))
        {
            if ((bool)ob)
                return 1;
            else
                return 0;
        }
        else if (int.TryParse(ob + "", out a))
        {

        }
        return a;
    }

    public static DateTime DateParse(object ob)
    {
        //if (ob is System.DBNull)
        //    return DateTime.Now;
        DateTime dtime = DateTime.MinValue;
        DateTime.TryParse(ob + "", out dtime);
        return dtime;
    }

    public static string DateParseMySQLString(string s)
    {
        DateTime d = DateTime.MinValue;
        DateTimeFormatInfo df1 = new DateTimeFormatInfo();
        df1.DateSeparator = "-";
        DateTimeFormatInfo df2 = new DateTimeFormatInfo();
        df2.DateSeparator = "/";
        DateTimeFormatInfo df3 = new DateTimeFormatInfo();
        df3.DateSeparator = "\\";
        DateTimeFormatInfo df4 = new DateTimeFormatInfo();
        df4.DateSeparator = ".";

        if (DateTime.TryParseExact(s, "dd-MM-yyyy", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d.ToString("yyyy-MM-dd 00:00:00");
        }

        if (DateTime.TryParseExact(s, "dd-MM-yyyy", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d.ToString("yyyy-MM-dd 00:00:00");
        }

        if (DateTime.TryParseExact(s, "dd-MM-yyyy", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d.ToString("yyyy-MM-dd 00:00:00");
        }

        if (DateTime.TryParseExact(s, "dd-MM-yyyy", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d.ToString("yyyy-MM-dd 00:00:00");
        }

        return "0001-01-01 00:00:00";
    }

    public static string DateParseMySQLtoCSharp(object ob)
    {
        DateTime dtime = DateTime.MinValue;
        if (DateTime.TryParse(ob + "", out dtime))
        {
            if (dtime == DateTime.MinValue)
                return "";
            else
                return dtime.ToString("dd-MM-yyyy");
        }
        else
            return "";
    }

    public static DateTime DateParseExact(string s)
    {
        DateTime d = DateTime.MinValue;
        DateTimeFormatInfo df1 = new DateTimeFormatInfo();
        df1.DateSeparator = "-";
        DateTimeFormatInfo df2 = new DateTimeFormatInfo();
        df2.DateSeparator = "/";
        DateTimeFormatInfo df3 = new DateTimeFormatInfo();
        df3.DateSeparator = "\\";
        DateTimeFormatInfo df4 = new DateTimeFormatInfo();
        df4.DateSeparator = ".";

        if (DateTime.TryParseExact(s, "dd-MM-yyyy", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd/MM/yyyy", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd\\MM\\yyyy", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd.MM.yyyy", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        // =============================================

        if (DateTime.TryParseExact(s, "d-M-yyyy", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd-M-yyyy", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }
        
        if (DateTime.TryParseExact(s, "d-MM-yyyy", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d/M/yyyy", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d/MM/yyyy", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }
        
        if (DateTime.TryParseExact(s, "dd/M/yyyy", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d\\M\\yyyy", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d\\MM\\yyyy", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd\\M\\yyyy", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d.M.yyyy", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "d.MM.yyyy", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd.M.yyyy", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        return DateTime.MinValue;
    }

    public static DateTime DateTimeParseExact(string s)
    {
        DateTime d = DateTime.MinValue;
        DateTimeFormatInfo df1 = new DateTimeFormatInfo();
        df1.DateSeparator = "-";
        df1.TimeSeparator = ":";
        df1.PMDesignator = "pm";
        df1.AMDesignator = "am";

        DateTimeFormatInfo df2 = new DateTimeFormatInfo();
        df2.DateSeparator = "/";
        df2.TimeSeparator = df1.TimeSeparator;
        df2.PMDesignator = df1.PMDesignator;
        df2.AMDesignator = df1.AMDesignator;

        DateTimeFormatInfo df3 = new DateTimeFormatInfo();
        df3.DateSeparator = "\\";
        df3.TimeSeparator = df1.TimeSeparator;
        df3.PMDesignator = df1.PMDesignator;
        df3.AMDesignator = df1.AMDesignator;

        DateTimeFormatInfo df4 = new DateTimeFormatInfo();
        df4.DateSeparator = ".";
        df4.TimeSeparator = df1.TimeSeparator;
        df4.PMDesignator = df1.PMDesignator;
        df4.AMDesignator = df1.AMDesignator;

        if (DateTime.TryParseExact(s, "dd-MM-yyyy hh:mm tt", df1, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd/MM/yyyy hh:mm tt", df2, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd\\MM\\yyyy hh:mm tt", df3, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        if (DateTime.TryParseExact(s, "dd.MM.yyyy hh:mm tt", df4, DateTimeStyles.AllowWhiteSpaces, out d))
        {
            return d;
        }

        return DateTime.MinValue;
    }
}