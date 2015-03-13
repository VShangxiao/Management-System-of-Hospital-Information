using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace HMS
{
	public class ServiceInfo : HMS.ParentForm
	{
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt9;
		private HMS.DataSet1 dataSet11;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.ComponentModel.IContainer components = null;

		public ServiceInfo()
		{
			// 该调用是 Windows 窗体设计器所必需的。
			InitializeComponent();

			// TODO: 在 InitializeComponent 调用后添加任何初始化
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region 设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.cmb1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txt8 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt9 = new System.Windows.Forms.TextBox();
			this.dataSet11 = new HMS.DataSet1();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Size = new System.Drawing.Size(888, 41);
			// 
			// txt2
			// 
			this.txt2.Name = "txt2";
			// 
			// label1
			// 
			this.label1.Name = "label1";
			this.label1.Text = "项目名称";
			// 
			// txt1
			// 
			this.txt1.Name = "txt1";
			// 
			// label2
			// 
			this.label2.Name = "label2";
			this.label2.Text = "拼音码";
			// 
			// txt3
			// 
			this.txt3.Name = "txt3";
			// 
			// label3
			// 
			this.label3.Name = "label3";
			this.label3.Text = "项目编号";
			// 
			// btnSearch
			// 
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "门诊收费项目";
			this.dataGrid1.DataSource = this.dataSet11;
			this.dataGrid1.Name = "dataGrid1";
			// 
			// da1
			// 
			this.da1.DeleteCommand = this.sqlDeleteCommand1;
			this.da1.InsertCommand = this.sqlInsertCommand1;
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "门诊收费项目", new System.Data.Common.DataColumnMapping[] {
																																																	new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																	new System.Data.Common.DataColumnMapping("名称", "名称"),
																																																	new System.Data.Common.DataColumnMapping("拼音码", "拼音码"),
																																																	new System.Data.Common.DataColumnMapping("费用", "费用"),
																																																	new System.Data.Common.DataColumnMapping("费用分类", "费用分类"),
																																																	new System.Data.Common.DataColumnMapping("病种分类", "病种分类"),
																																																	new System.Data.Common.DataColumnMapping("备注", "备注")})});
			this.da1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// cmb1
			// 
			this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.费用分类"));
			this.cmb1.Enabled = false;
			this.cmb1.Items.AddRange(new object[] {
													  "化验费",
													  "检查费",
													  "诊断费",
													  "治疗费",
													  "其他"});
			this.cmb1.Location = new System.Drawing.Point(584, 336);
			this.cmb1.Name = "cmb1";
			this.cmb1.Size = new System.Drawing.Size(120, 20);
			this.cmb1.TabIndex = 61;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 53;
			this.label4.Text = "编号";
			// 
			// txt4
			// 
			this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.编号"));
			this.txt4.Location = new System.Drawing.Point(24, 336);
			this.txt4.Name = "txt4";
			this.txt4.ReadOnly = true;
			this.txt4.Size = new System.Drawing.Size(64, 21);
			this.txt4.TabIndex = 57;
			this.txt4.Text = "";
			// 
			// txt5
			// 
			this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.名称"));
			this.txt5.Location = new System.Drawing.Point(104, 336);
			this.txt5.Name = "txt5";
			this.txt5.ReadOnly = true;
			this.txt5.Size = new System.Drawing.Size(152, 21);
			this.txt5.TabIndex = 56;
			this.txt5.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(104, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 50;
			this.label5.Text = "名称";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(584, 320);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 52;
			this.label8.Text = "费用分类";
			// 
			// txt7
			// 
			this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.费用"));
			this.txt7.Location = new System.Drawing.Point(384, 336);
			this.txt7.Name = "txt7";
			this.txt7.ReadOnly = true;
			this.txt7.Size = new System.Drawing.Size(80, 21);
			this.txt7.TabIndex = 59;
			this.txt7.Text = "";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(384, 320);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 48;
			this.label10.Text = "费用";
			// 
			// txt6
			// 
			this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.拼音码"));
			this.txt6.Location = new System.Drawing.Point(280, 336);
			this.txt6.Name = "txt6";
			this.txt6.ReadOnly = true;
			this.txt6.Size = new System.Drawing.Size(80, 21);
			this.txt6.TabIndex = 60;
			this.txt6.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(280, 320);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(88, 16);
			this.label15.TabIndex = 54;
			this.label15.Text = "拼音码";
			// 
			// txt8
			// 
			this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.病种分类"));
			this.txt8.Location = new System.Drawing.Point(488, 336);
			this.txt8.Name = "txt8";
			this.txt8.ReadOnly = true;
			this.txt8.Size = new System.Drawing.Size(80, 21);
			this.txt8.TabIndex = 58;
			this.txt8.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(488, 320);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 16);
			this.label18.TabIndex = 49;
			this.label18.Text = "病种分类";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(24, 368);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 51;
			this.label6.Text = "备注";
			// 
			// txt9
			// 
			this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "门诊收费项目.备注"));
			this.txt9.Location = new System.Drawing.Point(24, 384);
			this.txt9.Name = "txt9";
			this.txt9.ReadOnly = true;
			this.txt9.Size = new System.Drawing.Size(680, 21);
			this.txt9.TabIndex = 55;
			this.txt9.Text = "";
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 编号, 名称, 拼音码, 费用, 费用分类, 病种分类, 备注 FROM 门诊收费项目 WHERE (拼音码 LIKE @Param4 OR 拼音码" +
				" IS NULL) AND (名称 LIKE @Param5) AND (编号 LIKE @Param6)";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 100, "拼音码"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 100, "名称"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 20, "编号"));
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 门诊收费项目(编号, 名称, 拼音码, 费用, 费用分类, 病种分类, 备注) VALUES (@编号, @名称, @拼音码, @费用, " +
				"@费用分类, @病种分类, @备注); SELECT 编号, 名称, 拼音码, 费用, 费用分类, 病种分类, 备注 FROM 门诊收费项目 WHERE (编号" +
				" = @编号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@名称", System.Data.SqlDbType.VarChar, 100, "名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@拼音码", System.Data.SqlDbType.VarChar, 100, "拼音码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "费用", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用分类", System.Data.SqlDbType.VarChar, 100, "费用分类"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@病种分类", System.Data.SqlDbType.VarChar, 100, "病种分类"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 门诊收费项目 SET 编号 = @编号, 名称 = @名称, 拼音码 = @拼音码, 费用 = @费用, 费用分类 = @费用分类, 病种分类 = @病种分类, 备注 = @备注 WHERE (编号 = @Original_编号) AND (名称 = @Original_名称 OR @Original_名称 IS NULL AND 名称 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (拼音码 = @Original_拼音码 OR @Original_拼音码 IS NULL AND 拼音码 IS NULL) AND (病种分类 = @Original_病种分类 OR @Original_病种分类 IS NULL AND 病种分类 IS NULL) AND (费用 = @Original_费用 OR @Original_费用 IS NULL AND 费用 IS NULL) AND (费用分类 = @Original_费用分类 OR @Original_费用分类 IS NULL AND 费用分类 IS NULL); SELECT 编号, 名称, 拼音码, 费用, 费用分类, 病种分类, 备注 FROM 门诊收费项目 WHERE (编号 = @编号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@名称", System.Data.SqlDbType.VarChar, 100, "名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@拼音码", System.Data.SqlDbType.VarChar, 100, "拼音码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "费用", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用分类", System.Data.SqlDbType.VarChar, 100, "费用分类"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@病种分类", System.Data.SqlDbType.VarChar, 100, "病种分类"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@备注", System.Data.SqlDbType.VarChar, 100, "备注"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_名称", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_拼音码", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "拼音码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_病种分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "病种分类", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "费用", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "费用分类", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 门诊收费项目 WHERE (编号 = @Original_编号) AND (名称 = @Original_名称 OR @Original_名称 IS NULL AND 名称 IS NULL) AND (备注 = @Original_备注 OR @Original_备注 IS NULL AND 备注 IS NULL) AND (拼音码 = @Original_拼音码 OR @Original_拼音码 IS NULL AND 拼音码 IS NULL) AND (病种分类 = @Original_病种分类 OR @Original_病种分类 IS NULL AND 病种分类 IS NULL) AND (费用 = @Original_费用 OR @Original_费用 IS NULL AND 费用 IS NULL) AND (费用分类 = @Original_费用分类 OR @Original_费用分类 IS NULL AND 费用分类 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_名称", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "名称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_备注", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "备注", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_拼音码", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "拼音码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_病种分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "病种分类", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "费用", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "费用分类", System.Data.DataRowVersion.Original, null));
			// 
			// ServiceInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(888, 424);
			this.Controls.Add(this.cmb1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt7);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txt6);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txt8);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt9);
			this.Name = "ServiceInfo";
			this.Text = "【收费项目】";
			this.Load += new System.EventHandler(this.ServiceInfo_Load);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.txt3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.txt1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt2, 0);
			this.Controls.SetChildIndex(this.btnSearch, 0);
			this.Controls.SetChildIndex(this.dataGrid1, 0);
			this.Controls.SetChildIndex(this.txt9, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label18, 0);
			this.Controls.SetChildIndex(this.txt8, 0);
			this.Controls.SetChildIndex(this.label15, 0);
			this.Controls.SetChildIndex(this.txt6, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.txt7, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.txt5, 0);
			this.Controls.SetChildIndex(this.txt4, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.cmb1, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void ServiceInfo_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%%";
			da1.SelectCommand.Parameters[1].Value="%%";
			da1.SelectCommand.Parameters[2].Value="%%";
			da1.Fill(dataSet11);
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"门诊收费项目"];
			base.dataSet11=this.dataSet11;
		
		}

       private void btnSearch_Click(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%%";
			da1.SelectCommand.Parameters[1].Value="%%";
			da1.SelectCommand.Parameters[2].Value="%%";
			if(txt1.Text!="")
			{
				da1.SelectCommand.Parameters[0].Value="%"+txt1.Text+"%";
			}
			if(txt2.Text!="")
			{
				da1.SelectCommand.Parameters[1].Value="%"+txt2.Text+"%";
			}
			if(txt3.Text!="")
			{
				da1.SelectCommand.Parameters[2].Value="%"+txt3.Text+"%";
			}
			dataSet11.门诊收费项目.Clear();
			da1.Fill(dataSet11);
			base.dataSet11=this.dataSet11;
		}
	
		protected override bool CheckNotNull()
		{
			if(txt4.Text.Trim()=="")
			{
				MessageBox.Show("医疗收费项目编号不能为空，请输入编号","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
			if(txt5.Text.Trim()=="")
			{
				MessageBox.Show("医疗收费项目名称不能为空，请输入名称","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
			try
			{
                string strConn = SqlHelper.constr;
				SqlConnection cn=new SqlConnection(strConn);
				cn.Open();
				SqlCommand cmd=cn.CreateCommand();
				cmd.CommandText="select * from 门诊收费项目 where 编号='"+txt4.Text+"'";
				SqlDataReader dr=cmd.ExecuteReader();
				while(dr.Read())
				{
					MessageBox.Show("收费编号已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
					return(false);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return(base.CheckNotNull());
			
		}
	
		protected override void SetModifyMode(bool blnEdit)
		{
			base.SetModifyMode (blnEdit);
			txt4.ReadOnly=!blnEdit;
			txt5.ReadOnly=!blnEdit;
			txt6.ReadOnly=!blnEdit;
			txt7.ReadOnly=!blnEdit;
			txt8.ReadOnly=!blnEdit;
			txt9.ReadOnly=!blnEdit;
			cmb1.Enabled=blnEdit;
		}
	
       
	}
}

