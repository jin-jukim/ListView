using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        string strName = ""; // 나이, 이름, 직업 저장 
        string strAge = "";
        string strWork = "";// 초기화;NULL EXCEPTION을 줄이기 위함

        public Form1()
        {
            InitializeComponent();
        }

        bool TextCheck()
        {
            if (this.txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtAge.Text == "")
            {
                MessageBox.Show("나이를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            if (this.txtWork.Text == "")
            {
                MessageBox.Show("직업을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtName.Focus();
                return false;
            }
            return true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                strName = this.txtName.Text;
                strAge = this.txtAge.Text;
                strWork = this.txtWork.Text;
                ListViewItem lvi =          //리스트뷰에 들어갈 항목 생성
                    new ListViewItem(
                        new string[] { strName, strAge, strWork }
                    );
                this.lvView.Items.Add(lvi);
                clearTextBox();
                this.txtName.Focus();

            }
        }

        private void clearTextBox()
        {
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtWork.Text = "";
        }
    }
}
