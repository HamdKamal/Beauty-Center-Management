using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace SamarPro.CONTROLS
{
    class DropShaddow
    {
        public void DesibleCombo(Control c,Boolean Std)
        {
            foreach (Control combo in c.Controls)
            {
                if (combo is ComboBox)
                {
                    combo.Enabled = Std;
                }
            }
        }
        public void JustNumber(KeyPressEventArgs r)
        {
            if (!char.IsDigit(r.KeyChar))
            {
                if (!char.IsControl(r.KeyChar))
                {
                    if (!char.IsPunctuation(r.KeyChar))
                    {
                        if (!char.IsWhiteSpace(r.KeyChar))
                        {
                            if (!char.IsSeparator(r.KeyChar))
                                r.Handled = true;
                        }
                    }
                }
            }
        }
        public void JustString(KeyPressEventArgs r)
        {
            if (char.IsDigit(r.KeyChar))
            {
                r.Handled = true;
                if (!char.IsControl(r.KeyChar))
                {
                    if (!char.IsPunctuation(r.KeyChar))
                    {
                        if (char.IsWhiteSpace(r.KeyChar))
                        {
                            if (char.IsSeparator(r.KeyChar))
                                r.Handled = false;
                        }
                    }
                }
            }
        }
        public void For_Quan(KeyPressEventArgs e)
        {
            Char DesimalSepretor = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (! Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DesimalSepretor)
            {
                e.Handled = true;
            }
        }

        public void for_Tell(KeyPressEventArgs e )
        {
            if (Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public void Just_Email(KeyPressEventArgs e)
        {
            //System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            //if (TextBox_Name.Text.Length > 0)
            //{
            //    if (rEMail.IsMatch(TextBox_Name.Text))
            //    {
            //        MessageBox.Show("يوجد خطأ في الإيميل ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        TextBox_Name.SelectAll();
            //        e.Handled = true;
            //    }
            //}
        }

        #region Shadowing

            #region Fields


        private const int WM_NCHITTEST = 0x84;
        private const int WS_MINIMIZEBOX = 0x20000;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int CS_DBLCLKS = 0x8;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        #endregion

        #region Structures

        [EditorBrowsable(EditorBrowsableState.Never)]
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        #endregion

        #region Methods

        #region Public

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static bool IsCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6) return false;

            bool enabled;
            DwmIsCompositionEnabled(out enabled);

            return enabled;
        }

        #endregion

        #region Private

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        private bool CheckIfAeroIsEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);

                return (enabled == 1) ? true : false;
            }
            return false;
        }

        #endregion

        #region Overrides

        public void ApplyShadows(Form form)
        {
            var v = 2;

            DwmSetWindowAttribute(form.Handle, 2, ref v, 4);

            MARGINS margins = new MARGINS()
            {
                bottomHeight = 1,
                leftWidth = 0,
                rightWidth = 0,
                topHeight = 0
            };

            DwmExtendFrameIntoClientArea(form.Handle, ref margins);
        }

        #endregion

        #endregion

        #endregion

    }
}
