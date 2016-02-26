namespace MyDXApplication
{
    partial class FrmConfiguracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TestBtn = new DevExpress.XtraEditors.SimpleButton();
            this.bDText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.WindowsAutenticationChk = new System.Windows.Forms.CheckBox();
            this.contrasenaTxt = new DevExpress.XtraEditors.TextEdit();
            this.usuarioTxt = new DevExpress.XtraEditors.TextEdit();
            this.servidorTxt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SalvarBtn = new DevExpress.XtraEditors.SimpleButton();
            this.CancelarBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TestBtn);
            this.groupControl1.Controls.Add(this.bDText);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.WindowsAutenticationChk);
            this.groupControl1.Controls.Add(this.contrasenaTxt);
            this.groupControl1.Controls.Add(this.usuarioTxt);
            this.groupControl1.Controls.Add(this.servidorTxt);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(16, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(260, 167);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ingrese Condiguracion";
            // 
            // TestBtn
            // 
            this.TestBtn.Image = ((System.Drawing.Image)(resources.GetObject("TestBtn.Image")));
            this.TestBtn.Location = new System.Drawing.Point(209, 33);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(45, 43);
            this.TestBtn.TabIndex = 6;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // bDText
            // 
            this.bDText.Location = new System.Drawing.Point(103, 60);
            this.bDText.Name = "bDText";
            this.bDText.Size = new System.Drawing.Size(100, 20);
            this.bDText.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Base de Datos:";
            // 
            // WindowsAutenticationChk
            // 
            this.WindowsAutenticationChk.AutoSize = true;
            this.WindowsAutenticationChk.Location = new System.Drawing.Point(102, 143);
            this.WindowsAutenticationChk.Name = "WindowsAutenticationChk";
            this.WindowsAutenticationChk.Size = new System.Drawing.Size(152, 17);
            this.WindowsAutenticationChk.TabIndex = 5;
            this.WindowsAutenticationChk.Text = "Autenticacion de Windows";
            this.WindowsAutenticationChk.UseVisualStyleBackColor = true;
            this.WindowsAutenticationChk.CheckedChanged += new System.EventHandler(this.WindowsAutenticationChk_CheckedChanged);
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(103, 112);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.Properties.PasswordChar = '*';
            this.contrasenaTxt.Size = new System.Drawing.Size(100, 20);
            this.contrasenaTxt.TabIndex = 4;
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Location = new System.Drawing.Point(103, 86);
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(100, 20);
            this.usuarioTxt.TabIndex = 3;
            // 
            // servidorTxt
            // 
            this.servidorTxt.Location = new System.Drawing.Point(103, 33);
            this.servidorTxt.Name = "servidorTxt";
            this.servidorTxt.Size = new System.Drawing.Size(100, 20);
            this.servidorTxt.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Contraseña:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Usuario:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Servidor:";
            // 
            // SalvarBtn
            // 
            this.SalvarBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalvarBtn.Image")));
            this.SalvarBtn.Location = new System.Drawing.Point(31, 187);
            this.SalvarBtn.Name = "SalvarBtn";
            this.SalvarBtn.Size = new System.Drawing.Size(105, 38);
            this.SalvarBtn.TabIndex = 7;
            this.SalvarBtn.Text = "Salvar";
            this.SalvarBtn.Click += new System.EventHandler(this.SalvarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CancelarBtn.Image")));
            this.CancelarBtn.Location = new System.Drawing.Point(146, 187);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(115, 38);
            this.CancelarBtn.TabIndex = 8;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click_1);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 232);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.SalvarBtn);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 270);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrasenaTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servidorTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton SalvarBtn;
        private DevExpress.XtraEditors.SimpleButton CancelarBtn;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox WindowsAutenticationChk;
        private DevExpress.XtraEditors.TextEdit contrasenaTxt;
        private DevExpress.XtraEditors.TextEdit usuarioTxt;
        private DevExpress.XtraEditors.TextEdit servidorTxt;
        private DevExpress.XtraEditors.TextEdit bDText;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton TestBtn;
    }
}