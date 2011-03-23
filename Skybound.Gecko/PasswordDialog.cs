#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Skybound.Gecko
{
	partial class PasswordDialog : Form
	{
        [StructLayout(LayoutKind.Sequential)]
        public struct MARGINS
        {
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyButtomheight;
        }

        [DllImport("dwmapi.dll")]

        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarinset);
        
		public PasswordDialog()
		{
			InitializeComponent();
		}
		
		public PasswordDialog(string title, string text, string username, string password, string checkMessage, bool checkState) : this()
		{
			if (!string.IsNullOrEmpty(title))
				this.Text = title;
			
			lblText.Text = text;
			txtUserName.Text = username;
			txtPassword.Text = password;
			
			if (!string.IsNullOrEmpty(checkMessage))
			{
				checkBox.Text = checkMessage;
				checkBox.Checked = checkState;
			}
			else
			{
				checkBox.Visible = false;
				btnOK.Top = checkBox.Top;
				btnCancel.Top = checkBox.Top;
				this.ClientSize = new Size(this.ClientSize.Width, btnOK.Bottom + 6);
			}
		}
		
		public void DisableUserName()
		{
			txtUserName.Enabled = false;
		}

		public string UserName
		{
			get { return txtUserName.Text; }
		}

		public string Password
		{
			get { return txtPassword.Text; }
		}

		public bool IsChecked
		{
			get { return checkBox.Checked; }
		}

        private void PasswordDialog_Load(object sender, EventArgs e)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains("dwm"))
                {
                    MARGINS margins = new MARGINS();
                    margins.cxLeftWidth = -1;
                    margins.cxRightWidth = -1;
                    margins.cyTopHeight = -1;
                    margins.cyButtomheight = -1;
                    //set all the four value -1 to apply glass effect to the whole window
                    //set your own value to make specific part of the window glassy.
                    IntPtr hwnd = this.Handle;
                    int result = DwmExtendFrameIntoClientArea(hwnd, ref margins);
                    this.BackColor = System.Drawing.Color.BlanchedAlmond;
                    this.BackgroundImage = null;
                }
            }
        }
	}
}
