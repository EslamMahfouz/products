﻿namespace Products.PL
{
    partial class FormSupplierDetails
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtSaveCharge = new DevExpress.XtraEditors.SimpleButton();
            this.lblPaid = new DevExpress.XtraEditors.LabelControl();
            this.txtPaid = new DevExpress.XtraEditors.TextEdit();
            this.btnPay = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbSuplierDetails = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblSupplier = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCharge = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnSaveChargeOrder = new DevExpress.XtraEditors.SimpleButton();
            this.lblPaidOrder = new DevExpress.XtraEditors.LabelControl();
            this.txtPaidOrder = new DevExpress.XtraEditors.TextEdit();
            this.btnPayOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowRowDetails = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuplierDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(985, 432);
            this.xtraTabControl1.TabIndex = 34;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtSaveCharge);
            this.xtraTabPage1.Controls.Add(this.lblPaid);
            this.xtraTabPage1.Controls.Add(this.txtPaid);
            this.xtraTabPage1.Controls.Add(this.btnPay);
            this.xtraTabPage1.Controls.Add(this.btnSave);
            this.xtraTabPage1.Controls.Add(this.cmbSuplierDetails);
            this.xtraTabPage1.Controls.Add(this.btnDelete);
            this.xtraTabPage1.Controls.Add(this.lblSupplier);
            this.xtraTabPage1.Controls.Add(this.btnEdit);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtCharge);
            this.xtraTabPage1.Controls.Add(this.txtAddress);
            this.xtraTabPage1.Controls.Add(this.txtPhone);
            this.xtraTabPage1.Controls.Add(this.txtTel);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(979, 404);
            this.xtraTabPage1.Text = "بيانات المورد";
            // 
            // txtSaveCharge
            // 
            this.txtSaveCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveCharge.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtSaveCharge.Appearance.Options.UseFont = true;
            this.txtSaveCharge.Location = new System.Drawing.Point(615, 320);
            this.txtSaveCharge.Name = "txtSaveCharge";
            this.txtSaveCharge.Size = new System.Drawing.Size(105, 39);
            this.txtSaveCharge.TabIndex = 49;
            this.txtSaveCharge.Text = "حفظ";
            this.txtSaveCharge.Visible = false;
            this.txtSaveCharge.Click += new System.EventHandler(this.txtSaveCharge_Click);
            // 
            // lblPaid
            // 
            this.lblPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaid.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaid.Location = new System.Drawing.Point(890, 328);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(60, 23);
            this.lblPaid.TabIndex = 48;
            this.lblPaid.Text = "المدفوع";
            this.lblPaid.Visible = false;
            // 
            // txtPaid
            // 
            this.txtPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaid.EditValue = 0D;
            this.txtPaid.Location = new System.Drawing.Point(744, 328);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaid.Properties.Appearance.Options.UseFont = true;
            this.txtPaid.Properties.Mask.EditMask = "f";
            this.txtPaid.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaid.Size = new System.Drawing.Size(121, 26);
            this.txtPaid.TabIndex = 47;
            this.txtPaid.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPay.Appearance.Options.UseFont = true;
            this.btnPay.Location = new System.Drawing.Point(615, 256);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(335, 45);
            this.btnPay.TabIndex = 45;
            this.btnPay.Text = "سداد باقى قديم";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(447, 143);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "حفظ التعديلات";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSuplierDetails
            // 
            this.cmbSuplierDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSuplierDetails.Location = new System.Drawing.Point(615, 86);
            this.cmbSuplierDetails.Name = "cmbSuplierDetails";
            this.cmbSuplierDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbSuplierDetails.Properties.Appearance.Options.UseFont = true;
            this.cmbSuplierDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSuplierDetails.Properties.NullText = "";
            this.cmbSuplierDetails.Properties.View = this.searchLookUpEdit1View;
            this.cmbSuplierDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSuplierDetails.Size = new System.Drawing.Size(233, 26);
            this.cmbSuplierDetails.TabIndex = 44;
            this.cmbSuplierDetails.EditValueChanged += new System.EventHandler(this.cmbSuplierDetails_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(447, 200);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplier.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblSupplier.Location = new System.Drawing.Point(720, 39);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(111, 27);
            this.lblSupplier.TabIndex = 43;
            this.lblSupplier.Text = "بيانات المورد";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Location = new System.Drawing.Point(447, 86);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 45);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Location = new System.Drawing.Point(861, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 23);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "اسم المورد";
            // 
            // txtCharge
            // 
            this.txtCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCharge.Location = new System.Drawing.Point(615, 216);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtCharge.Properties.Appearance.Options.UseFont = true;
            this.txtCharge.Properties.Mask.EditMask = "f";
            this.txtCharge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCharge.Properties.ReadOnly = true;
            this.txtCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCharge.Size = new System.Drawing.Size(233, 26);
            this.txtCharge.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(615, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(233, 26);
            this.txtAddress.TabIndex = 40;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(615, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPhone.Properties.ReadOnly = true;
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(233, 26);
            this.txtPhone.TabIndex = 39;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(615, 121);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTel.Properties.Appearance.Options.UseFont = true;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTel.Size = new System.Drawing.Size(233, 26);
            this.txtTel.TabIndex = 38;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Location = new System.Drawing.Point(898, 184);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 23);
            this.labelControl5.TabIndex = 37;
            this.labelControl5.Text = "العنوان";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Location = new System.Drawing.Point(885, 216);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(65, 23);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "المتبقى";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Location = new System.Drawing.Point(888, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 23);
            this.labelControl3.TabIndex = 35;
            this.labelControl3.Text = "التليفون";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl4.Location = new System.Drawing.Point(890, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 23);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "الموبايل";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnSaveChargeOrder);
            this.xtraTabPage2.Controls.Add(this.lblPaidOrder);
            this.xtraTabPage2.Controls.Add(this.txtPaidOrder);
            this.xtraTabPage2.Controls.Add(this.btnPayOrder);
            this.xtraTabPage2.Controls.Add(this.btnShowRowDetails);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(979, 404);
            this.xtraTabPage2.Text = "عمليات الشراء";
            // 
            // btnSaveChargeOrder
            // 
            this.btnSaveChargeOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnSaveChargeOrder.Appearance.Options.UseFont = true;
            this.btnSaveChargeOrder.Location = new System.Drawing.Point(40, 366);
            this.btnSaveChargeOrder.Name = "btnSaveChargeOrder";
            this.btnSaveChargeOrder.Size = new System.Drawing.Size(105, 39);
            this.btnSaveChargeOrder.TabIndex = 14;
            this.btnSaveChargeOrder.Text = "حفظ";
            this.btnSaveChargeOrder.Visible = false;
            this.btnSaveChargeOrder.Click += new System.EventHandler(this.btnSaveChargeOrder_Click);
            // 
            // lblPaidOrder
            // 
            this.lblPaidOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaidOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblPaidOrder.Location = new System.Drawing.Point(318, 374);
            this.lblPaidOrder.Name = "lblPaidOrder";
            this.lblPaidOrder.Size = new System.Drawing.Size(60, 23);
            this.lblPaidOrder.TabIndex = 13;
            this.lblPaidOrder.Text = "المدفوع";
            this.lblPaidOrder.Visible = false;
            // 
            // txtPaidOrder
            // 
            this.txtPaidOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaidOrder.EditValue = 0D;
            this.txtPaidOrder.Location = new System.Drawing.Point(169, 374);
            this.txtPaidOrder.Name = "txtPaidOrder";
            this.txtPaidOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPaidOrder.Properties.Appearance.Options.UseFont = true;
            this.txtPaidOrder.Properties.Mask.EditMask = "f";
            this.txtPaidOrder.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPaidOrder.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtPaidOrder.Size = new System.Drawing.Size(121, 26);
            this.txtPaidOrder.TabIndex = 12;
            this.txtPaidOrder.Visible = false;
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnPayOrder.Appearance.Options.UseFont = true;
            this.btnPayOrder.Location = new System.Drawing.Point(396, 366);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(250, 38);
            this.btnPayOrder.TabIndex = 11;
            this.btnPayOrder.Text = "سداد باقى الفاتورة";
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // btnShowRowDetails
            // 
            this.btnShowRowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowRowDetails.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnShowRowDetails.Appearance.Options.UseFont = true;
            this.btnShowRowDetails.Location = new System.Drawing.Point(691, 367);
            this.btnShowRowDetails.Name = "btnShowRowDetails";
            this.btnShowRowDetails.Size = new System.Drawing.Size(250, 38);
            this.btnShowRowDetails.TabIndex = 2;
            this.btnShowRowDetails.Text = "تفاصيل الفاتورة";
            this.btnShowRowDetails.Click += new System.EventHandler(this.btnShowRowDetails_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(979, 366);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // FormSupplierDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 432);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "FormSupplierDetails";
            this.Text = "بيانات المورد";
            this.Load += new System.EventHandler(this.FormSupplierDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSuplierDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCharge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbSuplierDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl lblSupplier;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCharge;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnShowRowDetails;
        private DevExpress.XtraEditors.SimpleButton btnPay;
        private DevExpress.XtraEditors.SimpleButton btnSaveChargeOrder;
        private DevExpress.XtraEditors.LabelControl lblPaidOrder;
        private DevExpress.XtraEditors.TextEdit txtPaidOrder;
        private DevExpress.XtraEditors.SimpleButton btnPayOrder;
        private DevExpress.XtraEditors.SimpleButton txtSaveCharge;
        private DevExpress.XtraEditors.LabelControl lblPaid;
        private DevExpress.XtraEditors.TextEdit txtPaid;
    }
}