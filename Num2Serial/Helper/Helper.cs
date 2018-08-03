using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Num2Serial.Helper
{
    public static class Helper
    {
        public static SccompVM ToViewModel(this Sccomp sccomp)
        {
            if (sccomp == null)
                return null;

            var s = new SccompVM
            {
                sccomp = sccomp,
                compnam = sccomp.compnam,
                compcod = sccomp.compcod,
                path = sccomp.path
            };

            return s;
        }

        public static List<SccompVM> ToViewModel(this IEnumerable<Sccomp> sccomp)
        {
            var s = new List<SccompVM>();

            foreach (var item in sccomp)
            {
                s.Add(item.ToViewModel());
            }

            return s;
        }

        public static string RewriteDataPath(this Sccomp selected_comp)
        {
            string path = string.Empty;

            if (selected_comp.path.Contains("(")) // TAFA Version
            {
                int start_ndx = selected_comp.path.IndexOf("(");
                int length = selected_comp.path.Length - start_ndx;
                string non_bracket = selected_comp.path.Substring(start_ndx, length).Trim().TrimStart('(').TrimEnd(')');
                path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\" + non_bracket + @"\";
            }
            else
            {
                if (selected_comp.path.TrimStart().StartsWith(@"\\"))
                {
                    path = selected_comp.path.TrimStart();
                }
                else
                {
                    path = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName + @"\" + selected_comp.path.Trim() + @"\";
                }
            }

            return path;
        }
    }
}
