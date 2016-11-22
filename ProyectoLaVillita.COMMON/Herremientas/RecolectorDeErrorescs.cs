using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace ProyectoLaVillita.COMMON.Herremientas
{
    static public class RecolectorDeErrorescs
    {
        public static void NotificarError(object obj, Exception ex)
        {
            StreamWriter writer = new StreamWriter("LogErrorers.txt", true);
            writer.WriteLine(String.Format("{0}: {1} en objeto: {2} en método: {3}", DateTime.Now.ToString(), obj.GetType().FullName, new StackTrace().GetFrame(1).GetMethod().Name));
            writer.Flush();
            writer.Close();
        }
    }
}
