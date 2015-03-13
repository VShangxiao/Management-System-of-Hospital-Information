using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace HMS
{
	/// <summary>
	/// ClinicReg 的摘要说明。
	/// </summary>
	public class ClinicReg : System.Windows.Forms.Form
	{
		private string regID,infoID; //保存门诊编号和病人信息库编号
		protected System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton tBtnNew;
		private System.Windows.Forms.ToolBarButton tBtnSubmit;
		private System.Windows.Forms.ToolBarButton tBtnCancel;
		private System.Windows.Forms.ToolBarButton tBtnQuit;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmb3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmb2;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmb6;
		private System.Windows.Forms.ComboBox cmb4;
		private System.Windows.Forms.ComboBox cmb5;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		public ClinicReg()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ClinicReg));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tBtnNew = new System.Windows.Forms.ToolBarButton();
			this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
			this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
			this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmb4 = new System.Windows.Forms.ComboBox();
			this.cmb6 = new System.Windows.Forms.ComboBox();
			this.cmb5 = new System.Windows.Forms.ComboBox();
			this.cmb3 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmb2 = new System.Windows.Forms.ComboBox();
			this.cmb1 = new System.Windows.Forms.ComboBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tBtnNew,
																						this.tBtnSubmit,
																						this.tBtnCancel,
																						this.tBtnQuit});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(824, 41);
			this.toolBar1.TabIndex = 31;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tBtnNew
			// 
			this.tBtnNew.ImageIndex = 0;
			this.tBtnNew.Text = "新增";
			this.tBtnNew.ToolTipText = "新增";
			// 
			// tBtnSubmit
			// 
			this.tBtnSubmit.ImageIndex = 1;
			this.tBtnSubmit.Text = "保存";
			this.tBtnSubmit.ToolTipText = "保存";
			// 
			// tBtnCancel
			// 
			this.tBtnCancel.ImageIndex = 2;
			this.tBtnCancel.Text = "取消";
			this.tBtnCancel.ToolTipText = "取消";
			// 
			// tBtnQuit
			// 
			this.tBtnQuit.ImageIndex = 3;
			this.tBtnQuit.Text = "退出";
			this.tBtnQuit.ToolTipText = "退出";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(96, 328);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(96, 21);
			this.textBox6.TabIndex = 53;
			this.textBox6.Text = "选填";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox5.Location = new System.Drawing.Point(0, 328);
			this.textBox5.Name = "textBox5";
			this.textBox5.ReadOnly = true;
			this.textBox5.Size = new System.Drawing.Size(96, 21);
			this.textBox5.TabIndex = 52;
			this.textBox5.Text = "必填";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(400, 240);
			this.txt4.Name = "txt4";
			this.txt4.ReadOnly = true;
			this.txt4.TabIndex = 51;
			this.txt4.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(400, 200);
			this.label10.Name = "label10";
			this.label10.TabIndex = 50;
			this.label10.Text = "挂号时间";
			// 
			// cmb4
			// 
			this.cmb4.Items.AddRange(new object[] {
													  "普通1元",
													  "专家5元",
													  "特聘专家20元"});
			this.cmb4.Location = new System.Drawing.Point(504, 144);
			this.cmb4.Name = "cmb4";
			this.cmb4.Size = new System.Drawing.Size(121, 20);
			this.cmb4.TabIndex = 49;
			this.cmb4.SelectionChangeCommitted += new System.EventHandler(this.cmb4_SelectionChangeCommitted);
			// 
			// cmb6
			// 
			this.cmb6.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cmb6.Location = new System.Drawing.Point(360, 144);
			this.cmb6.Name = "cmb6";
			this.cmb6.Size = new System.Drawing.Size(121, 20);
			this.cmb6.TabIndex = 48;
			this.cmb6.DropDown += new System.EventHandler(this.cmb6_DropDown);
			// 
			// cmb5
			// 
			this.cmb5.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cmb5.Location = new System.Drawing.Point(216, 144);
			this.cmb5.Name = "cmb5";
			this.cmb5.Size = new System.Drawing.Size(121, 20);
			this.cmb5.TabIndex = 47;
			// 
			// cmb3
			// 
			this.cmb3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.cmb3.Location = new System.Drawing.Point(72, 144);
			this.cmb3.Name = "cmb3";
			this.cmb3.Size = new System.Drawing.Size(121, 20);
			this.cmb3.TabIndex = 46;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(184, 200);
			this.label9.Name = "label9";
			this.label9.TabIndex = 45;
			this.label9.Text = "挂号费用";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(512, 112);
			this.label8.Name = "label8";
			this.label8.TabIndex = 44;
			this.label8.Text = "挂号类型";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(368, 112);
			this.label7.Name = "label7";
			this.label7.TabIndex = 43;
			this.label7.Text = "医生";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(224, 112);
			this.label6.Name = "label6";
			this.label6.TabIndex = 42;
			this.label6.Text = "挂号科室";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(72, 112);
			this.label5.Name = "label5";
			this.label5.TabIndex = 41;
			this.label5.Text = "费用类型";
			// 
			// cmb2
			// 
			this.cmb2.Items.AddRange(new object[] {
													  "汉族",
													  "满族",
													  "回族",
													  "藏族",
													  "蒙古族"});
			this.cmb2.Location = new System.Drawing.Point(624, 64);
			this.cmb2.Name = "cmb2";
			this.cmb2.Size = new System.Drawing.Size(121, 20);
			this.cmb2.TabIndex = 40;
			// 
			// cmb1
			// 
			this.cmb1.Items.AddRange(new object[] {
													  "男",
													  "女"});
			this.cmb1.Location = new System.Drawing.Point(256, 64);
			this.cmb1.Name = "cmb1";
			this.cmb1.Size = new System.Drawing.Size(121, 20);
			this.cmb1.TabIndex = 39;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(192, 240);
			this.txt3.Name = "txt3";
			this.txt3.TabIndex = 38;
			this.txt3.Text = "";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(440, 64);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 37;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.txt1.Location = new System.Drawing.Point(64, 64);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 36;
			this.txt1.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(576, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 24);
			this.label4.TabIndex = 35;
			this.label4.Text = "民族";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(400, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 24);
			this.label3.TabIndex = 34;
			this.label3.Text = "年龄";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(208, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 24);
			this.label2.TabIndex = 33;
			this.label2.Text = "性别";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "姓名";
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ClinicReg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(824, 352);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cmb4);
			this.Controls.Add(this.cmb6);
			this.Controls.Add(this.cmb5);
			this.Controls.Add(this.cmb3);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cmb2);
			this.Controls.Add(this.cmb1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolBar1);
			this.Name = "ClinicReg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClinicReg";
			this.Load += new System.EventHandler(this.ClinicReg_Load);
			this.ResumeLayout(false);

		}
		#endregion

	   private void ClinicReg_Load(object sender, System.EventArgs e)
		{

            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct 名称 from 科室资料";
			SqlDataReader dr=cmb.ExecuteReader();
			cmb5.Items.Clear();
			while(dr.Read())
			{
				cmb5.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();
		}
   
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(e.Button.ToolTipText=="新增")
			{
				this.SetDefaultValue();
				this.regID=this.CreateNewID("select max(编号) 最大编号 from 门诊挂号");
				this.infoID=this.CreateNewID("select max(编号) 最大编号 from 病人信息库");				
			}
			if(e.Button.ToolTipText=="保存")
			{
				if(this.CheckNotNull()==false)
				{
					return;
				}
				this.SaveReg();
				this.clearInfo();

			}
			if(e.Button.ToolTipText=="取消")
			{
				this.clearInfo();
				
			}
			if(e.Button.ToolTipText=="退出")
			{
				this.Close();
			}
		}
      
		private void cmb6_DropDown(object sender, System.EventArgs e)
		{
			
			cmb6.Items.Clear();
			if(cmb5.Text.Trim()=="")
			{
				return;
			}
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText="select distinct 姓名 from 医生资料 where 科室='"+cmb5.Text.Trim()+"'";
			SqlDataReader dr=cmb.ExecuteReader();			
			while(dr.Read())
			{
				cmb6.Items.Add(dr.GetValue(0).ToString().Trim());
			}
			dr.Close();	
		}
		
		private void clearInfo()
		{
			txt1.Clear();
			txt2.Clear();
			txt3.Clear();
			txt4.Clear();
			cmb1.Text="";
			cmb2.Text="";
			cmb3.Text="";
			cmb4.Text="";
			cmb5.Text="";
			cmb6.Text="";
		}
	
		private void SetDefaultValue()
		{
			cmb1.SelectedText="男";
			cmb2.SelectedText="汉族";
			cmb3.SelectedText="自费";
			cmb4.SelectedText="普通";
			cmb5.SelectedText="内科";
			txt3.Text="1";
			txt4.Text=System.DateTime.Now.ToString();
		}
	  
		private void cmb4_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if(cmb4.SelectedIndex==0)
			{
				txt3.Text="1";
			}
			if(cmb4.SelectedIndex==1)
			{
				txt3.Text="5";
			}
			if(cmb4.SelectedIndex==2)
			{
				txt3.Text="20";
			}
		}
		
		private bool CheckNotNull()
		{
			if(txt1.Text.Trim()=="")
			{
				MessageBox.Show("病人姓名不能为空,请输入姓名","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb3.Text.Trim()=="")
			{
				MessageBox.Show("费用类型不能为空,请选择费用类型","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb5.Text.Trim()=="")
			{
				MessageBox.Show("挂号科室不能为空,请选择挂号科室","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			if(cmb6.Text.Trim()=="")
			{
				MessageBox.Show("未选择医生或您选择的挂号科室没有医生","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return(false);
			}
			return(true);
		}
	
		private void SaveReg()
		{
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			
			string insertStr="insert into 病人信息库([编号], [姓名], [性别], [年龄], [民族], [费用类型]) "
				+"values('"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"+txt2.Text.Trim()
				+"','"+cmb2.Text.Trim()+"','"+cmb3.Text.Trim()+"')";			
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"新增病人信息错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			insertStr="insert into 门诊挂号([编号], [病人编号], [姓名], [性别], [挂号科室], [费用类型],"
				+"[挂号类型], [挂号费用], [医生], [时间], [是否已划价]) "
				+"values('"+regID+"','"+infoID+"','"+txt1.Text.Trim()+"','"+cmb1.Text.Trim()+"','"
				+cmb5.Text.Trim()+"','"+cmb3.Text.Trim()+"','"+cmb4.Text.Trim()+"',CAST('"+txt3.Text
				+"' as decimal),'"+cmb6.Text.Trim()+"','"+txt4.Text+"','否')";
			cmb.CommandText=insertStr;
			try
			{
				cmb.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"新增门诊挂号错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}


		}
	
		private string CreateNewID(string sql)
		{
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmb=cn.CreateCommand();
			cmb.CommandText=sql;
			string result;
			if(cmb.ExecuteScalar()!=System.DBNull.Value)
			{
				result=cmb.ExecuteScalar().ToString().Trim();
			}
			else
			{
				return(System.DateTime.Now.Year.ToString()+"0000001");
			}
			result=result.Substring(4,7);
			int newID=Convert.ToInt32(result)+1;
			int length=newID.ToString().Length;
			string returnStr=System.DateTime.Now.Year.ToString();
			switch(length)
			{
				case 1:
					returnStr+="000000"+newID.ToString();					
					break;
				case 2:
					returnStr+="00000"+newID.ToString();					
					break;
				case 3:
					returnStr+="0000"+newID.ToString();					
					break;
				case 4:
					returnStr+="000"+newID.ToString();					
					break;
				case 5:
					returnStr+="00"+newID.ToString();					
					break;
				case 6:
					returnStr+="0"+newID.ToString();					
					break;
				case 7:
					returnStr+=newID.ToString();					
					break;
			}
			return(returnStr);
		}
    }
}
