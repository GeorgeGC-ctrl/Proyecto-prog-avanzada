using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.LogicaNegocios
{
    //public class FileLogger : ILogger
    //{
    //    private readonly string rutaLog = @"C:\Logs\SistemaInventario.log";

    //    public void LogError(Exception ex)
    //    {
    //        try
    //        {
    //            Directory.CreateDirectory(
    //                Path.GetDirectoryName(rutaLog)!);

    //            string mensaje =
    //                $"==================================================\n" +
    //                $"FECHA Y HORA: {DateTime.Now}\n" +
    //                $"TIPO DE ERROR: {ex.GetType().FullName}\n" +
    //                $"MENSAJE: {ex.Message}\n" +
    //                $"MÉTODO AFECTADO: {ex.TargetSite}\n" +
    //                $"DETALLE TÉCNICO (Stack Trace):\n{ex.StackTrace}\n" +
    //                $"==================================================\n\n";

    //            File.AppendAllText(rutaLog, mensaje);
    //        }
    //        catch
    //        {
    //        }
    //    }

    //    public void LogInfo(string mensaje)
    //    {
    //        try
    //        {
    //            Directory.CreateDirectory(
    //                Path.GetDirectoryName(rutaLog)!);

    //            File.AppendAllText(
    //                rutaLog,
    //                $"[{DateTime.Now}] [INFO] {mensaje}{Environment.NewLine}");
    //        }
    //        catch
    //        {
    //        }
    //    }
    //}
}

