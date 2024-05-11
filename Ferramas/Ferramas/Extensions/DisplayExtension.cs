using System.Globalization;

namespace Ferramas.Extensions;

public static class DisplayExtension
{
    public static string CLPFormat(this float clp)
    {
        string format = clp.ToString("###,###,##0", CultureInfo.GetCultureInfo("es-CL"));
        return $"$ {format} CLP";
    }

    public static string USDFormat(this float usd)
    {
        string format = usd.ToString("###,###,##0.###", CultureInfo.GetCultureInfo("es-CL"));
        return $"$ {format} USD";
    }


}
