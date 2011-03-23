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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace Skybound.Gecko
{
	partial class PropertiesDialog : Form
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
		public PropertiesDialog()
		{
			InitializeComponent();
		}
		
		public PropertiesDialog(nsIDOMHTMLDocument doc) : this()
		{
			txtTitle.Text = nsString.Get(doc.GetTitle);
			txtAddress.Text = nsString.Get(doc.GetURL);
			txtReferrer.Text = nsString.Get(doc.GetReferrer);
			
			nsIDOMDocumentType docType = doc.GetDoctype();
			if (docType != null)
				lblDocType.Text = nsString.Get(docType.GetPublicId);
			else
				lblDocType.Text = "(none)";
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.F1)
			{
				// display a simple about box when you press F1
				string versionString = GetType().Assembly.GetName().Version.ToString();
				
				MessageBox.Show("Skybound GeckoFX v" + versionString + "\r\n\r\n(C) 2008 Skybound Software. All Rights Reserved.\r\nhttp://www.geckofx.org",
					"About GeckoFX", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			return base.ProcessDialogKey(keyData);
		}

        private void PropertiesDialog_Load(object sender, EventArgs e)
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
	
	/// <summary>
	/// A custom tab page which provides transparent backgrounds to read-only text boxes.
	/// </summary>
	#region class XPTabPage : TabPage
	class XPTabPage : TabPage
	{
		[DllImport("gdi32")]
		static extern int SetBkMode(IntPtr hdc, int nBkMode);
		
		[DllImport("gdi32")]
		static extern IntPtr GetStockObject(int nIndex);
		
		protected override void WndProc(ref Message m)
		{
			const int WM_CTLCOLOREDIT = 0x133;
			const int WM_CTLCOLORSTATIC = 0x138;
			const int TRANSPARENT = 0x1;
			const int NULL_BRUSH = 0x5;
			
			if (Application.RenderWithVisualStyles)
			{
				if (m.Msg == WM_CTLCOLORSTATIC || m.Msg == WM_CTLCOLOREDIT)
				{
					SetBkMode(m.WParam, TRANSPARENT);
					m.Result = GetStockObject(NULL_BRUSH);
					
					return;
				}
			}
			base.WndProc(ref m);
		}
	}
	#endregion
	
	/// <summary>
	/// A read-only text box with a transparent background.
	/// </summary>
	#region class ReadOnlyTextBox : TextBox
	class ReadOnlyTextBox : TextBox
	{
		public ReadOnlyTextBox()
		{
			this.ReadOnly = true;
			this.Multiline = true;
			this.WordWrap = false;
		}
		
		protected override void WndProc(ref Message m)
		{
			const int WM_ERASEBKGND = 0x14;
			
			switch (m.Msg)
			{
				case WM_ERASEBKGND:
					if (Application.RenderWithVisualStyles)
					{
						VisualStyleRenderer rend = new VisualStyleRenderer(VisualStyleElement.TextBox.TextEdit.Normal);
						
						rend.DrawParentBackground(new DeviceContext(m.WParam), this.ClientRectangle, this);
						
						m.Result = (IntPtr)1;
						return;
					}
					break;
			}
			
			base.WndProc(ref m);
		}

		protected override void OnLostFocus(EventArgs e)
		{
			Refresh();
			
			base.OnLostFocus(e);
		}
		
		class DeviceContext : IDeviceContext
		{
			public DeviceContext(IntPtr hdc)
			{
				this._Hdc = hdc;
			}
			
			public IntPtr GetHdc() { return _Hdc; }
			IntPtr _Hdc;
			
			public void ReleaseHdc() { }
			public void Dispose() { }
		}
	}
	#endregion
}
