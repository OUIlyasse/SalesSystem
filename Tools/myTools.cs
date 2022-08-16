using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Tools
{
    public static class myTools
    {
        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        public static void ILmsgBox(string msg)
        {
            XtraMessageBox.Show(msg);
        }

        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        public static void ILmsgBox(string msg, string title)
        {
            XtraMessageBox.Show(msg, title, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        /// <param name="button">Buttons</param>
        public static void ILmsgBox(string msg, string title, MessageBoxButtons button)
        {
            XtraMessageBox.Show(msg, title, button);
        }

        /// <summary>
        /// Display the message in Devexpress style
        /// </summary>
        /// <param name="msg">Message</param>
        /// <param name="title">Title</param>
        /// <param name="button">Buttons</param>
        /// <param name="icon">Icon</param>
        public static void ILmsgBox(string msg, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(msg, title, button, icon);
        }
    }
}