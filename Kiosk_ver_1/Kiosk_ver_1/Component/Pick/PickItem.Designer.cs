namespace Kiosk_ver_1.Component.Pick
{
    partial class PickItem
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new Kiosk_ver_1.Component.RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.roundedPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.Empty;
            this.roundedPanel1.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.InnerBorderColor = System.Drawing.Color.Empty;
            this.roundedPanel1.Location = new System.Drawing.Point(0, 0);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(405, 29);
            this.roundedPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.lblTitle);
            this.flowLayoutPanel1.Controls.Add(this.btnDown);
            this.flowLayoutPanel1.Controls.Add(this.lblCount);
            this.flowLayoutPanel1.Controls.Add(this.btnUp);
            this.flowLayoutPanel1.Controls.Add(this.lblSumPrice);
            this.flowLayoutPanel1.Controls.Add(this.btnDel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 23);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(57, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "lblTitle";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(180, 3);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(20, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "<";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(206, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 26);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "lblCount";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(247, 3);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(20, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = ">";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.Location = new System.Drawing.Point(273, 0);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(84, 29);
            this.lblSumPrice.TabIndex = 5;
            this.lblSumPrice.Text = "lblSumPrice";
            this.lblSumPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(363, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(20, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "x";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // PickItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedPanel1);
            this.Name = "PickItem";
            this.Size = new System.Drawing.Size(405, 29);
            this.roundedPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Button btnDel;
    }
}
