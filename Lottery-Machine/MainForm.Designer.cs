namespace Lottery_Machine
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.mint = new Sunny.UI.UITextBox();
            this.maxt = new Sunny.UI.UITextBox();
            this.dwst = new Sunny.UI.UITextBox();
            this.quat = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Don\'t want to see:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(180, 171);
            this.button2.MinimumSize = new System.Drawing.Size(1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Quit";
            this.button2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(13, 171);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(154, 29);
            this.uiButton1.TabIndex = 12;
            this.uiButton1.Text = "Generate";
            this.uiButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(13, 206);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(321, 29);
            this.uiButton2.TabIndex = 13;
            this.uiButton2.Text = "Generate and Speak";
            this.uiButton2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // mint
            // 
            this.mint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mint.FillColor = System.Drawing.Color.Black;
            this.mint.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mint.ForeColor = System.Drawing.Color.White;
            this.mint.Location = new System.Drawing.Point(94, 13);
            this.mint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mint.MinimumSize = new System.Drawing.Size(1, 16);
            this.mint.Name = "mint";
            this.mint.ShowText = false;
            this.mint.Size = new System.Drawing.Size(242, 29);
            this.mint.Style = Sunny.UI.UIStyle.Custom;
            this.mint.TabIndex = 14;
            this.mint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.mint.Watermark = "";
            this.mint.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // maxt
            // 
            this.maxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxt.FillColor = System.Drawing.Color.Black;
            this.maxt.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxt.ForeColor = System.Drawing.Color.White;
            this.maxt.Location = new System.Drawing.Point(94, 52);
            this.maxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maxt.MinimumSize = new System.Drawing.Size(1, 16);
            this.maxt.Name = "maxt";
            this.maxt.ShowText = false;
            this.maxt.Size = new System.Drawing.Size(242, 29);
            this.maxt.Style = Sunny.UI.UIStyle.Custom;
            this.maxt.TabIndex = 15;
            this.maxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.maxt.Watermark = "";
            this.maxt.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dwst
            // 
            this.dwst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dwst.FillColor = System.Drawing.Color.Black;
            this.dwst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dwst.ForeColor = System.Drawing.Color.White;
            this.dwst.Location = new System.Drawing.Point(140, 91);
            this.dwst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dwst.MinimumSize = new System.Drawing.Size(1, 16);
            this.dwst.Name = "dwst";
            this.dwst.ShowText = false;
            this.dwst.Size = new System.Drawing.Size(196, 29);
            this.dwst.Style = Sunny.UI.UIStyle.Custom;
            this.dwst.TabIndex = 15;
            this.dwst.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dwst.Watermark = "";
            this.dwst.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // quat
            // 
            this.quat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quat.FillColor = System.Drawing.Color.Black;
            this.quat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quat.ForeColor = System.Drawing.Color.White;
            this.quat.Location = new System.Drawing.Point(94, 130);
            this.quat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quat.MinimumSize = new System.Drawing.Size(1, 16);
            this.quat.Name = "quat";
            this.quat.ShowText = false;
            this.quat.Size = new System.Drawing.Size(242, 29);
            this.quat.Style = Sunny.UI.UIStyle.Custom;
            this.quat.TabIndex = 15;
            this.quat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.quat.Watermark = "";
            this.quat.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(346, 245);
            this.Controls.Add(this.quat);
            this.Controls.Add(this.dwst);
            this.Controls.Add(this.maxt);
            this.Controls.Add(this.mint);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lottery Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Sunny.UI.UIButton button2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UITextBox mint;
        private Sunny.UI.UITextBox maxt;
        private Sunny.UI.UITextBox dwst;
        private Sunny.UI.UITextBox quat;
    }
}

