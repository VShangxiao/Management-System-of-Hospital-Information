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
	/// ParentForm ��ժҪ˵����
	/// </summary>
	public class ParentForm : System.Windows.Forms.Form
	{
		protected System.Windows.Forms.ToolBar toolBar1;
		protected System.Windows.Forms.ToolBarButton tBtnFirst;
		protected System.Windows.Forms.ToolBarButton tBtnPre;
		protected System.Windows.Forms.ToolBarButton tBtnNext;
		protected System.Windows.Forms.ToolBarButton tBtnLast;
		protected System.Windows.Forms.ToolBarButton tBtnNew;
		protected System.Windows.Forms.ToolBarButton tBtnEdit;
		protected System.Windows.Forms.ToolBarButton tBtnDelete;
		protected System.Windows.Forms.ToolBarButton tBtnSubmit;
		protected System.Windows.Forms.ToolBarButton tBtnCancel;
		protected System.Windows.Forms.ToolBarButton tBtnQuit;
		protected System.Windows.Forms.TextBox txt2;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.TextBox txt1;
		protected System.Windows.Forms.Label label2;
		protected System.Windows.Forms.TextBox txt3;
		protected System.Windows.Forms.Label label3;
		protected System.Windows.Forms.Button btnSearch;
		protected System.Windows.Forms.DataGrid dataGrid1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter da1;
		protected CurrencyManager cmOrders;//�������ݵ�������
		protected DataSet dataSet11;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		public ParentForm()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ParentForm));
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.tBtnFirst = new System.Windows.Forms.ToolBarButton();
			this.tBtnPre = new System.Windows.Forms.ToolBarButton();
			this.tBtnNext = new System.Windows.Forms.ToolBarButton();
			this.tBtnLast = new System.Windows.Forms.ToolBarButton();
			this.tBtnNew = new System.Windows.Forms.ToolBarButton();
			this.tBtnEdit = new System.Windows.Forms.ToolBarButton();
			this.tBtnDelete = new System.Windows.Forms.ToolBarButton();
			this.tBtnSubmit = new System.Windows.Forms.ToolBarButton();
			this.tBtnCancel = new System.Windows.Forms.ToolBarButton();
			this.tBtnQuit = new System.Windows.Forms.ToolBarButton();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.da1 = new System.Data.SqlClient.SqlDataAdapter();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																						this.tBtnFirst,
																						this.tBtnPre,
																						this.tBtnNext,
																						this.tBtnLast,
																						this.tBtnNew,
																						this.tBtnEdit,
																						this.tBtnDelete,
																						this.tBtnSubmit,
																						this.tBtnCancel,
																						this.tBtnQuit});
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(888, 41);
			this.toolBar1.TabIndex = 30;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// tBtnFirst
			// 
			this.tBtnFirst.ImageIndex = 0;
			this.tBtnFirst.Text = "�׼�¼";
			this.tBtnFirst.ToolTipText = "�׼�¼";
			// 
			// tBtnPre
			// 
			this.tBtnPre.ImageIndex = 1;
			this.tBtnPre.Text = "��һ��¼";
			this.tBtnPre.ToolTipText = "��һ��¼";
			// 
			// tBtnNext
			// 
			this.tBtnNext.ImageIndex = 2;
			this.tBtnNext.Text = "��һ��¼";
			this.tBtnNext.ToolTipText = "��һ��¼";
			// 
			// tBtnLast
			// 
			this.tBtnLast.ImageIndex = 3;
			this.tBtnLast.Text = "β��¼";
			this.tBtnLast.ToolTipText = "β��¼";
			// 
			// tBtnNew
			// 
			this.tBtnNew.ImageIndex = 4;
			this.tBtnNew.Text = "����";
			this.tBtnNew.ToolTipText = "����";
			// 
			// tBtnEdit
			// 
			this.tBtnEdit.ImageIndex = 5;
			this.tBtnEdit.Text = "�޸�";
			this.tBtnEdit.ToolTipText = "�޸�";
			// 
			// tBtnDelete
			// 
			this.tBtnDelete.ImageIndex = 6;
			this.tBtnDelete.Text = "ɾ��";
			this.tBtnDelete.ToolTipText = "ɾ��";
			// 
			// tBtnSubmit
			// 
			this.tBtnSubmit.ImageIndex = 7;
			this.tBtnSubmit.Text = "�ύ";
			this.tBtnSubmit.ToolTipText = "�ύ";
			// 
			// tBtnCancel
			// 
			this.tBtnCancel.ImageIndex = 8;
			this.tBtnCancel.Text = "ȡ��";
			this.tBtnCancel.ToolTipText = "ȡ��";
			// 
			// tBtnQuit
			// 
			this.tBtnQuit.ImageIndex = 9;
			this.tBtnQuit.Text = "�˳�";
			this.tBtnQuit.ToolTipText = "�˳�";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(376, 56);
			this.txt2.Name = "txt2";
			this.txt2.TabIndex = 36;
			this.txt2.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(312, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 34;
			this.label1.Text = "��ѯ����2";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(176, 56);
			this.txt1.Name = "txt1";
			this.txt1.TabIndex = 37;
			this.txt1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "��ѯ����1";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(576, 56);
			this.txt3.Name = "txt3";
			this.txt3.TabIndex = 35;
			this.txt3.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(520, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 33;
			this.label3.Text = "��ѯ����3";
			// 
			// btnSearch
			// 
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(24, 56);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.TabIndex = 38;
			this.btnSearch.Text = "����";
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(16, 88);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.ReadOnly = true;
			this.dataGrid1.Size = new System.Drawing.Size(664, 224);
			this.dataGrid1.TabIndex = 39;
			// 
			// da1
			// 
			this.da1.DeleteCommand = this.sqlDeleteCommand1;
			this.da1.InsertCommand = this.sqlInsertCommand1;
			this.da1.SelectCommand = this.sqlSelectCommand1;
			this.da1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ParentForm
			// 
			this.AcceptButton = this.btnSearch;
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(888, 408);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.toolBar1);
			this.Name = "ParentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ParentForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	
		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button.ToolTipText == "�׼�¼")
			{
				this.dataGrid1.UnSelect(cmOrders.Position); 
				cmOrders.Position = 0;
				this.dataGrid1.Select(cmOrders.Position); 
				this.dataGrid1.CurrentRowIndex = cmOrders.Position; 
				return;
				
			}
			if (e.Button.ToolTipText == "��һ��¼")
			{
				if (cmOrders.Position >= 0)
				{
					this.dataGrid1.UnSelect(cmOrders.Position); 
					cmOrders.Position--;
					this.dataGrid1.Select(cmOrders.Position);      
					this.dataGrid1.CurrentRowIndex = cmOrders.Position; 
				}
				return;
			}
			if (e.Button.ToolTipText == "��һ��¼")
			{
				if (cmOrders.Position <= cmOrders.Count-1)
				{
					this.dataGrid1.UnSelect(cmOrders.Position); 
					cmOrders.Position++;
					this.dataGrid1.Select(cmOrders.Position);       
					this.dataGrid1.CurrentRowIndex = cmOrders.Position; 
				}
				return;
			}
			if (e.Button.ToolTipText == "β��¼")
			{
				this.dataGrid1.UnSelect(cmOrders.Position); 
				cmOrders.Position = cmOrders.Count-1;
				this.dataGrid1.Select(cmOrders.Position);       
				this.dataGrid1.CurrentRowIndex = cmOrders.Position; 
				return;
			}
			
			if(e.Button.ToolTipText=="����")
			{				
				cmOrders.AddNew();
				SetDefaultValue();		
				SetModifyMode(true);
			}
			if(e.Button.ToolTipText=="�޸�")
			{
				SetModifyMode(true);
			}
			if(e.Button.ToolTipText=="ɾ��")
			{
				
				DialogResult result=MessageBox.Show("ȷ��ɾ����","ɾ������",MessageBoxButtons.OKCancel);
				if(result==DialogResult.OK)
					if(cmOrders.Count>0)
					{
						cmOrders.RemoveAt(cmOrders.Position);						
						da1.Update(dataSet11);
					}
					else
						MessageBox.Show("����Ϊ�գ����޿�ɾ������","��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			if(e.Button.ToolTipText=="�ύ")
			{
				bool canSubmit;
				canSubmit=this.CheckNotNull();
				if(canSubmit==true)
				{
					cmOrders.EndCurrentEdit();
					if(dataSet11.GetChanges()!=null)
					{
						try
						{
							da1.Update(dataSet11);
							SetModifyMode(false);
						}
						catch(Exception express)
						{
							MessageBox.Show(express.ToString(),"��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
							dataSet11.RejectChanges();
						}
					}
				}
				return;
			}

			if (e.Button.ToolTipText == "ȡ��")
			{
				try
				{
					cmOrders.CancelCurrentEdit(); 
					SetModifyMode(false);
				}
				catch(Exception express)
				{
					MessageBox.Show(express.ToString(),"��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
				return;
			}

			if(e.Button.ToolTipText=="�˳�")
			{
				this.Close();
			}
		}
		protected virtual void SetModifyMode(bool blnEdit)
		{
			btnSearch.Enabled=!blnEdit;
		}
		
		protected virtual void SetDefaultValue()
		{
			return;
		}
		
		protected virtual bool CheckNotNull()
		{
			return(true);
		}

	}
}
