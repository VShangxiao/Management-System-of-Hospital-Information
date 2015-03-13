using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HMS
{
	/// <summary>
	/// MainFrm 的摘要说明。
	/// </summary>
	public class MainFrm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.StatusBarPanel statusBarPanel3;
        private IContainer components;
        private static Login frmLogin;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private bool Logout = false;

		public MainFrm()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
            this.Closed += new EventHandler(MainFrm_Closed);
            this.Closing += new CancelEventHandler(MainFrm_Closing);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem9,
            this.menuItem12,
            this.menuItem15});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "信息管理";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "药品信息";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "收费项目";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem7});
            this.menuItem4.Text = "门诊管理";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "挂号管理";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "划价管理";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 2;
            this.menuItem7.Text = "收费管理";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 2;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10,
            this.menuItem11});
            this.menuItem9.Text = "统计查询";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "科室挂号量";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 1;
            this.menuItem11.Text = "药品库存量";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem14});
            this.menuItem12.Text = "帮助";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "流程说明";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 1;
            this.menuItem14.Text = "技术支持";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 4;
            this.menuItem15.Text = "退出系统";
            this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 338);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(904, 22);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.PanelClick += new System.Windows.Forms.StatusBarPanelClickEventHandler(this.statusBar1_PanelClick);
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.ToolTipText = "sansan";
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Name = "statusBarPanel3";
            // 
            // MainFrm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(904, 360);
            this.Controls.Add(this.statusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【HMS】医院管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Login loginFrm = new Login();

            frmLogin = loginFrm;
            Application.Run(loginFrm);
		}

        private void MainFrm_Closed(object sender, EventArgs e)
        {
            if (!Logout)
                Application.Exit();
            else
                frmLogin.Show();
        }

        private void MainFrm_Closing(object sender, CancelEventArgs e)
        {
            if (MessageBox.Show("确认退出?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                Logout = false;
            }

        }

		
		private bool checkChildFrmExist(string childFrmName)
		{
			foreach(Form childFrm in this.MdiChildren)
			{
				if(childFrm.Name == childFrmName)
				{
					if(childFrm.WindowState == FormWindowState.Minimized)
						childFrm.WindowState = FormWindowState.Normal;
					childFrm.Activate();
					return true;
				}
			}
			return false;
		}

		
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("MedInfo") == true)
			{
				return;
			}
			MedInfo newFrm=new MedInfo();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

	
		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("ServiceInfo") == true)
			{
				return;
			}
			ServiceInfo newFrm=new ServiceInfo();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

	
		private void menuItem5_Click(object sender, System.EventArgs e)
		{
		
		
			if (this.checkChildFrmExist("ClinicReg") == true)
			{
				return;
			}
			ClinicReg newFrm=new ClinicReg();
			newFrm.MdiParent = this;
			newFrm.Show();
		}

	
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("ClinicPriceConfirm") == true)
			{
				return;
			}
			ClinicPriceConfirm newFrm=new ClinicPriceConfirm();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

		
		private void menuItem7_Click(object sender, System.EventArgs e)
		{		
			
			if (this.checkChildFrmExist("ClinicCharge") == true)
			{
				return;
			}
			ClinicCharge newFrm=new ClinicCharge();
			newFrm.MdiParent = this;
			newFrm.Show();
		}
		
		
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("SendMedicine") == true)
			{
				return;
			}
			SendMedicine newFrm=new SendMedicine();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

		
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
		
		
			if (this.checkChildFrmExist("RegQuery") == true)
			{
				return;
			}
			RegQuery newFrm=new RegQuery();
			newFrm.MdiParent = this;
			newFrm.Show();
		}

	
		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			
		
			if (this.checkChildFrmExist("StoreQuery") == true)
			{
				return;
			}
			StoreQuery newFrm=new StoreQuery();
			newFrm.MdiParent = this;
			newFrm.Show();
		
		}

		
		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("Systemshow") == true)
			{
				return;
			}
			Systemshow newFrm=new Systemshow();
			newFrm.MdiParent = this;
			newFrm.Show();
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
			
			if (this.checkChildFrmExist("Tecsupport") == true)
			{
				return;
			}
			Tecsupport newFrm=new Tecsupport();
			newFrm.MdiParent = this;
			newFrm.Show();
		}

        private void statusBar1_PanelClick(object sender, StatusBarPanelClickEventArgs e)
        {

        }

	


	}
}
