using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
namespace HMS
{
	/// <summary>
	/// Systemshow ��ժҪ˵����
	/// </summary>
	public class Systemshow : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbimage;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label lbshow1;
		private System.Windows.Forms.Label lbshow2;
		private System.Windows.Forms.Label lbshow3;
		private System.Windows.Forms.Label lbshow4;
		private System.ComponentModel.IContainer components;

		public Systemshow()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Systemshow));
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbshow1 = new System.Windows.Forms.Label();
			this.lbimage = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lbshow2 = new System.Windows.Forms.Label();
			this.lbshow3 = new System.Windows.Forms.Label();
			this.lbshow4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(32, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "ҽԺ����ϵͳ";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(160, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "��Ϣ����";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(296, 32);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "�������";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton5);
			this.groupBox1.Controls.Add(this.radioButton4);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(808, 64);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ѡ��ϵͳ����";
			// 
			// radioButton5
			// 
			this.radioButton5.Location = new System.Drawing.Point(600, 32);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 4;
			this.radioButton5.Text = "����";
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Location = new System.Drawing.Point(440, 32);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 3;
			this.radioButton4.Text = "ͳ�Ʋ�ѯ";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbshow4);
			this.groupBox2.Controls.Add(this.lbshow3);
			this.groupBox2.Controls.Add(this.lbshow2);
			this.groupBox2.Controls.Add(this.lbshow1);
			this.groupBox2.Controls.Add(this.lbimage);
			this.groupBox2.Location = new System.Drawing.Point(16, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(808, 384);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "����˵��";
			// 
			// lbshow1
			// 
			this.lbshow1.Location = new System.Drawing.Point(64, 248);
			this.lbshow1.Name = "lbshow1";
			this.lbshow1.Size = new System.Drawing.Size(616, 24);
			this.lbshow1.TabIndex = 1;
			// 
			// lbimage
			// 
			this.lbimage.ImageList = this.imageList1;
			this.lbimage.Location = new System.Drawing.Point(112, 24);
			this.lbimage.Name = "lbimage";
			this.lbimage.Size = new System.Drawing.Size(504, 208);
			this.lbimage.TabIndex = 0;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(216, 216);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lbshow2
			// 
			this.lbshow2.Location = new System.Drawing.Point(64, 280);
			this.lbshow2.Name = "lbshow2";
			this.lbshow2.Size = new System.Drawing.Size(616, 24);
			this.lbshow2.TabIndex = 2;
			// 
			// lbshow3
			// 
			this.lbshow3.Location = new System.Drawing.Point(64, 312);
			this.lbshow3.Name = "lbshow3";
			this.lbshow3.Size = new System.Drawing.Size(616, 24);
			this.lbshow3.TabIndex = 3;
			// 
			// lbshow4
			// 
			this.lbshow4.Location = new System.Drawing.Point(64, 344);
			this.lbshow4.Name = "lbshow4";
			this.lbshow4.Size = new System.Drawing.Size(616, 24);
			this.lbshow4.TabIndex = 4;
			// 
			// Systemshow
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(840, 480);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Systemshow";
			this.Text = "Systemshow";
			this.Load += new System.EventHandler(this.Systemshow_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Systemshow_Load(object sender, System.EventArgs e)
		{
			lbshow1.Text="";
			lbshow2.Text="";
			lbshow3.Text="";
			lbshow4.Text="";
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			lbimage.ImageIndex=0;
			lbshow1.Text="��Ϣ�����������úͲ�ѯϵͳ������Ϣ";
			lbshow2.Text="�����������ҽԺ����Һš����ۡ��շѺͷ�ҩ�Ĺ����һϵ�в���";
			lbshow3.Text="ͳ�Ʋ�ѯ�����ڶԹҺ����Ϳ��Ĳ�ѯ";
			lbshow4.Text="��������������Ա�ṩ������Ϣ";
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			lbimage.ImageIndex=1;
			lbshow1.Text="ҩƷ��Ϣ�����ڲ�ѯҩƷ����Ϣ";
			lbshow2.Text="�շ���Ŀ�����ڲ�ѯ�շ���Ŀ����Ϣ";
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			lbimage.ImageIndex=2;
			lbshow1.Text="�ҺŹ���������ɲ��˹Һ�ʱ�Ǽ���Ϣ�Ĺ���";
			lbshow2.Text="���۹�������������ﲡ�˸��ִ����������������η��õļƼ۹���";
			lbshow3.Text="�շѹ�������������ﲡ�˸������η��õ���ȡ����";
			lbshow4.Text="ҩ����ҩ������ҩ��Ԥ�ȴ�ӡ��Ҫ������ҩƷ��ϸ������ҩƷ׼���ã�����ȡҩʱֱ�Ӹ�����";
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			lbimage.ImageIndex=3;
			lbshow1.Text="���ҹҺ���������ÿ�չҺ�����Ĳ�ѯ";
			lbshow2.Text="���ͳ�ƣ���ҩƷ�������ͳ�ƺͲ�ѯ����";
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			lbimage.ImageIndex=4;
			lbshow1.Text="ϵͳ˵�������µĲ�����Ա�ṩϵͳ�������̵���Ϣ";
			lbshow2.Text="����֧�֣�ϵͳ�İ汾��˵���Լ���ϵͳ��������ʱ��ϵ������Ա";
		}
		
	}
}
