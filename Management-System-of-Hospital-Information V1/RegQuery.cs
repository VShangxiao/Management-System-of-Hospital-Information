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
	/// RegQuery ��ժҪ˵����
	/// </summary>
	public class RegQuery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Data.SqlClient.SqlDataAdapter da1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private HMS.DataSet3 dataSet31;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RegQuery()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
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

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSearch = new System.Windows.Forms.Button();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.da1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.dataSet31 = new HMS.DataSet3();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(368, 88);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 12;
			this.btnSearch.Text = "����";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(208, 104);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 11;
			this.txt2.Text = "";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(208, 64);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 10;
			this.txt1.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGrid1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txt1);
			this.groupBox1.Controls.Add(this.txt2);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(888, 360);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "���ҹҺ�����ѯ";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "����Һ�";
			this.dataGrid1.DataSource = this.dataSet31;
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(104, 136);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(328, 168);
			this.dataGrid1.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(104, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 23);
			this.label3.TabIndex = 16;
			this.label3.Text = "ʱ���ʽ��\'2007-7-2\'";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(88, 104);
			this.label2.Name = "label2";
			this.label2.TabIndex = 15;
			this.label2.Text = "����ʱ��";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 72);
			this.label1.Name = "label1";
			this.label1.TabIndex = 14;
			this.label1.Text = "��ʼʱ��";
			// 
			// da1
			// 
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																						  new System.Data.Common.DataTableMapping("Table", "����Һ�", new System.Data.Common.DataColumnMapping[] {
																																																  new System.Data.Common.DataColumnMapping("�Һſ���", "�Һſ���"),
																																																  new System.Data.Common.DataColumnMapping("����", "����"),
																																																  new System.Data.Common.DataColumnMapping("�ҺŽ��", "�ҺŽ��")})});
			// 
			// sqlConnection1
			// 
            this.sqlConnection1.ConnectionString = SqlHelper.constr;
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT �Һſ���, COUNT(���) AS ����, SUM(�Һŷ���) AS �ҺŽ�� FROM ����Һ� WHERE (ʱ�� > @Param3) AN" +
				"D (ʱ�� < @Param4) GROUP BY �Һſ���";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param3", System.Data.SqlDbType.DateTime, 8, "ʱ��"));
			this.sqlSelectCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Param4", System.Data.SqlDbType.DateTime, 8, "ʱ��"));
			// 
			// dataSet31
			// 
			this.dataSet31.DataSetName = "DataSet3";
			this.dataSet31.Locale = new System.Globalization.CultureInfo("en-US");
			// 
			// RegQuery
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(912, 392);
			this.Controls.Add(this.groupBox1);
			this.Name = "RegQuery";
			this.Text = "RegQuery";
			this.Load += new System.EventHandler(this.RegQuery_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	

		private void RegQuery_Load(object sender, System.EventArgs e)
		{
			try
			{
				da1.SelectCommand.Parameters[0].Value="2000-7-2";
				da1.SelectCommand.Parameters[1].Value="2008-7-2";
				da1.Fill(dataSet31);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnSearch_Click(object sender, System.EventArgs e)
		{
			da1.SelectCommand.Parameters[0].Value="2000-7-2";
			da1.SelectCommand.Parameters[1].Value="2008-7-2";
			if(txt1.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[0].Value=txt1.Text;
			}
			if(txt2.Text.Trim()!="")
			{
				da1.SelectCommand.Parameters[1].Value=txt2.Text;
			}
			dataSet31.Clear();
			da1.Fill(dataSet31);	
		}
	}
}
