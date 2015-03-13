using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
	public class MedInfo : HMS.ParentForm
	{
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt4;
		private System.Windows.Forms.TextBox txt5;
		private System.Windows.Forms.TextBox txt6;
		private System.Windows.Forms.TextBox txt7;
		private System.Windows.Forms.TextBox txt8;
		private System.Windows.Forms.TextBox txt9;
		private System.Windows.Forms.TextBox txt10;
		private System.Windows.Forms.TextBox txt11;
		private System.Windows.Forms.TextBox txt12;
		private System.Windows.Forms.TextBox txt15;
		private System.Windows.Forms.TextBox txt16;
		private System.Windows.Forms.TextBox txt14;
		private System.Windows.Forms.TextBox txt13;
		private System.Windows.Forms.TextBox txt17;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private HMS.DataSet1 dataSet11;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label18;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.ComponentModel.IContainer components = null;

		public MedInfo()
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
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.cmb1 = new System.Windows.Forms.ComboBox();
			this.dataSet11 = new HMS.DataSet1();
			this.label4 = new System.Windows.Forms.Label();
			this.txt4 = new System.Windows.Forms.TextBox();
			this.txt5 = new System.Windows.Forms.TextBox();
			this.txt6 = new System.Windows.Forms.TextBox();
			this.txt7 = new System.Windows.Forms.TextBox();
			this.txt8 = new System.Windows.Forms.TextBox();
			this.txt9 = new System.Windows.Forms.TextBox();
			this.txt10 = new System.Windows.Forms.TextBox();
			this.txt11 = new System.Windows.Forms.TextBox();
			this.txt12 = new System.Windows.Forms.TextBox();
			this.txt15 = new System.Windows.Forms.TextBox();
			this.txt16 = new System.Windows.Forms.TextBox();
			this.txt14 = new System.Windows.Forms.TextBox();
			this.txt13 = new System.Windows.Forms.TextBox();
			this.txt17 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.label15 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
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
			this.label1.Text = "药品名称";
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
			this.label3.Text = "药品编号";
			// 
			// btnSearch
			// 
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "药品资料";
			this.dataGrid1.DataSource = this.dataSet11;
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(728, 224);
			// 
			// da1
			// 
			this.da1.DeleteCommand = this.sqlDeleteCommand1;
			this.da1.InsertCommand = this.sqlInsertCommand1;
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "药品资料", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("编号", "编号"),
																																																  new System.Data.Common.DataColumnMapping("名称", "名称"),
																																																  new System.Data.Common.DataColumnMapping("规格", "规格"),
																																																  new System.Data.Common.DataColumnMapping("整量单位", "整量单位"),
																																																  new System.Data.Common.DataColumnMapping("散量单位", "散量单位"),
																																																  new System.Data.Common.DataColumnMapping("入库单价", "入库单价"),
																																																  new System.Data.Common.DataColumnMapping("出库单价", "出库单价"),
																																																  new System.Data.Common.DataColumnMapping("批发价", "批发价"),
																																																  new System.Data.Common.DataColumnMapping("整散比", "整散比"),
																																																  new System.Data.Common.DataColumnMapping("分类", "分类"),
																																																  new System.Data.Common.DataColumnMapping("费用归类", "费用归类"),
																																																  new System.Data.Common.DataColumnMapping("拼音码", "拼音码"),
																																																  new System.Data.Common.DataColumnMapping("效期", "效期"),
																																																  new System.Data.Common.DataColumnMapping("上限", "上限"),
																																																  new System.Data.Common.DataColumnMapping("下限", "下限")})});
			this.da1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// cmb1
			// 
			this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.分类"));
			this.cmb1.Enabled = false;
			this.cmb1.Location = new System.Drawing.Point(112, 408);
			this.cmb1.Name = "cmb1";
			this.cmb1.Size = new System.Drawing.Size(120, 20);
			this.cmb1.TabIndex = 69;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(24, 328);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 50;
			this.label4.Text = "编号";
			// 
			// txt4
			// 
			this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.编号"));
			this.txt4.Location = new System.Drawing.Point(24, 344);
			this.txt4.Name = "txt4";
			this.txt4.ReadOnly = true;
			this.txt4.Size = new System.Drawing.Size(64, 21);
			this.txt4.TabIndex = 59;
			this.txt4.Text = "";
			// 
			// txt5
			// 
			this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.名称"));
			this.txt5.Location = new System.Drawing.Point(104, 344);
			this.txt5.Name = "txt5";
			this.txt5.ReadOnly = true;
			this.txt5.Size = new System.Drawing.Size(152, 21);
			this.txt5.TabIndex = 58;
			this.txt5.Text = "";
			// 
			// txt6
			// 
			this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.规格"));
			this.txt6.Location = new System.Drawing.Point(272, 344);
			this.txt6.Name = "txt6";
			this.txt6.ReadOnly = true;
			this.txt6.Size = new System.Drawing.Size(48, 21);
			this.txt6.TabIndex = 57;
			this.txt6.Text = "";
			// 
			// txt7
			// 
			this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.整量单位"));
			this.txt7.Location = new System.Drawing.Point(336, 344);
			this.txt7.Name = "txt7";
			this.txt7.ReadOnly = true;
			this.txt7.Size = new System.Drawing.Size(48, 21);
			this.txt7.TabIndex = 60;
			this.txt7.Text = "";
			// 
			// txt8
			// 
			this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.散量单位"));
			this.txt8.Location = new System.Drawing.Point(400, 344);
			this.txt8.Name = "txt8";
			this.txt8.ReadOnly = true;
			this.txt8.Size = new System.Drawing.Size(48, 21);
			this.txt8.TabIndex = 68;
			this.txt8.Text = "";
			// 
			// txt9
			// 
			this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.入库单价"));
			this.txt9.Location = new System.Drawing.Point(464, 344);
			this.txt9.Name = "txt9";
			this.txt9.ReadOnly = true;
			this.txt9.Size = new System.Drawing.Size(64, 21);
			this.txt9.TabIndex = 65;
			this.txt9.Text = "";
			// 
			// txt10
			// 
			this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.出库单价"));
			this.txt10.Location = new System.Drawing.Point(544, 344);
			this.txt10.Name = "txt10";
			this.txt10.ReadOnly = true;
			this.txt10.Size = new System.Drawing.Size(72, 21);
			this.txt10.TabIndex = 62;
			this.txt10.Text = "";
			// 
			// txt11
			// 
			this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.批发价"));
			this.txt11.Location = new System.Drawing.Point(632, 344);
			this.txt11.Name = "txt11";
			this.txt11.ReadOnly = true;
			this.txt11.Size = new System.Drawing.Size(72, 21);
			this.txt11.TabIndex = 55;
			this.txt11.Text = "";
			// 
			// txt12
			// 
			this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.整散比"));
			this.txt12.Location = new System.Drawing.Point(24, 408);
			this.txt12.Name = "txt12";
			this.txt12.ReadOnly = true;
			this.txt12.Size = new System.Drawing.Size(72, 21);
			this.txt12.TabIndex = 56;
			this.txt12.Text = "";
			// 
			// txt15
			// 
			this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.效期"));
			this.txt15.Location = new System.Drawing.Point(432, 408);
			this.txt15.Name = "txt15";
			this.txt15.ReadOnly = true;
			this.txt15.Size = new System.Drawing.Size(64, 21);
			this.txt15.TabIndex = 66;
			this.txt15.Text = "";
			// 
			// txt16
			// 
			this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.上限"));
			this.txt16.Location = new System.Drawing.Point(520, 408);
			this.txt16.Name = "txt16";
			this.txt16.ReadOnly = true;
			this.txt16.Size = new System.Drawing.Size(80, 21);
			this.txt16.TabIndex = 61;
			this.txt16.Text = "";
			// 
			// txt14
			// 
			this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.拼音码"));
			this.txt14.Location = new System.Drawing.Point(328, 408);
			this.txt14.Name = "txt14";
			this.txt14.ReadOnly = true;
			this.txt14.Size = new System.Drawing.Size(80, 21);
			this.txt14.TabIndex = 64;
			this.txt14.Text = "";
			// 
			// txt13
			// 
			this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.费用归类"));
			this.txt13.Location = new System.Drawing.Point(248, 408);
			this.txt13.Name = "txt13";
			this.txt13.ReadOnly = true;
			this.txt13.Size = new System.Drawing.Size(64, 21);
			this.txt13.TabIndex = 67;
			this.txt13.Text = "";
			// 
			// txt17
			// 
			this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "药品资料.下限"));
			this.txt17.Location = new System.Drawing.Point(624, 408);
			this.txt17.Name = "txt17";
			this.txt17.ReadOnly = true;
			this.txt17.Size = new System.Drawing.Size(80, 21);
			this.txt17.TabIndex = 63;
			this.txt17.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(104, 328);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 16);
			this.label5.TabIndex = 45;
			this.label5.Text = "名称";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(272, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 46;
			this.label6.Text = "规格";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(336, 328);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.TabIndex = 40;
			this.label9.Text = "整量单位";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(464, 328);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 16);
			this.label11.TabIndex = 43;
			this.label11.Text = "入库单价";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(400, 328);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 51;
			this.label12.Text = "散量单位";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(544, 328);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 16);
			this.label17.TabIndex = 53;
			this.label17.Text = "出库单价";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(632, 328);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 16);
			this.label16.TabIndex = 47;
			this.label16.Text = "批发价";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 392);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 48;
			this.label7.Text = "整散比";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(120, 392);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 49;
			this.label8.Text = "分类";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(536, 392);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 42;
			this.label10.Text = "上限";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(440, 392);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 16);
			this.label13.TabIndex = 54;
			this.label13.Text = "有效期";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(256, 392);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 16);
			this.label14.TabIndex = 41;
			this.label14.Text = "费用归类";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 编号, 名称, 规格, 整量单位, 散量单位, 入库单价, 出库单价, 批发价, 整散比, 分类, 费用归类, 拼音码, 效期, 上限, 下限 FR" +
				"OM 药品资料 WHERE (拼音码 LIKE @Param4 OR 拼音码 IS NULL) AND (名称 LIKE @Param5) AND (编号 LI" +
				"KE @Param6)";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 50, "拼音码"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 150, "名称"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 20, "编号"));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO 药品资料(编号, 名称, 规格, 整量单位, 散量单位, 入库单价, 出库单价, 批发价, 整散比, 分类, 费用归类, 拼音码, 效期, 上限, 下限) VALUES (@编号, @名称, @规格, @整量单位, @散量单位, @入库单价, @出库单价, @批发价, @整散比, @分类, @费用归类, @拼音码, @效期, @上限, @下限); SELECT 编号, 名称, 规格, 整量单位, 散量单位, 入库单价, 出库单价, 批发价, 整散比, 分类, 费用归类, 拼音码, 效期, 上限, 下限 FROM 药品资料 WHERE (编号 = @编号)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@名称", System.Data.SqlDbType.VarChar, 150, "名称"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@规格", System.Data.SqlDbType.VarChar, 100, "规格"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@整量单位", System.Data.SqlDbType.VarChar, 50, "整量单位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@散量单位", System.Data.SqlDbType.VarChar, 50, "散量单位"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "入库单价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "出库单价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@批发价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "批发价", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@整散比", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "整散比", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@分类", System.Data.SqlDbType.VarChar, 100, "分类"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用归类", System.Data.SqlDbType.VarChar, 100, "费用归类"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@拼音码", System.Data.SqlDbType.VarChar, 50, "拼音码"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@效期", System.Data.SqlDbType.Int, 4, "效期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@上限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "上限", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@下限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "下限", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 药品资料 SET 编号 = @编号, 名称 = @名称, 规格 = @规格, 整量单位 = @整量单位, 散量单位 = @散量单位, 入库单价 = @入库单价, 出库单价 = @出库单价, 批发价 = @批发价, 整散比 = @整散比, 分类 = @分类, 费用归类 = @费用归类, 拼音码 = @拼音码, 效期 = @效期, 上限 = @上限, 下限 = @下限 WHERE (编号 = @Original_编号) AND (上限 = @Original_上限 OR @Original_上限 IS NULL AND 上限 IS NULL) AND (下限 = @Original_下限 OR @Original_下限 IS NULL AND 下限 IS NULL) AND (入库单价 = @Original_入库单价 OR @Original_入库单价 IS NULL AND 入库单价 IS NULL) AND (出库单价 = @Original_出库单价 OR @Original_出库单价 IS NULL AND 出库单价 IS NULL) AND (分类 = @Original_分类 OR @Original_分类 IS NULL AND 分类 IS NULL) AND (名称 = @Original_名称 OR @Original_名称 IS NULL AND 名称 IS NULL) AND (批发价 = @Original_批发价 OR @Original_批发价 IS NULL AND 批发价 IS NULL) AND (拼音码 = @Original_拼音码 OR @Original_拼音码 IS NULL AND 拼音码 IS NULL) AND (效期 = @Original_效期 OR @Original_效期 IS NULL AND 效期 IS NULL) AND (散量单位 = @Original_散量单位 OR @Original_散量单位 IS NULL AND 散量单位 IS NULL) AND (整散比 = @Original_整散比 OR @Original_整散比 IS NULL AND 整散比 IS NULL) AND (整量单位 = @Original_整量单位 OR @Original_整量单位 IS NULL AND 整量单位 IS NULL) AND (规格 = @Original_规格 OR @Original_规格 IS NULL AND 规格 IS NULL) AND (费用归类 = @Original_费用归类 OR @Original_费用归类 IS NULL AND 费用归类 IS NULL); SELECT 编号, 名称, 规格, 整量单位, 散量单位, 入库单价, 出库单价, 批发价, 整散比, 分类, 费用归类, 拼音码, 效期, 上限, 下限 FROM 药品资料 WHERE (编号 = @编号)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@编号", System.Data.SqlDbType.VarChar, 20, "编号"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@名称", System.Data.SqlDbType.VarChar, 150, "名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@规格", System.Data.SqlDbType.VarChar, 100, "规格"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@整量单位", System.Data.SqlDbType.VarChar, 50, "整量单位"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@散量单位", System.Data.SqlDbType.VarChar, 50, "散量单位"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@入库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "入库单价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@出库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "出库单价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@批发价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "批发价", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@整散比", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "整散比", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@分类", System.Data.SqlDbType.VarChar, 100, "分类"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@费用归类", System.Data.SqlDbType.VarChar, 100, "费用归类"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@拼音码", System.Data.SqlDbType.VarChar, 50, "拼音码"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@效期", System.Data.SqlDbType.Int, 4, "效期"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@上限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "上限", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@下限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "下限", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_上限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "上限", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_下限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "下限", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "入库单价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "出库单价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "分类", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_名称", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_批发价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "批发价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_拼音码", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "拼音码", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_效期", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "效期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_散量单位", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "散量单位", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_整散比", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "整散比", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_整量单位", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "整量单位", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_规格", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "规格", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用归类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "费用归类", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 药品资料 WHERE (编号 = @Original_编号) AND (上限 = @Original_上限 OR @Original_上限 IS NULL AND 上限 IS NULL) AND (下限 = @Original_下限 OR @Original_下限 IS NULL AND 下限 IS NULL) AND (入库单价 = @Original_入库单价 OR @Original_入库单价 IS NULL AND 入库单价 IS NULL) AND (出库单价 = @Original_出库单价 OR @Original_出库单价 IS NULL AND 出库单价 IS NULL) AND (分类 = @Original_分类 OR @Original_分类 IS NULL AND 分类 IS NULL) AND (名称 = @Original_名称 OR @Original_名称 IS NULL AND 名称 IS NULL) AND (批发价 = @Original_批发价 OR @Original_批发价 IS NULL AND 批发价 IS NULL) AND (拼音码 = @Original_拼音码 OR @Original_拼音码 IS NULL AND 拼音码 IS NULL) AND (效期 = @Original_效期 OR @Original_效期 IS NULL AND 效期 IS NULL) AND (散量单位 = @Original_散量单位 OR @Original_散量单位 IS NULL AND 散量单位 IS NULL) AND (整散比 = @Original_整散比 OR @Original_整散比 IS NULL AND 整散比 IS NULL) AND (整量单位 = @Original_整量单位 OR @Original_整量单位 IS NULL AND 整量单位 IS NULL) AND (规格 = @Original_规格 OR @Original_规格 IS NULL AND 规格 IS NULL) AND (费用归类 = @Original_费用归类 OR @Original_费用归类 IS NULL AND 费用归类 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_编号", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "编号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_上限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "上限", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_下限", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "下限", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_入库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "入库单价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_出库单价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "出库单价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_分类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "分类", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_名称", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "名称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_批发价", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "批发价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_拼音码", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "拼音码", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_效期", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "效期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_散量单位", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "散量单位", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_整散比", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "整散比", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_整量单位", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "整量单位", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_规格", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "规格", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_费用归类", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "费用归类", System.Data.DataRowVersion.Original, null));
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(328, 384);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 70;
			this.label15.Text = "拼音码";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(640, 384);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 16);
			this.label18.TabIndex = 71;
			this.label18.Text = "下限";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// MedInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(888, 472);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cmb1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt4);
			this.Controls.Add(this.txt5);
			this.Controls.Add(this.txt6);
			this.Controls.Add(this.txt7);
			this.Controls.Add(this.txt8);
			this.Controls.Add(this.txt9);
			this.Controls.Add(this.txt10);
			this.Controls.Add(this.txt11);
			this.Controls.Add(this.txt12);
			this.Controls.Add(this.txt15);
			this.Controls.Add(this.txt16);
			this.Controls.Add(this.txt14);
			this.Controls.Add(this.txt13);
			this.Controls.Add(this.txt17);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Name = "MedInfo";
			this.Text = "【药品信息】";
			this.Load += new System.EventHandler(this.MedInfo_Load);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.txt3, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.txt1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.txt2, 0);
			this.Controls.SetChildIndex(this.btnSearch, 0);
			this.Controls.SetChildIndex(this.dataGrid1, 0);
			this.Controls.SetChildIndex(this.label14, 0);
			this.Controls.SetChildIndex(this.label13, 0);
			this.Controls.SetChildIndex(this.label10, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.label16, 0);
			this.Controls.SetChildIndex(this.label17, 0);
			this.Controls.SetChildIndex(this.label12, 0);
			this.Controls.SetChildIndex(this.label11, 0);
			this.Controls.SetChildIndex(this.label9, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.txt17, 0);
			this.Controls.SetChildIndex(this.txt13, 0);
			this.Controls.SetChildIndex(this.txt14, 0);
			this.Controls.SetChildIndex(this.txt16, 0);
			this.Controls.SetChildIndex(this.txt15, 0);
			this.Controls.SetChildIndex(this.txt12, 0);
			this.Controls.SetChildIndex(this.txt11, 0);
			this.Controls.SetChildIndex(this.txt10, 0);
			this.Controls.SetChildIndex(this.txt9, 0);
			this.Controls.SetChildIndex(this.txt8, 0);
			this.Controls.SetChildIndex(this.txt7, 0);
			this.Controls.SetChildIndex(this.txt6, 0);
			this.Controls.SetChildIndex(this.txt5, 0);
			this.Controls.SetChildIndex(this.txt4, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.cmb1, 0);
			this.Controls.SetChildIndex(this.label15, 0);
			this.Controls.SetChildIndex(this.label18, 0);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void MedInfo_Load(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="%%";
			da1.SelectCommand.Parameters[1].Value="%%";
			da1.SelectCommand.Parameters[2].Value="%%";
			da1.Fill(dataSet11);
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"药品资料"];
			base.dataSet11=this.dataSet11;
            cmb1.Items.Clear();
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select distinct 名称 from 药品分类";
			SqlDataReader dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				cmb1.Items.Add(dr.GetValue(0).ToString().Trim());
			}			
		
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
			dataSet11.药品资料.Clear();
			da1.Fill(dataSet11);
			base.dataSet11=this.dataSet11;
		}

	
		protected override bool CheckNotNull()
		{
			if(txt4.Text.Trim()=="")
			{
				MessageBox.Show("药品编号不能为空，请输入编号","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
			if(txt5.Text.Trim()=="")
			{
				MessageBox.Show("药品名称不能为空，请输入名称","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select * from 药品资料 where 编号='"+txt4.Text+"'";
			SqlDataReader dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				MessageBox.Show("药品编号已经存在","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return(false);
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
			txt10.ReadOnly=!blnEdit;
			txt11.ReadOnly=!blnEdit;
			txt12.ReadOnly=!blnEdit;
			txt13.ReadOnly=!blnEdit;
			txt14.ReadOnly=!blnEdit;
			txt15.ReadOnly=!blnEdit;
			txt16.ReadOnly=!blnEdit;
			txt17.ReadOnly=!blnEdit;
			cmb1.Enabled=blnEdit;
		}
		
	}
}

