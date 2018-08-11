using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Num2Serial.Helper
{
    public class Misc
    {
        public static Color MAIN_BG = Color.FromArgb(254, 226, 187);
        public static Color COL_HEADER_BG = Color.FromArgb(209, 149, 109);
    }

    public class WarrantyType
    {
        public enum TYPE
        {
            DEFAULT,
            SPECIFY
        }
        public const string Default = "ตามรายละเอียดสินค้า";
        public const string Specify = "ระบุเอง";
    }

    public class ComboboxItem
    {
        public object value { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return this.Text;
        }
    }

    public class ReIndexResult
    {
        public bool success { get; set; }
        public string err_message { get; set; }
    }

    public enum FORM_MODE
    {
        READ,
        EDIT
    }

    
}
