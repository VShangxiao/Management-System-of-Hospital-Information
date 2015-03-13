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
	/// SendMedicine 的摘要说明。
	/// </summary>
	public class SendMedicine : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnSend;
		private HMS.DataSet3 dataSet31;
		private System.Data.SqlClient.SqlDataAdapter da1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.DataView dataView1;
		private System.Data.DataView dataView2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SendMedicine()
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
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.dataView2 = new System.Data.DataView();
			this.dataSet31 = new HMS.DataSet3();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataView1 = new System.Data.DataView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.da1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.da2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid2
			// 
			this.dataGrid2.CaptionVisible = false;
			this.dataGrid2.DataMember = "";
			this.dataGrid2.DataSource = this.dataView2;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(8, 256);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(784, 112);
			this.dataGrid2.TabIndex = 6;
			// 
			// dataView2
			// 
			this.dataView2.Table = this.dataSet31.门诊划价明细;
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataView1;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 136);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(784, 112);
			this.dataGrid1.TabIndex = 5;
			this.dataGrid1.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
			// 
			// dataView1
			// 
			this.dataView1.Table = this.dataSet31.门诊划价;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSend);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt4);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Location = new System.Drawing.Point(0, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(800, 112);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "搜索";
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(640, 40);
			this.btnSend.Name = "btnSend";
			this.btnSend.TabIndex = 10;
			this.btnSend.Text = "发药";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(136, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "例如：‘2007－7－2’";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(536, 40);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "搜索";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(288, 64);
			this.label4.Name = "label4";
			this.label4.TabIndex = 7;
			this.label4.Text = "结束时间";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 64);
			this.label3.Name = "label3";
			this.label3.TabIndex = 6;
			this.label3.Text = "开始时间";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(288, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "姓名";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "编号";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(400, 56);
			this.txt4.Name = "txt4";
			this.txt4.TabIndex = 3;
			this.txt4.Text = "";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(120, 64);
			this.txt3.Name = "txt3";
			this.txt3.TabIndex = 2;
			this.txt3.Text = "";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(400, 24);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 1;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(120, 32);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 0;
			this.txt1.Text = "";
			// 
			// da1
			// 
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "门诊划价", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("姓名", "姓名"),
																																																  new System.Data.Common.DataColumnMapping("性别", "性别"),
																																																  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																  new System.Data.Common.DataColumnMapping("科室", "科室"),
																																																  new System.Data.Common.DataColumnMapping("挂号编号", "挂号编号"),
																																																  new System.Data.Common.DataColumnMapping("医生", "医生"),
																																																  new System.Data.Common.DataColumnMapping("划价时间", "划价时间"),
																																																  new System.Data.Common.DataColumnMapping("划价员", "划价员"),
																																																  new System.Data.Common.DataColumnMapping("是否收费", "是否收费"),
																																																  new System.Data.Common.DataColumnMapping("收费员", "收费员"),
																																																  new System.Data.Common.DataColumnMapping("收费时间", "收费时间"),
																																																  new System.Data.Common.DataColumnMapping("划价金额", "划价金额"),
																																																  new System.Data.Common.DataColumnMapping("是否发药", "是否发药"),
																																																  new System.Data.Common.DataColumnMapping("发药时间", "发药时间"),
																																																  new System.Data.Common.DataColumnMapping("发药员", "发药员")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT b.姓名, b.性别, a.编号, a.科室, a.挂号编号, a.医生, a.划价时间, a.划价员, a.是否收费, a.收费员, a.收费时间" +
				", a.划价金额, a.是否发药, a.发药时间, a.发药员 FROM 门诊划价 a INNER JOIN 门诊挂号 b ON a.挂号编号 = b.编号 W" +
				"HERE (a.是否发药 = \'否\') AND (a.是否收费 = \'是\')";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// da2
			// 
			this.da2.SelectCommand = this.sqlSelectCommand2;
			this.da2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "门诊划价明细", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																	new System.Data.Common.DataColumnMapping("药品编号", "药品编号"),
																																																	new System.Data.Common.DataColumnMapping("名称", "名称"),
																																																	new System.Data.Common.DataColumnMapping("单价", "单价"),
																																																	new System.Data.Common.DataColumnMapping("数量", "数量"),
																																																	new System.Data.Common.DataColumnMapping("金额", "金额"),
																																																	new System.Data.Common.DataColumnMapping("划价编号", "划价编号")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT DISTINCT a.编号, a.药品编号, b.名称, a.单价, a.数量, a.金额, a.划价编号 FROM 门诊划价明细 a INNER " +
				"JOIN v收费项目及药品 b ON a.药品编号 = b.编号";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// SendMedicine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(840, 416);
			this.Controls.Add(this.dataGrid2);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.groupBox1);
			this.Name = "SendMedicine";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SendMedicine";
			this.Load += new System.EventHandler(this.SendMedicine_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	

		private void SendMedicine_Load(object sender, System.EventArgs e)
		{
			
			try
			{
				dataSet31.EnforceConstraints=false;//去掉约束
				da1.Fill(dataSet31);
				da2.Fill(dataSet31);
			
				dataView2.RowFilter="划价编号='"+dataGrid1[0,2].ToString().Trim()+"'";
				
				dataGrid1.CurrentCellChanged+=new EventHandler(dataGrid1_CurrentCellChanged);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
    
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			string filter="";
			if(txt1.Text.Trim()!="")
			{
				filter+="编号 like '%"+txt1.Text.Trim()+"%' AND ";
			}
			if(txt2.Text.Trim()!="")
			{
				filter+="姓名 like '%"+txt2.Text.Trim()+"%' AND ";
			}
			if(txt3.Text.Trim()!="")
			{
				filter+="划价时间>='"+txt3.Text.Trim()+"' AND ";
			}
			if(txt4.Text.Trim()!="")
			{
				filter+="划价时间<='"+txt4.Text.Trim()+"' AND ";
			}
			int length=filter.Length;
			if(length>0)
			{
				filter=filter.Substring(0,length-5);
			}
			dataView1.RowFilter=filter;
			if(dataView1.Count>0)
			{				
				dataView2.RowFilter="划价编号='"+dataGrid1[0,2].ToString().Trim()+"'";
			}
		}
     
		private void btnSend_Click(object sender, System.EventArgs e)
		{
			string message = "确认是否要发药";
			string caption = "确认框";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons,
				MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
				MessageBoxOptions.RightAlign);

			if(result == DialogResult.Yes)
			{
                
				if(dataView1.Count==0)
				{
					MessageBox.Show("表中为空，无法执行发药","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					
				}
				else
				{
                    string strConn = SqlHelper.constr;
					SqlConnection cn=new SqlConnection(strConn);
					cn.Open();
					SqlCommand cmd=cn.CreateCommand();
					cmd.CommandText="exec sf_药品发出 "+dataGrid1[dataGrid1.CurrentRowIndex,2].ToString().Trim();
					cmd.ExecuteNonQuery();
					dataSet31.Clear();
					da1.Fill(dataSet31);
					da2.Fill(dataSet31);
					if(dataView1.Count>0)
					{
						dataView2.RowFilter="划价编号='"+dataGrid1[0,2].ToString().Trim()+"'";
					}	
					MessageBox.Show("发药成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
				return;
			}
		}
      
		private void dataGrid1_CurrentCellChanged(object sender, System.EventArgs e)
		{
			int i=dataGrid1.CurrentRowIndex;
			dataView2.RowFilter="划价编号='"+dataGrid1[i,2].ToString().Trim()+"'";
		}
		
	
	}
}
