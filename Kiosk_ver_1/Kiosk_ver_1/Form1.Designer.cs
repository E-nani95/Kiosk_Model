namespace Kiosk_ver_1
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Kiosk_ver_1.Model.Product product1 = new Kiosk_ver_1.Model.Product();
            this.productCard1 = new Kiosk_ver_1.Component.Products.ProductCard();
            this.headerController1 = new Kiosk_ver_1.Component.HeaderController();
            this.productList1 = new Kiosk_ver_1.Component.Products.ProductList();
            this.SuspendLayout();
            // 
            // productCard1
            // 
            this.productCard1.BackColor = System.Drawing.Color.Transparent;
            this.productCard1.ID = 0;
            this.productCard1.Image = ((System.Drawing.Image)(resources.GetObject("productCard1.Image")));
            this.productCard1.Location = new System.Drawing.Point(309, 37);
            this.productCard1.Margin = new System.Windows.Forms.Padding(1);
            this.productCard1.Name = "productCard1";
            this.productCard1.Price = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.productCard1.Size = new System.Drawing.Size(190, 223);
            this.productCard1.TabIndex = 1;
            this.productCard1.Title = "Apple";
            this.productCard1.Clicked += new System.EventHandler<Kiosk_ver_1.Component.Products.IProductCard>(this.productCard1_Clicked);
            // 
            // headerController1
            // 
            this.headerController1.ChangingDescription = "I\'m studying it";
            this.headerController1.ChangingTitle = "Kiosk_Version1";
            this.headerController1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerController1.Location = new System.Drawing.Point(0, 0);
            this.headerController1.Margin = new System.Windows.Forms.Padding(1);
            this.headerController1.Name = "headerController1";
            this.headerController1.Size = new System.Drawing.Size(575, 109);
            this.headerController1.TabIndex = 0;
            // 
            // productList1
            // 
            this.productList1.BackColor = System.Drawing.Color.Transparent;
            product1.ID = 1;
            product1.Image = ((System.Drawing.Image)(resources.GetObject("product1.Image")));
            product1.Price = new decimal(new int[] {
            100,
            0,
            0,
            0});
            product1.Title = "test";
            this.productList1.Items.Add(product1);
            this.productList1.Location = new System.Drawing.Point(48, 129);
            this.productList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productList1.Name = "productList1";
            this.productList1.Size = new System.Drawing.Size(237, 305);
            this.productList1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 541);
            this.Controls.Add(this.productList1);
            this.Controls.Add(this.productCard1);
            this.Controls.Add(this.headerController1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Component.HeaderController headerController1;
        private Component.Products.ProductCard productCard1;
        private Component.Products.ProductList productList1;
    }
}

