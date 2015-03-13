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
			// �õ����� Windows ���������������ġ�
			InitializeComponent();

			// TODO: �� InitializeComponent ���ú�����κγ�ʼ��
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region ��������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			this.label1.Text = "ҩƷ����";
			// 
			// txt1
			// 
			this.txt1.Name = "txt1";
			// 
			// label2
			// 
			this.label2.Name = "label2";
			this.label2.Text = "ƴ����";
			// 
			// txt3
			// 
			this.txt3.Name = "txt3";
			// 
			// label3
			// 
			this.label3.Name = "label3";
			this.label3.Text = "ҩƷ���";
			// 
			// btnSearch
			// 
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "ҩƷ����";
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
																						  new System.Data.Common.DataTableMapping("Table", "ҩƷ����", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("���", "���"),
																																																  new System.Data.Common.DataColumnMapping("����", "����"),
																																																  new System.Data.Common.DataColumnMapping("���", "���"),
																																																  new System.Data.Common.DataColumnMapping("������λ", "������λ"),
																																																  new System.Data.Common.DataColumnMapping("ɢ����λ", "ɢ����λ"),
																																																  new System.Data.Common.DataColumnMapping("��ⵥ��", "��ⵥ��"),
																																																  new System.Data.Common.DataColumnMapping("���ⵥ��", "���ⵥ��"),
																																																  new System.Data.Common.DataColumnMapping("������", "������"),
																																																  new System.Data.Common.DataColumnMapping("��ɢ��", "��ɢ��"),
																																																  new System.Data.Common.DataColumnMapping("����", "����"),
																																																  new System.Data.Common.DataColumnMapping("���ù���", "���ù���"),
																																																  new System.Data.Common.DataColumnMapping("ƴ����", "ƴ����"),
																																																  new System.Data.Common.DataColumnMapping("Ч��", "Ч��"),
																																																  new System.Data.Common.DataColumnMapping("����", "����"),
																																																  new System.Data.Common.DataColumnMapping("����", "����")})});
			this.da1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// cmb1
			// 
			this.cmb1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.����"));
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
			this.label4.Text = "���";
			// 
			// txt4
			// 
			this.txt4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.���"));
			this.txt4.Location = new System.Drawing.Point(24, 344);
			this.txt4.Name = "txt4";
			this.txt4.ReadOnly = true;
			this.txt4.Size = new System.Drawing.Size(64, 21);
			this.txt4.TabIndex = 59;
			this.txt4.Text = "";
			// 
			// txt5
			// 
			this.txt5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.����"));
			this.txt5.Location = new System.Drawing.Point(104, 344);
			this.txt5.Name = "txt5";
			this.txt5.ReadOnly = true;
			this.txt5.Size = new System.Drawing.Size(152, 21);
			this.txt5.TabIndex = 58;
			this.txt5.Text = "";
			// 
			// txt6
			// 
			this.txt6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.���"));
			this.txt6.Location = new System.Drawing.Point(272, 344);
			this.txt6.Name = "txt6";
			this.txt6.ReadOnly = true;
			this.txt6.Size = new System.Drawing.Size(48, 21);
			this.txt6.TabIndex = 57;
			this.txt6.Text = "";
			// 
			// txt7
			// 
			this.txt7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.������λ"));
			this.txt7.Location = new System.Drawing.Point(336, 344);
			this.txt7.Name = "txt7";
			this.txt7.ReadOnly = true;
			this.txt7.Size = new System.Drawing.Size(48, 21);
			this.txt7.TabIndex = 60;
			this.txt7.Text = "";
			// 
			// txt8
			// 
			this.txt8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.ɢ����λ"));
			this.txt8.Location = new System.Drawing.Point(400, 344);
			this.txt8.Name = "txt8";
			this.txt8.ReadOnly = true;
			this.txt8.Size = new System.Drawing.Size(48, 21);
			this.txt8.TabIndex = 68;
			this.txt8.Text = "";
			// 
			// txt9
			// 
			this.txt9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.��ⵥ��"));
			this.txt9.Location = new System.Drawing.Point(464, 344);
			this.txt9.Name = "txt9";
			this.txt9.ReadOnly = true;
			this.txt9.Size = new System.Drawing.Size(64, 21);
			this.txt9.TabIndex = 65;
			this.txt9.Text = "";
			// 
			// txt10
			// 
			this.txt10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.���ⵥ��"));
			this.txt10.Location = new System.Drawing.Point(544, 344);
			this.txt10.Name = "txt10";
			this.txt10.ReadOnly = true;
			this.txt10.Size = new System.Drawing.Size(72, 21);
			this.txt10.TabIndex = 62;
			this.txt10.Text = "";
			// 
			// txt11
			// 
			this.txt11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.������"));
			this.txt11.Location = new System.Drawing.Point(632, 344);
			this.txt11.Name = "txt11";
			this.txt11.ReadOnly = true;
			this.txt11.Size = new System.Drawing.Size(72, 21);
			this.txt11.TabIndex = 55;
			this.txt11.Text = "";
			// 
			// txt12
			// 
			this.txt12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.��ɢ��"));
			this.txt12.Location = new System.Drawing.Point(24, 408);
			this.txt12.Name = "txt12";
			this.txt12.ReadOnly = true;
			this.txt12.Size = new System.Drawing.Size(72, 21);
			this.txt12.TabIndex = 56;
			this.txt12.Text = "";
			// 
			// txt15
			// 
			this.txt15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.Ч��"));
			this.txt15.Location = new System.Drawing.Point(432, 408);
			this.txt15.Name = "txt15";
			this.txt15.ReadOnly = true;
			this.txt15.Size = new System.Drawing.Size(64, 21);
			this.txt15.TabIndex = 66;
			this.txt15.Text = "";
			// 
			// txt16
			// 
			this.txt16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.����"));
			this.txt16.Location = new System.Drawing.Point(520, 408);
			this.txt16.Name = "txt16";
			this.txt16.ReadOnly = true;
			this.txt16.Size = new System.Drawing.Size(80, 21);
			this.txt16.TabIndex = 61;
			this.txt16.Text = "";
			// 
			// txt14
			// 
			this.txt14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.ƴ����"));
			this.txt14.Location = new System.Drawing.Point(328, 408);
			this.txt14.Name = "txt14";
			this.txt14.ReadOnly = true;
			this.txt14.Size = new System.Drawing.Size(80, 21);
			this.txt14.TabIndex = 64;
			this.txt14.Text = "";
			// 
			// txt13
			// 
			this.txt13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.���ù���"));
			this.txt13.Location = new System.Drawing.Point(248, 408);
			this.txt13.Name = "txt13";
			this.txt13.ReadOnly = true;
			this.txt13.Size = new System.Drawing.Size(64, 21);
			this.txt13.TabIndex = 67;
			this.txt13.Text = "";
			// 
			// txt17
			// 
			this.txt17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSet11, "ҩƷ����.����"));
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
			this.label5.Text = "����";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(272, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 16);
			this.label6.TabIndex = 46;
			this.label6.Text = "���";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(336, 328);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 16);
			this.label9.TabIndex = 40;
			this.label9.Text = "������λ";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(464, 328);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 16);
			this.label11.TabIndex = 43;
			this.label11.Text = "��ⵥ��";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(400, 328);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 16);
			this.label12.TabIndex = 51;
			this.label12.Text = "ɢ����λ";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(544, 328);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(88, 16);
			this.label17.TabIndex = 53;
			this.label17.Text = "���ⵥ��";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(632, 328);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 16);
			this.label16.TabIndex = 47;
			this.label16.Text = "������";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(24, 392);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 16);
			this.label7.TabIndex = 48;
			this.label7.Text = "��ɢ��";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(120, 392);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 16);
			this.label8.TabIndex = 49;
			this.label8.Text = "����";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(536, 392);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 16);
			this.label10.TabIndex = 42;
			this.label10.Text = "����";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(440, 392);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 16);
			this.label13.TabIndex = 54;
			this.label13.Text = "��Ч��";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(256, 392);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 16);
			this.label14.TabIndex = 41;
			this.label14.Text = "���ù���";
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT ���, ����, ���, ������λ, ɢ����λ, ��ⵥ��, ���ⵥ��, ������, ��ɢ��, ����, ���ù���, ƴ����, Ч��, ����, ���� FR" +
				"OM ҩƷ���� WHERE (ƴ���� LIKE @Param4 OR ƴ���� IS NULL) AND (���� LIKE @Param5) AND (��� LI" +
				"KE @Param6)";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.VarChar, 50, "ƴ����"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param5", System.Data.SqlDbType.VarChar, 150, "����"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param6", System.Data.SqlDbType.VarChar, 20, "���"));
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = @"INSERT INTO ҩƷ����(���, ����, ���, ������λ, ɢ����λ, ��ⵥ��, ���ⵥ��, ������, ��ɢ��, ����, ���ù���, ƴ����, Ч��, ����, ����) VALUES (@���, @����, @���, @������λ, @ɢ����λ, @��ⵥ��, @���ⵥ��, @������, @��ɢ��, @����, @���ù���, @ƴ����, @Ч��, @����, @����); SELECT ���, ����, ���, ������λ, ɢ����λ, ��ⵥ��, ���ⵥ��, ������, ��ɢ��, ����, ���ù���, ƴ����, Ч��, ����, ���� FROM ҩƷ���� WHERE (��� = @���)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 20, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 150, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 100, "���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������λ", System.Data.SqlDbType.VarChar, 50, "������λ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ɢ����λ", System.Data.SqlDbType.VarChar, 50, "ɢ����λ"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ⵥ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "���ⵥ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "������", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɢ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ɢ��", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 100, "����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ù���", System.Data.SqlDbType.VarChar, 100, "���ù���"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ƴ����", System.Data.SqlDbType.VarChar, 50, "ƴ����"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ч��", System.Data.SqlDbType.Int, 4, "Ч��"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Current, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE ҩƷ���� SET ��� = @���, ���� = @����, ��� = @���, ������λ = @������λ, ɢ����λ = @ɢ����λ, ��ⵥ�� = @��ⵥ��, ���ⵥ�� = @���ⵥ��, ������ = @������, ��ɢ�� = @��ɢ��, ���� = @����, ���ù��� = @���ù���, ƴ���� = @ƴ����, Ч�� = @Ч��, ���� = @����, ���� = @���� WHERE (��� = @Original_���) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (��ⵥ�� = @Original_��ⵥ�� OR @Original_��ⵥ�� IS NULL AND ��ⵥ�� IS NULL) AND (���ⵥ�� = @Original_���ⵥ�� OR @Original_���ⵥ�� IS NULL AND ���ⵥ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (ƴ���� = @Original_ƴ���� OR @Original_ƴ���� IS NULL AND ƴ���� IS NULL) AND (Ч�� = @Original_Ч�� OR @Original_Ч�� IS NULL AND Ч�� IS NULL) AND (ɢ����λ = @Original_ɢ����λ OR @Original_ɢ����λ IS NULL AND ɢ����λ IS NULL) AND (��ɢ�� = @Original_��ɢ�� OR @Original_��ɢ�� IS NULL AND ��ɢ�� IS NULL) AND (������λ = @Original_������λ OR @Original_������λ IS NULL AND ������λ IS NULL) AND (��� = @Original_��� OR @Original_��� IS NULL AND ��� IS NULL) AND (���ù��� = @Original_���ù��� OR @Original_���ù��� IS NULL AND ���ù��� IS NULL); SELECT ���, ����, ���, ������λ, ɢ����λ, ��ⵥ��, ���ⵥ��, ������, ��ɢ��, ����, ���ù���, ƴ����, Ч��, ����, ���� FROM ҩƷ���� WHERE (��� = @���)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 20, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 150, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���", System.Data.SqlDbType.VarChar, 100, "���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������λ", System.Data.SqlDbType.VarChar, 50, "������λ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ɢ����λ", System.Data.SqlDbType.VarChar, 50, "ɢ����λ"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ⵥ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "���ⵥ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "������", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@��ɢ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ɢ��", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.VarChar, 100, "����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@���ù���", System.Data.SqlDbType.VarChar, 100, "���ù���"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ƴ����", System.Data.SqlDbType.VarChar, 50, "ƴ����"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Ч��", System.Data.SqlDbType.Int, 4, "Ч��"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ⵥ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "���ⵥ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ƴ����", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ƴ����", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ч��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ч��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ɢ����λ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ɢ����λ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ɢ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ɢ��", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������λ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������λ", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ù���", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ù���", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM ҩƷ���� WHERE (��� = @Original_���) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (��ⵥ�� = @Original_��ⵥ�� OR @Original_��ⵥ�� IS NULL AND ��ⵥ�� IS NULL) AND (���ⵥ�� = @Original_���ⵥ�� OR @Original_���ⵥ�� IS NULL AND ���ⵥ�� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (���� = @Original_���� OR @Original_���� IS NULL AND ���� IS NULL) AND (������ = @Original_������ OR @Original_������ IS NULL AND ������ IS NULL) AND (ƴ���� = @Original_ƴ���� OR @Original_ƴ���� IS NULL AND ƴ���� IS NULL) AND (Ч�� = @Original_Ч�� OR @Original_Ч�� IS NULL AND Ч�� IS NULL) AND (ɢ����λ = @Original_ɢ����λ OR @Original_ɢ����λ IS NULL AND ɢ����λ IS NULL) AND (��ɢ�� = @Original_��ɢ�� OR @Original_��ɢ�� IS NULL AND ��ɢ�� IS NULL) AND (������λ = @Original_������λ OR @Original_������λ IS NULL AND ������λ IS NULL) AND (��� = @Original_��� OR @Original_��� IS NULL AND ��� IS NULL) AND (���ù��� = @Original_���ù��� OR @Original_���ù��� IS NULL AND ���ù��� IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ⵥ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ⵥ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "���ⵥ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_����", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "������", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ƴ����", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ƴ����", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_Ч��", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "Ч��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_ɢ����λ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "ɢ����λ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_��ɢ��", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, false, ((System.Byte)(12)), ((System.Byte)(2)), "��ɢ��", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_������λ", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "������λ", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_���ù���", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "���ù���", System.Data.DataRowVersion.Original, null));
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(328, 384);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 16);
			this.label15.TabIndex = 70;
			this.label15.Text = "ƴ����";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(640, 384);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 16);
			this.label18.TabIndex = 71;
			this.label18.Text = "����";
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
			this.Text = "��ҩƷ��Ϣ��";
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
			this.cmOrders=(CurrencyManager) BindingContext[dataSet11,"ҩƷ����"];
			base.dataSet11=this.dataSet11;
            cmb1.Items.Clear();
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select distinct ���� from ҩƷ����";
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
			dataSet11.ҩƷ����.Clear();
			da1.Fill(dataSet11);
			base.dataSet11=this.dataSet11;
		}

	
		protected override bool CheckNotNull()
		{
			if(txt4.Text.Trim()=="")
			{
				MessageBox.Show("ҩƷ��Ų���Ϊ�գ���������","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
			if(txt5.Text.Trim()=="")
			{
				MessageBox.Show("ҩƷ���Ʋ���Ϊ�գ�����������","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return(false);
			}
            string strConn = SqlHelper.constr;
			SqlConnection cn=new SqlConnection(strConn);
			cn.Open();
			SqlCommand cmd=cn.CreateCommand();
			cmd.CommandText="select * from ҩƷ���� where ���='"+txt4.Text+"'";
			SqlDataReader dr=cmd.ExecuteReader();
			while(dr.Read())
			{
				MessageBox.Show("ҩƷ����Ѿ�����","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

