using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace MinaApp
{
    class cls_Message
    {

        public void InsertMessage()
        {
            MessageBox.Show("تم التسجيل بنجاح...", "تسجيل جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult AskUpdateMessage()
        {
            DialogResult R;
            R = MessageBox.Show("هل تريد التعديل ؟" + "\n" + " !!!لايمكن الوصول للبيانات بعد التعديل", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            return R;
        }

        public void Updatemessage()
        {
            MessageBox.Show("تم التعديل بنجاح...", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public DialogResult AskDeleteMessage()
        {
            DialogResult R;
            R = MessageBox.Show("هل تريد الحذف ؟" + "\n" + " !!!لا يمكن الوصل للبيانات بعد الحذف", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            return R;
        }

        public void DeleteMessage()
        {
            MessageBox.Show("تم الحذف ...", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public void Null()
        {
            MessageBox.Show("áÇ íæÌÏ ÈíÇäÇÊ", "تحقق من البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        public void NullField()
        {
            MessageBox.Show("يرجى اكمال البيانات الناقصة ؟", "تحقق من البيانات", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }



    }
}
