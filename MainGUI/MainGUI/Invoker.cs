using System.Drawing;
using System.Windows.Forms;

namespace MainGUI
{
    static class Invoker
    {

        public enum Mode
        {
            SetMaximum = 0,
            SetValue = 1

        }

        //All Controls
        private delegate void _ChangeVisible(Control ctrl, bool state);

        //Forms
        private delegate void _ChangeVisibilityForm(Form frm, bool state);

        //NumericUpDown
        private delegate void _SetNumericValue(NumericUpDown ctrl, decimal val);

        //Controls
        private delegate void _SetText(Control cntrl, string msg, string clr);
        private delegate void _ChangeEnabled(Control cntrl, bool state);
        private delegate void _ChangeCursor(Control cntrl, Cursor state);

        //Progressbar
        private delegate void _SetPrgbValue(ProgressBar prgb, int value, Mode mode);

        //ListView
        private delegate void _AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "");
        private delegate void _ClearListView(ListView list);
        private delegate void _UpdateListView(ListView list, bool start = true);

        public static void ChangeEnabled(Control cntrl, bool state)
        {
            if (cntrl.InvokeRequired)
            {
                cntrl.Invoke(new _ChangeEnabled(ChangeEnabled), cntrl, state);
            }
            else
            {
                cntrl.Enabled = state;
            }
        }
        public static void ChangeCursor(Control cntrl, Cursor state)
        {
            if (cntrl.InvokeRequired)
            {
                cntrl.Invoke(new _ChangeCursor(ChangeCursor), cntrl, state);
            }
            else
            {
                cntrl.Cursor = state;
            }
        }

        public static void ChangeVisibilityForm(Form frm, bool state)
        {
            if (frm.InvokeRequired)
            {
                frm.Invoke(new _ChangeVisibilityForm(ChangeVisibilityForm), frm, state);
            }
            else
            {
                if (state)
                {
                    frm.Show();
                }
                else
                {
                    frm.Hide();
                }
            }
        }
        public static void SetNumericValue(NumericUpDown ctrl, decimal val)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new _SetNumericValue(SetNumericValue), ctrl, val);
            }
            else
            {
                ctrl.Value = val;
            }
        }
        public static void ChangeVisible(Control ctrl, bool state)
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new _ChangeVisible(ChangeVisible), ctrl, state);
            }
            else
            {
                ctrl.Visible = state;
            }
        }
        public static void SetText(Control cntrl, string msg, string clr = null)
        {

            if (cntrl.InvokeRequired)
            {
                cntrl.Invoke(new _SetText(SetText), cntrl, msg, clr);
            }
            else
            {
                cntrl.Text = msg;

                if (clr != null)
                {
                    cntrl.ForeColor = ColorTranslator.FromHtml(clr);
                }
            }

        }
        public static void UpdateList(ListView list, bool start = true)
        {
            if (list.InvokeRequired)
            {
                list.Invoke(new _UpdateListView(UpdateList), list, start);
            }
            else
            {
                if (start)
                {
                    list.BeginUpdate();
                }
                else
                {
                    list.EndUpdate();
                }
            }

        }
        public static void ClearList(ListView list)
        {
            if (list.InvokeRequired)
            {
                list.Invoke(new _ClearListView(ClearList), list);
            }
            else
            {
                list.Items.Clear();
            }

        }
        public static void AddListItem(ListView list, string value, bool subItem = false, string subValue = "", string tag = "")
        {
            if (list.InvokeRequired)
            {
                list.Invoke(new _AddListItem(AddListItem), list, value, subItem, subValue, tag);
            }
            else
            {
                ListViewItem itm = new ListViewItem();
                itm.Tag = tag;
                itm.Text = value;
                if (subItem)
                {
                    itm.SubItems.Add(subValue);
                }
                list.Items.Add(itm);
                //list.AutoResizeColumns(System.Windows.Forms.ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }

        public static void SetPrgbState(ProgressBar prgb, int value, Mode mode)
        {
            if (prgb.InvokeRequired)
            {
                prgb.Invoke(new _SetPrgbValue(SetPrgbState), prgb, value, mode);
            }
            else
            {
                if (mode == Mode.SetMaximum)
                {
                    prgb.Maximum = value;
                }
                else if (mode == Mode.SetValue)
                {
                    prgb.Value = value;
                }

            }

        }

    }
}
