using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS
{
	/// <summary>
	/// StoreQuery 的摘要说明。
	/// </summary>
	public class StoreQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private HMS.DataSet3 dataSet31;
		private System.Data.SqlClient.SqlDataAdapter da1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.DataView dataView1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StoreQuery()
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
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataSet31 = new HMS.DataSet3();
			this.da1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.dataView1 = new System.Data.DataView();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid1
			// 
			this.dataGrid1.CaptionVisible = false;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.DataSource = this.dataView1;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(24, 96);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(560, 184);
			this.dataGrid1.TabIndex = 15;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(296, 64);
			this.txt3.Name = "txt3";
			this.txt3.TabIndex = 14;
			this.txt3.Text = "";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(152, 64);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 13;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(16, 64);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 12;
			this.txt1.Text = "";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(496, 48);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 11;
			this.btnSearch.Text = "搜索";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(296, 32);
			this.label3.Name = "label3";
			this.label3.TabIndex = 10;
			this.label3.Text = "药品名称";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(160, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 9;
			this.label2.Text = "药品编号";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 8;
			this.label1.Text = "库房";
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// da1
			// 
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "药品库存", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("名称", "名称"),
																																																  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																  new System.Data.Common.DataColumnMapping("库房", "库房"),
																																																  new System.Data.Common.DataColumnMapping("药品编号", "药品编号"),
																																																  new System.Data.Common.DataColumnMapping("药品数量", "药品数量"),
																																																  new System.Data.Common.DataColumnMapping("备注", "备注")})});
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// dataView1
			// 
			this.dataView1.Table = this.dataSet31.药品库存;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT b.名称, a.编号, a.库房, a.药品编号, a.药品数量, a.备注 FROM 药品库存 a INNER JOIN 药品资料 b ON a." +
				"药品编号 = b.编号";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// StoreQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(736, 360);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "StoreQuery";
			this.Text = "StoreQuery";
			this.Load += new System.EventHandler(this.StoreQuery_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			string filter="";
			if(txt1.Text.Trim()!="")
			{
				filter+="库房 like '%"+txt1.Text.Trim()+"%' AND ";
			}
			if(txt2.Text.Trim()!="")
			{
				filter+="药品编号 like '%"+txt2.Text.Trim()+"%' AND ";
			}
			if(txt3.Text.Trim()!="")
			{
				filter+="名称 like '%"+txt3.Text.Trim()+"%' AND ";
			}
			
			int length=filter.Length;
			if(length>0)
			{
				filter=filter.Substring(0,length-5);
			}
			dataView1.RowFilter=filter;
		}
      
		private void StoreQuery_Load(object sender, System.EventArgs e)
		{
			da1.Fill(dataSet31);
		}
	}
}
