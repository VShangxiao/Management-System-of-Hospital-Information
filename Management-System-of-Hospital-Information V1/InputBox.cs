using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HMS
{
	/// <summary>
	/// InputBox ��ժҪ˵����
	/// </summary>
	public class InputBox : System.Windows.Forms.Form
	{
		public string result="";//Ĭ��Ϊ��
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InputBox()
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(168, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(312, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(168, 56);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(320, 21);
			this.txt1.TabIndex = 4;
			this.txt1.Text = "";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(72, 56);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "ȷ��";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// InputBox
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(680, 120);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.btnOK);
			this.Name = "InputBox";
			this.Text = "InputBox";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			this.result=txt1.Text.Trim();
			this.Close();
		}
	}
}
