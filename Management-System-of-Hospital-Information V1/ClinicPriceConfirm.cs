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
	/// ClinicPriceConfirm 的摘要说明。
	/// </summary>
	public class ClinicPriceConfirm : System.Windows.Forms.Form
	{
		private DataTable newTable;//保存门诊划价中的药品和收费项目信息
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGrid dataGrid3;
		private System.Windows.Forms.DataGrid dataGrid2;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Data.DataView dataView1;
		private System.Data.SqlClient.SqlDataAdapter da1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter da2;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private HMS.DataSet2 dataSet21;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ClinicPriceConfirm()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGrid3 = new System.Windows.Forms.DataGrid();
			this.dataView1 = new System.Data.DataView();
			this.dataSet21 = new HMS.DataSet2();
			this.dataGrid2 = new System.Windows.Forms.DataGrid();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.cmb1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.da1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.da2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGrid3);
			this.groupBox1.Controls.Add(this.dataGrid2);
			this.groupBox1.Controls.Add(this.btnCancel);
			this.groupBox1.Controls.Add(this.btnOK);
			this.groupBox1.Controls.Add(this.txt5);
			this.groupBox1.Controls.Add(this.txt4);
			this.groupBox1.Controls.Add(this.txt3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Controls.Add(this.cmb1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(880, 544);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "挂号信息";
			// 
			// dataGrid3
			// 
			this.dataGrid3.CaptionVisible = false;
			this.dataGrid3.DataMember = "";
			this.dataGrid3.DataSource = this.dataView1;
			this.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid3.Location = new System.Drawing.Point(64, 280);
			this.dataGrid3.Name = "dataGrid3";
			this.dataGrid3.ReadOnly = true;
			this.dataGrid3.Size = new System.Drawing.Size(592, 128);
			this.dataGrid3.TabIndex = 8;
			this.dataGrid3.Visible = false;
			this.dataGrid3.DoubleClick += new System.EventHandler(this.dataGrid3_DoubleClick);
			// 
			// dataView1
			// 
			this.dataView1.Table = this.dataSet21.v收费项目及药品;
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// dataGrid2
			// 
			this.dataGrid2.CaptionVisible = false;
			this.dataGrid2.DataMember = "门诊挂号";
			this.dataGrid2.DataSource = this.dataSet21;
			this.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid2.Location = new System.Drawing.Point(64, 112);
			this.dataGrid2.Name = "dataGrid2";
			this.dataGrid2.ReadOnly = true;
			this.dataGrid2.Size = new System.Drawing.Size(592, 152);
			this.dataGrid2.TabIndex = 7;
			this.dataGrid2.Visible = false;
			this.dataGrid2.DoubleClick += new System.EventHandler(this.dataGrid2_DoubleClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(608, 504);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "取消";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(504, 504);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 15;
			this.btnOK.Text = "保存";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txt5
			// 
			this.txt5.Location = new System.Drawing.Point(360, 512);
			this.txt5.Name = "txt5";
			this.txt5.TabIndex = 14;
			this.txt5.Text = "";
			// 
			// txt4
			// 
			this.txt4.Location = new System.Drawing.Point(184, 512);
			this.txt4.Name = "txt4";
			this.txt4.TabIndex = 13;
			this.txt4.Text = "";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(24, 512);
			this.txt3.Name = "txt3";
			this.txt3.TabIndex = 12;
			this.txt3.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(360, 480);
			this.label6.Name = "label6";
			this.label6.TabIndex = 11;
			this.label6.Text = "金融会计";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(184, 480);
			this.label5.Name = "label5";
			this.label5.TabIndex = 10;
			this.label5.Text = "医生";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 480);
			this.label4.Name = "label4";
			this.label4.TabIndex = 9;
			this.label4.Text = "科室";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 80);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(808, 392);
			this.dataGrid1.TabIndex = 6;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(552, 48);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 5;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(272, 48);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 4;
			this.txt1.Text = "";
			// 
			// cmb1
			// 
			this.cmb1.Location = new System.Drawing.Point(16, 48);
			this.cmb1.Name = "cmb1";
			this.cmb1.Size = new System.Drawing.Size(121, 20);
			this.cmb1.TabIndex = 3;
			this.cmb1.DropDown += new System.EventHandler(this.cmb1_DropDown);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(552, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "性别";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 24);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "姓名";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "门诊号";
			// 
			// da1
			// 
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "门诊挂号", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																  new System.Data.Common.DataColumnMapping("病人编号", "病人编号"),
																																																  new System.Data.Common.DataColumnMapping("姓名", "姓名"),
																																																  new System.Data.Common.DataColumnMapping("性别", "性别"),
																																																  new System.Data.Common.DataColumnMapping("挂号科室", "挂号科室"),
																																																  new System.Data.Common.DataColumnMapping("费用类型", "费用类型"),
																																																  new System.Data.Common.DataColumnMapping("挂号类型", "挂号类型"),
																																																  new System.Data.Common.DataColumnMapping("挂号费用", "挂号费用"),
																																																  new System.Data.Common.DataColumnMapping("医生", "医生"),
																																																  new System.Data.Common.DataColumnMapping("时间", "时间"),
																																																  new System.Data.Common.DataColumnMapping("是否已划价", "是否已划价")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 编号, 病人编号, 姓名, 性别, 挂号科室, 费用类型, 挂号类型, 挂号费用, 医生, 时间, 是否已划价 FROM 门诊挂号 WHERE (是" +
				"否已划价 = \'否\')";
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
																						  new System.Data.Common.DataTableMapping("Table", "v收费项目及药品", new System.Data.Common.DataColumnMapping[] {
																																																	  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																	  new System.Data.Common.DataColumnMapping("名称", "名称"),
																																																	  new System.Data.Common.DataColumnMapping("规格", "规格"),
																																																	  new System.Data.Common.DataColumnMapping("单位", "单位"),
																																																	  new System.Data.Common.DataColumnMapping("单价", "单价"),
																																																	  new System.Data.Common.DataColumnMapping("拼音码", "拼音码")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 编号, 名称, 规格, 单位, 单价, 拼音码 FROM v收费项目及药品";
			this.sqlSelectCommand2.Connection = this.sqlConnection1;
			// 
			// ClinicPriceConfirm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(904, 592);
			this.Controls.Add(this.groupBox1);
			this.Name = "ClinicPriceConfirm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ClinicPriceConfirm";
			this.Load += new System.EventHandler(this.ClinicPriceConfirm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
      
		private void ClinicPriceConfirm_Load(object sender, System.EventArgs e)
		{
			da1.Fill(dataSet21);
			da2.Fill(dataSet21);
			this.DataGridStateControl();
			
			newTable.RowChanged+=new DataRowChangeEventHandler(newTable_RowChanged);//每当表格中数据变化时，计算金额	
		}
		
		private void DataGridStateControl()
		{
			newTable = new DataTable();
			newTable.Columns.Add("编号",typeof(string));
			newTable.Columns.Add("名称",typeof(string));
			newTable.Columns.Add("规格",typeof(string));
			newTable.Columns.Add("单位",typeof(string));
			newTable.Columns.Add("单价",typeof(decimal));
			newTable.Columns.Add("数量",typeof(int));
			newTable.Columns.Add("金额",typeof(decimal),"单价*数量");			
			
			this.dataGrid1.DataSource = newTable;
			DataGridTableStyle ts = new DataGridTableStyle();
			DataGridTextBoxColumn aColumnTextColumn;
			ts.AllowSorting = false;
			ts.AlternatingBackColor = Color.LightGray;
			ts.MappingName = newTable.TableName;
			int numCols = newTable.Columns.Count;
			for (int i = 0;i< numCols;i++)
			{
				aColumnTextColumn = new DataGridTextBoxColumn();
				if( i==5 )
				{
					aColumnTextColumn.ReadOnly=false;
				}
				else
				{
					aColumnTextColumn.ReadOnly=true;
				}

				if (i == 0)
				{
					aColumnTextColumn.TextBox.DoubleClick+=new EventHandler(TextBox_DoubleClick);
				}
				if(i==0)
				{
					aColumnTextColumn.Width=130;			
				}
				
				if ( i == 1 )
				{
					aColumnTextColumn.Width = 150;
				}
				aColumnTextColumn.MappingName = newTable.Columns[i].ColumnName;
				aColumnTextColumn.HeaderText = newTable.Columns[i].ColumnName;
				if(i==0)
				{
					aColumnTextColumn.HeaderText ="编号【双击输入拼音】";
				}

				aColumnTextColumn.NullText = "";
				aColumnTextColumn.Format = "N"; 
				ts.GridColumnStyles.Add(aColumnTextColumn);
			}
			dataGrid1.TableStyles.Add(ts);
		}
        
		private void cmb1_DropDown(object sender, System.EventArgs e)
		{
			this.clearInfo();
			dataGrid2.Left=cmb1.Left;
			dataGrid2.Top=cmb1.Bottom+2;
			dataGrid2.Visible=true;
			dataGrid2.Show();
			dataGrid2.Focus();
		}
     
		private void dataGrid2_DoubleClick(object sender, System.EventArgs e)
		{
			int rowIndex=dataGrid2.CurrentCell.RowNumber;
			cmb1.Text=dataGrid2[rowIndex,0].ToString().Trim();
			txt1.Text=dataGrid2[rowIndex,2].ToString().Trim();
			txt2.Text=dataGrid2[rowIndex,3].ToString().Trim();
			txt3.Text=dataGrid2[rowIndex,4].ToString().Trim();
			txt4.Text=dataGrid2[rowIndex,8].ToString().Trim();
			dataGrid2.Visible=false;
		}
		
		private void TextBox_DoubleClick(object sender, EventArgs e)
		{
			string pym;
			InputBox newfrm = new InputBox();
			newfrm.label1.Text = "请输入药品或收费项目的拼音码:";
			newfrm.Text="输入";
			newfrm.Top=this.Top+this.Height/2;
			newfrm.Left=this.Left+this.Width/2;
			newfrm.ShowDialog();
			pym = newfrm.result;
			newfrm.Dispose();
			
			dataView1.RowFilter="拼音码 like '%"+pym+"%'";
			dataGrid3.Left=dataGrid1.Left+10;
			dataGrid3.Top=(dataGrid1.CurrentCell.RowNumber+1)*17+20+dataGrid1.Top;
			if(dataView1.Count!=0)
			{
				dataGrid3.Visible=true;
				dataGrid3.Show();
				dataGrid3.Focus();
			}
		}
	
		private void dataGrid3_DoubleClick(object sender, System.EventArgs e)
		{
			int rowIndex=dataGrid3.CurrentCell.RowNumber;
			DataRow aRow=newTable.NewRow();
			aRow["编号"]=dataGrid3[rowIndex,0].ToString();
			aRow["名称"]=dataGrid3[rowIndex,1].ToString();
			aRow["规格"]=dataGrid3[rowIndex,2].ToString();
			aRow["单位"]=dataGrid3[rowIndex,3].ToString();
			aRow["单价"]=Convert.ToDecimal(dataGrid3[rowIndex,4]).ToString();
			
			newTable.Rows.Add(aRow);
			dataGrid3.Visible=false;
		}
	
		private void sumMoney()
		{			
			decimal total=0;
			foreach(DataRow aRow in newTable.Rows)
			{
				if(aRow["金额"].ToString().Trim()!="")
				{
					total+=Convert.ToDecimal(aRow["金额"]);
				}
			}
			txt5.Text=total.ToString();
		}
	
		private void newTable_RowChanged(object sender, DataRowChangeEventArgs e)
		{
			this.sumMoney();

		}
		
	
		private void clearInfo()
		{
			newTable.Clear();
			txt1.Clear();
			txt2.Clear();
			txt3.Clear();
			txt4.Clear();
			txt5.Clear();
			cmb1.Text="";			
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
    
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			
			if(cmb1.Text=="")
			{
				MessageBox.Show("请先选择门诊号","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return;
			}
			if(newTable.Rows.Count==0)
			{
				MessageBox.Show("请填写药品和收费项目明细表","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
				return;
			}
			foreach(DataRow aRow in newTable.Rows)
			{
				if(aRow["金额"].ToString().Trim()=="")
				{
					MessageBox.Show("请填写药品或收费项目数量","提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					return;
				}
			}
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();

			string newID=this.CreateNewID("select max(编号) 最大编号 from 门诊划价");
		
			string insertStr="insert into 门诊划价([编号], [科室], [挂号编号], [医生], [划价时间],"
				+"[是否收费], [划价金额], [是否发药]) values('"+newID+"','"+txt3.Text+"','"+cmb1.Text
				+"','"+txt4.Text+"','"+System.DateTime.Now.ToString()+"','否',CAST('"+txt5.Text+"' as money)"
				+",'否')";
			try
			{
				cmd.CommandText=insertStr;
				cmd.ExecuteNonQuery();
			}
			catch(Exception express)
			{
				MessageBox.Show(express.ToString(),"新增门诊挂号错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}
			foreach(DataRow aRow in newTable.Rows)
			{
				insertStr="insert into 门诊划价明细([划价编号], [药品编号], [单价], [数量], [金额]) "
					+"values('"+newID+"','"+aRow["编号"].ToString()+"','"+aRow["单价"].ToString()+"','"
					+aRow["数量"].ToString()+"','"+aRow["金额"].ToString()+"')";
				try
				{
					cmd.CommandText=insertStr;
					cmd.ExecuteNonQuery();
				}
				catch(Exception express)
				{
					MessageBox.Show(express.ToString(),"新增门诊明细错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return;
				}
			}
			cmd.CommandText="update 门诊挂号 set 是否已划价='是' where 编号='"+cmb1.Text+"'";
			cmd.ExecuteNonQuery();
			this.clearInfo();
			dataSet21.Clear();
			da1.Fill(dataSet21);
			da2.Fill(dataSet21);		
		}
       
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			this.clearInfo();
		}


		

       
      }
}
