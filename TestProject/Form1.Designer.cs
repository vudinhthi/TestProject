﻿namespace TestProject
{
    partial class Form1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator4 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator4 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.calcEdit1 = new DevExpress.XtraEditors.CalcEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.barCodeControl2 = new DevExpress.XtraEditors.BarCodeControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(12, 183);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 322);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView1_MasterRowExpanded);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(12, 39);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new System.Drawing.Size(273, 20);
            this.lookUpEdit1.TabIndex = 2;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(12, 13);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(273, 20);
            this.lookUpEdit2.TabIndex = 5;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.HorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.barCodeControl1.Location = new System.Drawing.Point(291, 12);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(237, 100);
            qrCodeGenerator4.ErrorCorrectionLevel = DevExpress.XtraPrinting.BarCode.QRCodeErrorCorrectionLevel.M;
            qrCodeGenerator4.Version = DevExpress.XtraPrinting.BarCode.QRCodeVersion.Version1;
            this.barCodeControl1.Symbology = qrCodeGenerator4;
            this.barCodeControl1.TabIndex = 6;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "Test thoi";
            this.textEdit1.Location = new System.Drawing.Point(534, 12);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Mask.BeepOnError = true;
            this.textEdit1.Properties.Mask.EditMask = "n";
            this.textEdit1.Size = new System.Drawing.Size(254, 20);
            this.textEdit1.TabIndex = 8;
            // 
            // calcEdit1
            // 
            this.calcEdit1.Location = new System.Drawing.Point(534, 39);
            this.calcEdit1.Name = "calcEdit1";
            this.calcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEdit1.Size = new System.Drawing.Size(100, 20);
            this.calcEdit1.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(640, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 23);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(534, 66);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(254, 20);
            this.textEdit2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 147);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(273, 30);
            this.progressBarControl1.TabIndex = 13;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(534, 92);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(254, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Check update...";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // barCodeControl2
            // 
            this.barCodeControl2.Location = new System.Drawing.Point(534, 151);
            this.barCodeControl2.Name = "barCodeControl2";
            this.barCodeControl2.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl2.Size = new System.Drawing.Size(107, 23);
            this.barCodeControl2.Symbology = code128Generator4;
            this.barCodeControl2.TabIndex = 15;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(534, 122);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(254, 23);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "Test thoi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.barCodeControl2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.calcEdit1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.CalcEdit calcEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}

