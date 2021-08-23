using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

using FTI.Shared.Trialmax;
using FTI.Trialmax.Controls;

namespace FTI.Trialmax.Forms
{
	/// <summary>This form implements a user interface that allows the user to set the registration options</summary>
	public class CFRegOptions : System.Windows.Forms.Form
	{
		#region Private Members
		
		/// <summary>OK button</summary>
		private System.Windows.Forms.Button m_ctrlOk;
		
		/// <summary>Cancel button</summary>
		private System.Windows.Forms.Button m_ctrlCancel;
		
		/// <summary>File transfer options radio list box</summary>
		private FTI.Trialmax.Controls.CRadioListCtrl m_ctrlFileTransfers;
		
		/// <summary>Group container for file transfer options</summary>
		private System.Windows.Forms.GroupBox m_ctrlFileTransfersGroup;

		/// <summary>Morphing methods radio list box</summary>
		private FTI.Trialmax.Controls.CRadioListCtrl m_ctrlMorphMethods;
		
		/// <summary>Group container for morph method options</summary>
		private System.Windows.Forms.GroupBox m_ctrlMorphMethodsGroup;

		/// <summary>Radio list control for confict resolution options</summary>
		private FTI.Trialmax.Controls.CRadioListCtrl m_ctrlConflictResolutions;
		
		/// <summary>Group container for confict resolution options</summary>
		private System.Windows.Forms.GroupBox m_ctrlConflictResolutionsGroup;
		
		/// <summary>Radio list control for folder assignment options</summary>
		private System.Windows.Forms.CheckedListBox m_ctrlFolderAssignments;
		
		/// <summary>Group container for folder assignment options</summary>
		private System.Windows.Forms.GroupBox m_ctrlFolderAssignmentsGroup;
		
		/// <summary>Radio list control for registration flags</summary>
		private System.Windows.Forms.CheckedListBox m_ctrlFlags;
		
		/// <summary>Group container for registration flags</summary>
		private System.Windows.Forms.GroupBox m_ctrlFlagsGroup;
		private System.Windows.Forms.GroupBox m_ctrlMediaCreationGroup;
		private System.Windows.Forms.TextBox m_ctrlMorphText;
		private System.Windows.Forms.Label m_ctrlMorphTextLabel;
		private System.Windows.Forms.TextBox m_ctrlConflictText;
		private System.Windows.Forms.Label m_ctrlConflictTextLabel;
		private FTI.Trialmax.Controls.CRadioListCtrl m_ctrlMediaCreations;
		private System.Windows.Forms.CheckedListBox m_ctrlMediaIdAdjustments;
		private System.Windows.Forms.GroupBox m_ctrlMediaIdAdjustmentsGroup;
		private System.Windows.Forms.CheckedListBox m_ctrlForeignBarcodeAdjustments;
		private System.Windows.Forms.GroupBox m_ctrlForeignBarcodeAdjustmentsGroup;
        private GroupBox m_ctrlPDFOptionsGroup;
        private MaskedTextBox m_ctrlCustomDPIMask;
        private CheckBox m_ctrlCustomDPICheck;
        private RadioButton m_ctrlColorRadio;
        private RadioButton m_ctrlBWRadio;
        private RadioButton m_ctrlAutoDetectRadio;
        private CheckBox m_ctrlDisableCustomDither;

		/// <summary>Registration options assocaited with the control</summary>
		private CTmaxRegOptions m_tmaxRegOptions = null;
		
		#endregion Private Members
		
		#region Public Methods
		
		/// <summary>Default constructor</summary>
		public CFRegOptions()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}//	CTmaxRegOptionsForm()
		
		
		#endregion Public Methods
		
		#region Protected Methods

		/// <summary>Cleans up any resources being used by the form</summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		
		#endregion Protected Methods

		#region Private Methods
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFRegOptions));
            this.m_ctrlOk = new System.Windows.Forms.Button();
            this.m_ctrlCancel = new System.Windows.Forms.Button();
            this.m_ctrlFileTransfers = new FTI.Trialmax.Controls.CRadioListCtrl();
            this.m_ctrlMorphMethods = new FTI.Trialmax.Controls.CRadioListCtrl();
            this.m_ctrlConflictResolutions = new FTI.Trialmax.Controls.CRadioListCtrl();
            this.m_ctrlFileTransfersGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlMorphMethodsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlMorphText = new System.Windows.Forms.TextBox();
            this.m_ctrlMorphTextLabel = new System.Windows.Forms.Label();
            this.m_ctrlConflictResolutionsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlConflictTextLabel = new System.Windows.Forms.Label();
            this.m_ctrlConflictText = new System.Windows.Forms.TextBox();
            this.m_ctrlFolderAssignments = new System.Windows.Forms.CheckedListBox();
            this.m_ctrlFolderAssignmentsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlFlags = new System.Windows.Forms.CheckedListBox();
            this.m_ctrlFlagsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlMediaCreationGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlMediaCreations = new FTI.Trialmax.Controls.CRadioListCtrl();
            this.m_ctrlMediaIdAdjustments = new System.Windows.Forms.CheckedListBox();
            this.m_ctrlMediaIdAdjustmentsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlForeignBarcodeAdjustments = new System.Windows.Forms.CheckedListBox();
            this.m_ctrlForeignBarcodeAdjustmentsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlPDFOptionsGroup = new System.Windows.Forms.GroupBox();
            this.m_ctrlDisableCustomDither = new System.Windows.Forms.CheckBox();
            this.m_ctrlCustomDPIMask = new System.Windows.Forms.MaskedTextBox();
            this.m_ctrlCustomDPICheck = new System.Windows.Forms.CheckBox();
            this.m_ctrlColorRadio = new System.Windows.Forms.RadioButton();
            this.m_ctrlBWRadio = new System.Windows.Forms.RadioButton();
            this.m_ctrlAutoDetectRadio = new System.Windows.Forms.RadioButton();
            this.m_ctrlMorphMethodsGroup.SuspendLayout();
            this.m_ctrlConflictResolutionsGroup.SuspendLayout();
            this.m_ctrlMediaCreationGroup.SuspendLayout();
            this.m_ctrlPDFOptionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ctrlOk
            // 
            this.m_ctrlOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_ctrlOk.Location = new System.Drawing.Point(495, 358);
            this.m_ctrlOk.Name = "m_ctrlOk";
            this.m_ctrlOk.Size = new System.Drawing.Size(75, 23);
            this.m_ctrlOk.TabIndex = 8;
            this.m_ctrlOk.Text = "&OK";
            this.m_ctrlOk.Click += new System.EventHandler(this.OnClickOk);
            // 
            // m_ctrlCancel
            // 
            this.m_ctrlCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_ctrlCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_ctrlCancel.Location = new System.Drawing.Point(576, 358);
            this.m_ctrlCancel.Name = "m_ctrlCancel";
            this.m_ctrlCancel.Size = new System.Drawing.Size(75, 23);
            this.m_ctrlCancel.TabIndex = 9;
            this.m_ctrlCancel.Text = "  &Cancel";
            // 
            // m_ctrlFileTransfers
            // 
            this.m_ctrlFileTransfers.CheckOnClick = true;
            this.m_ctrlFileTransfers.IntegralHeight = false;
            this.m_ctrlFileTransfers.Location = new System.Drawing.Point(231, 24);
            this.m_ctrlFileTransfers.Name = "m_ctrlFileTransfers";
            this.m_ctrlFileTransfers.SingleSelection = true;
            this.m_ctrlFileTransfers.Size = new System.Drawing.Size(196, 72);
            this.m_ctrlFileTransfers.TabIndex = 0;
            // 
            // m_ctrlMorphMethods
            // 
            this.m_ctrlMorphMethods.CheckOnClick = true;
            this.m_ctrlMorphMethods.IntegralHeight = false;
            this.m_ctrlMorphMethods.Location = new System.Drawing.Point(15, 128);
            this.m_ctrlMorphMethods.Name = "m_ctrlMorphMethods";
            this.m_ctrlMorphMethods.SingleSelection = true;
            this.m_ctrlMorphMethods.Size = new System.Drawing.Size(196, 72);
            this.m_ctrlMorphMethods.TabIndex = 2;
            this.m_ctrlMorphMethods.SelectedIndexChanged += new System.EventHandler(this.OnMorphSelChanged);
            // 
            // m_ctrlConflictResolutions
            // 
            this.m_ctrlConflictResolutions.CheckOnClick = true;
            this.m_ctrlConflictResolutions.IntegralHeight = false;
            this.m_ctrlConflictResolutions.Location = new System.Drawing.Point(231, 128);
            this.m_ctrlConflictResolutions.Name = "m_ctrlConflictResolutions";
            this.m_ctrlConflictResolutions.SingleSelection = true;
            this.m_ctrlConflictResolutions.Size = new System.Drawing.Size(196, 72);
            this.m_ctrlConflictResolutions.TabIndex = 3;
            this.m_ctrlConflictResolutions.SelectedIndexChanged += new System.EventHandler(this.OnConflictSelChanged);
            // 
            // m_ctrlFileTransfersGroup
            // 
            this.m_ctrlFileTransfersGroup.Location = new System.Drawing.Point(223, 8);
            this.m_ctrlFileTransfersGroup.Name = "m_ctrlFileTransfersGroup";
            this.m_ctrlFileTransfersGroup.Size = new System.Drawing.Size(212, 96);
            this.m_ctrlFileTransfersGroup.TabIndex = 1;
            this.m_ctrlFileTransfersGroup.TabStop = false;
            this.m_ctrlFileTransfersGroup.Text = "File Transfer Method";
            // 
            // m_ctrlMorphMethodsGroup
            // 
            this.m_ctrlMorphMethodsGroup.Controls.Add(this.m_ctrlMorphText);
            this.m_ctrlMorphMethodsGroup.Controls.Add(this.m_ctrlMorphTextLabel);
            this.m_ctrlMorphMethodsGroup.Location = new System.Drawing.Point(7, 112);
            this.m_ctrlMorphMethodsGroup.Name = "m_ctrlMorphMethodsGroup";
            this.m_ctrlMorphMethodsGroup.Size = new System.Drawing.Size(212, 124);
            this.m_ctrlMorphMethodsGroup.TabIndex = 3;
            this.m_ctrlMorphMethodsGroup.TabStop = false;
            this.m_ctrlMorphMethodsGroup.Text = "Morphing Method";
            // 
            // m_ctrlMorphText
            // 
            this.m_ctrlMorphText.Location = new System.Drawing.Point(72, 96);
            this.m_ctrlMorphText.Name = "m_ctrlMorphText";
            this.m_ctrlMorphText.Size = new System.Drawing.Size(132, 20);
            this.m_ctrlMorphText.TabIndex = 0;
            // 
            // m_ctrlMorphTextLabel
            // 
            this.m_ctrlMorphTextLabel.Location = new System.Drawing.Point(8, 96);
            this.m_ctrlMorphTextLabel.Name = "m_ctrlMorphTextLabel";
            this.m_ctrlMorphTextLabel.Size = new System.Drawing.Size(60, 20);
            this.m_ctrlMorphTextLabel.TabIndex = 33;
            this.m_ctrlMorphTextLabel.Text = "Prefix:";
            this.m_ctrlMorphTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_ctrlConflictResolutionsGroup
            // 
            this.m_ctrlConflictResolutionsGroup.Controls.Add(this.m_ctrlConflictTextLabel);
            this.m_ctrlConflictResolutionsGroup.Controls.Add(this.m_ctrlConflictText);
            this.m_ctrlConflictResolutionsGroup.Location = new System.Drawing.Point(223, 112);
            this.m_ctrlConflictResolutionsGroup.Name = "m_ctrlConflictResolutionsGroup";
            this.m_ctrlConflictResolutionsGroup.Size = new System.Drawing.Size(212, 124);
            this.m_ctrlConflictResolutionsGroup.TabIndex = 4;
            this.m_ctrlConflictResolutionsGroup.TabStop = false;
            this.m_ctrlConflictResolutionsGroup.Text = "Conflict Resolution";
            // 
            // m_ctrlConflictTextLabel
            // 
            this.m_ctrlConflictTextLabel.Location = new System.Drawing.Point(8, 96);
            this.m_ctrlConflictTextLabel.Name = "m_ctrlConflictTextLabel";
            this.m_ctrlConflictTextLabel.Size = new System.Drawing.Size(60, 20);
            this.m_ctrlConflictTextLabel.TabIndex = 35;
            this.m_ctrlConflictTextLabel.Text = "Not Used";
            this.m_ctrlConflictTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_ctrlConflictText
            // 
            this.m_ctrlConflictText.Location = new System.Drawing.Point(68, 96);
            this.m_ctrlConflictText.Name = "m_ctrlConflictText";
            this.m_ctrlConflictText.Size = new System.Drawing.Size(136, 20);
            this.m_ctrlConflictText.TabIndex = 0;
            // 
            // m_ctrlFolderAssignments
            // 
            this.m_ctrlFolderAssignments.CheckOnClick = true;
            this.m_ctrlFolderAssignments.IntegralHeight = false;
            this.m_ctrlFolderAssignments.Location = new System.Drawing.Point(447, 24);
            this.m_ctrlFolderAssignments.Name = "m_ctrlFolderAssignments";
            this.m_ctrlFolderAssignments.Size = new System.Drawing.Size(196, 72);
            this.m_ctrlFolderAssignments.TabIndex = 1;
            // 
            // m_ctrlFolderAssignmentsGroup
            // 
            this.m_ctrlFolderAssignmentsGroup.Location = new System.Drawing.Point(439, 8);
            this.m_ctrlFolderAssignmentsGroup.Name = "m_ctrlFolderAssignmentsGroup";
            this.m_ctrlFolderAssignmentsGroup.Size = new System.Drawing.Size(212, 96);
            this.m_ctrlFolderAssignmentsGroup.TabIndex = 2;
            this.m_ctrlFolderAssignmentsGroup.TabStop = false;
            this.m_ctrlFolderAssignmentsGroup.Text = "Folder Assignments";
            // 
            // m_ctrlFlags
            // 
            this.m_ctrlFlags.CheckOnClick = true;
            this.m_ctrlFlags.IntegralHeight = false;
            this.m_ctrlFlags.Location = new System.Drawing.Point(447, 128);
            this.m_ctrlFlags.Name = "m_ctrlFlags";
            this.m_ctrlFlags.Size = new System.Drawing.Size(196, 100);
            this.m_ctrlFlags.TabIndex = 4;
            // 
            // m_ctrlFlagsGroup
            // 
            this.m_ctrlFlagsGroup.Location = new System.Drawing.Point(439, 112);
            this.m_ctrlFlagsGroup.Name = "m_ctrlFlagsGroup";
            this.m_ctrlFlagsGroup.Size = new System.Drawing.Size(212, 124);
            this.m_ctrlFlagsGroup.TabIndex = 5;
            this.m_ctrlFlagsGroup.TabStop = false;
            this.m_ctrlFlagsGroup.Text = "Options";
            // 
            // m_ctrlMediaCreationGroup
            // 
            this.m_ctrlMediaCreationGroup.Controls.Add(this.m_ctrlMediaCreations);
            this.m_ctrlMediaCreationGroup.Location = new System.Drawing.Point(7, 8);
            this.m_ctrlMediaCreationGroup.Name = "m_ctrlMediaCreationGroup";
            this.m_ctrlMediaCreationGroup.Size = new System.Drawing.Size(212, 96);
            this.m_ctrlMediaCreationGroup.TabIndex = 0;
            this.m_ctrlMediaCreationGroup.TabStop = false;
            this.m_ctrlMediaCreationGroup.Text = "Media Creation";
            // 
            // m_ctrlMediaCreations
            // 
            this.m_ctrlMediaCreations.CheckOnClick = true;
            this.m_ctrlMediaCreations.IntegralHeight = false;
            this.m_ctrlMediaCreations.Location = new System.Drawing.Point(8, 16);
            this.m_ctrlMediaCreations.Name = "m_ctrlMediaCreations";
            this.m_ctrlMediaCreations.SingleSelection = true;
            this.m_ctrlMediaCreations.Size = new System.Drawing.Size(196, 72);
            this.m_ctrlMediaCreations.TabIndex = 0;
            // 
            // m_ctrlMediaIdAdjustments
            // 
            this.m_ctrlMediaIdAdjustments.CheckOnClick = true;
            this.m_ctrlMediaIdAdjustments.IntegralHeight = false;
            this.m_ctrlMediaIdAdjustments.Location = new System.Drawing.Point(16, 260);
            this.m_ctrlMediaIdAdjustments.Name = "m_ctrlMediaIdAdjustments";
            this.m_ctrlMediaIdAdjustments.Size = new System.Drawing.Size(196, 82);
            this.m_ctrlMediaIdAdjustments.TabIndex = 33;
            // 
            // m_ctrlMediaIdAdjustmentsGroup
            // 
            this.m_ctrlMediaIdAdjustmentsGroup.Location = new System.Drawing.Point(8, 244);
            this.m_ctrlMediaIdAdjustmentsGroup.Name = "m_ctrlMediaIdAdjustmentsGroup";
            this.m_ctrlMediaIdAdjustmentsGroup.Size = new System.Drawing.Size(212, 108);
            this.m_ctrlMediaIdAdjustmentsGroup.TabIndex = 6;
            this.m_ctrlMediaIdAdjustmentsGroup.TabStop = false;
            this.m_ctrlMediaIdAdjustmentsGroup.Text = "Media ID Adjustments";
            // 
            // m_ctrlForeignBarcodeAdjustments
            // 
            this.m_ctrlForeignBarcodeAdjustments.CheckOnClick = true;
            this.m_ctrlForeignBarcodeAdjustments.IntegralHeight = false;
            this.m_ctrlForeignBarcodeAdjustments.Location = new System.Drawing.Point(231, 260);
            this.m_ctrlForeignBarcodeAdjustments.Name = "m_ctrlForeignBarcodeAdjustments";
            this.m_ctrlForeignBarcodeAdjustments.Size = new System.Drawing.Size(196, 82);
            this.m_ctrlForeignBarcodeAdjustments.TabIndex = 35;
            // 
            // m_ctrlForeignBarcodeAdjustmentsGroup
            // 
            this.m_ctrlForeignBarcodeAdjustmentsGroup.Location = new System.Drawing.Point(223, 244);
            this.m_ctrlForeignBarcodeAdjustmentsGroup.Name = "m_ctrlForeignBarcodeAdjustmentsGroup";
            this.m_ctrlForeignBarcodeAdjustmentsGroup.Size = new System.Drawing.Size(212, 108);
            this.m_ctrlForeignBarcodeAdjustmentsGroup.TabIndex = 7;
            this.m_ctrlForeignBarcodeAdjustmentsGroup.TabStop = false;
            this.m_ctrlForeignBarcodeAdjustmentsGroup.Text = "Foreign Barcodes";
            // 
            // m_ctrlPDFOptionsGroup
            // 
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlDisableCustomDither);
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlCustomDPIMask);
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlCustomDPICheck);
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlColorRadio);
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlBWRadio);
            this.m_ctrlPDFOptionsGroup.Controls.Add(this.m_ctrlAutoDetectRadio);
            this.m_ctrlPDFOptionsGroup.Location = new System.Drawing.Point(439, 244);
            this.m_ctrlPDFOptionsGroup.Name = "m_ctrlPDFOptionsGroup";
            this.m_ctrlPDFOptionsGroup.Size = new System.Drawing.Size(212, 108);
            this.m_ctrlPDFOptionsGroup.TabIndex = 36;
            this.m_ctrlPDFOptionsGroup.TabStop = false;
            this.m_ctrlPDFOptionsGroup.Text = "PDF Options";
            // 
            // m_ctrlDisableCustomDither
            // 
            this.m_ctrlDisableCustomDither.AutoSize = true;
            this.m_ctrlDisableCustomDither.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ctrlDisableCustomDither.Location = new System.Drawing.Point(7, 81);
            this.m_ctrlDisableCustomDither.Name = "m_ctrlDisableCustomDither";
            this.m_ctrlDisableCustomDither.Size = new System.Drawing.Size(159, 17);
            this.m_ctrlDisableCustomDither.TabIndex = 5;
            this.m_ctrlDisableCustomDither.Text = "Enable B/W Halftone Dither";
            this.m_ctrlDisableCustomDither.UseVisualStyleBackColor = true;
            // 
            // m_ctrlCustomDPIMask
            // 
            this.m_ctrlCustomDPIMask.Enabled = false;
            this.m_ctrlCustomDPIMask.Location = new System.Drawing.Point(149, 60);
            this.m_ctrlCustomDPIMask.Mask = "000";
            this.m_ctrlCustomDPIMask.Name = "m_ctrlCustomDPIMask";
            this.m_ctrlCustomDPIMask.PromptChar = ' ';
            this.m_ctrlCustomDPIMask.Size = new System.Drawing.Size(34, 20);
            this.m_ctrlCustomDPIMask.TabIndex = 4;
            this.m_ctrlCustomDPIMask.Text = "300";
            this.m_ctrlCustomDPIMask.TextChanged += new System.EventHandler(this.m_ctrlCustomDPIMask_TextChanged);
            // 
            // m_ctrlCustomDPICheck
            // 
            this.m_ctrlCustomDPICheck.AutoSize = true;
            this.m_ctrlCustomDPICheck.Location = new System.Drawing.Point(7, 64);
            this.m_ctrlCustomDPICheck.Name = "m_ctrlCustomDPICheck";
            this.m_ctrlCustomDPICheck.Size = new System.Drawing.Size(135, 17);
            this.m_ctrlCustomDPICheck.TabIndex = 3;
            this.m_ctrlCustomDPICheck.Text = "Export Out Custom DPI";
            this.m_ctrlCustomDPICheck.UseVisualStyleBackColor = true;
            this.m_ctrlCustomDPICheck.CheckedChanged += new System.EventHandler(this.m_ctrlCustomDPICheck_CheckedChanged);
            // 
            // m_ctrlColorRadio
            // 
            this.m_ctrlColorRadio.AutoSize = true;
            this.m_ctrlColorRadio.Location = new System.Drawing.Point(7, 47);
            this.m_ctrlColorRadio.Name = "m_ctrlColorRadio";
            this.m_ctrlColorRadio.Size = new System.Drawing.Size(79, 17);
            this.m_ctrlColorRadio.TabIndex = 2;
            this.m_ctrlColorRadio.Text = "Force Color";
            this.m_ctrlColorRadio.UseVisualStyleBackColor = true;
            this.m_ctrlColorRadio.Click += new System.EventHandler(this.m_ctrlColorRadio_Click);
            // 
            // m_ctrlBWRadio
            // 
            this.m_ctrlBWRadio.AutoSize = true;
            this.m_ctrlBWRadio.Location = new System.Drawing.Point(7, 31);
            this.m_ctrlBWRadio.Name = "m_ctrlBWRadio";
            this.m_ctrlBWRadio.Size = new System.Drawing.Size(134, 17);
            this.m_ctrlBWRadio.TabIndex = 1;
            this.m_ctrlBWRadio.Text = "Force Black and White";
            this.m_ctrlBWRadio.UseVisualStyleBackColor = true;
            this.m_ctrlBWRadio.Click += new System.EventHandler(this.m_ctrlBWRadio_Click);
            // 
            // m_ctrlAutoDetectRadio
            // 
            this.m_ctrlAutoDetectRadio.AutoSize = true;
            this.m_ctrlAutoDetectRadio.Checked = true;
            this.m_ctrlAutoDetectRadio.Location = new System.Drawing.Point(7, 15);
            this.m_ctrlAutoDetectRadio.Name = "m_ctrlAutoDetectRadio";
            this.m_ctrlAutoDetectRadio.Size = new System.Drawing.Size(104, 17);
            this.m_ctrlAutoDetectRadio.TabIndex = 0;
            this.m_ctrlAutoDetectRadio.TabStop = true;
            this.m_ctrlAutoDetectRadio.Text = "Autodetect Color";
            this.m_ctrlAutoDetectRadio.UseVisualStyleBackColor = true;
            this.m_ctrlAutoDetectRadio.CheckedChanged += new System.EventHandler(this.m_ctrlAutoDetectRadio_CheckedChanged);
            // 
            // CFRegOptions
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(658, 386);
            this.Controls.Add(this.m_ctrlPDFOptionsGroup);
            this.Controls.Add(this.m_ctrlForeignBarcodeAdjustments);
            this.Controls.Add(this.m_ctrlForeignBarcodeAdjustmentsGroup);
            this.Controls.Add(this.m_ctrlMediaIdAdjustments);
            this.Controls.Add(this.m_ctrlMediaIdAdjustmentsGroup);
            this.Controls.Add(this.m_ctrlMediaCreationGroup);
            this.Controls.Add(this.m_ctrlFlags);
            this.Controls.Add(this.m_ctrlFolderAssignments);
            this.Controls.Add(this.m_ctrlConflictResolutions);
            this.Controls.Add(this.m_ctrlMorphMethods);
            this.Controls.Add(this.m_ctrlFileTransfers);
            this.Controls.Add(this.m_ctrlCancel);
            this.Controls.Add(this.m_ctrlOk);
            this.Controls.Add(this.m_ctrlFileTransfersGroup);
            this.Controls.Add(this.m_ctrlMorphMethodsGroup);
            this.Controls.Add(this.m_ctrlConflictResolutionsGroup);
            this.Controls.Add(this.m_ctrlFolderAssignmentsGroup);
            this.Controls.Add(this.m_ctrlFlagsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CFRegOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration Options";
            this.Load += new System.EventHandler(this.OnLoad);
            this.m_ctrlMorphMethodsGroup.ResumeLayout(false);
            this.m_ctrlMorphMethodsGroup.PerformLayout();
            this.m_ctrlConflictResolutionsGroup.ResumeLayout(false);
            this.m_ctrlConflictResolutionsGroup.PerformLayout();
            this.m_ctrlMediaCreationGroup.ResumeLayout(false);
            this.m_ctrlPDFOptionsGroup.ResumeLayout(false);
            this.m_ctrlPDFOptionsGroup.PerformLayout();
            this.ResumeLayout(false);

		}
		
		/// <summary>
		/// This method handles events fired when the form is loaded
		/// </summary>
		/// <param name="sender">The object sending the event</param>
		/// <param name="e">Arguments associated with the event</param>
		private void OnLoad(object sender, System.EventArgs e)
		{
			//	Have the options been set?
			if(m_tmaxRegOptions != null)
			{
				//	Populate the list boxes
				m_ctrlMediaCreations.DataSource = m_tmaxRegOptions.MediaCreations;
				m_ctrlFileTransfers.DataSource = m_tmaxRegOptions.FileTransfers;
				m_ctrlMorphMethods.DataSource = m_tmaxRegOptions.MorphMethods;
				m_ctrlFolderAssignments.DataSource = m_tmaxRegOptions.FolderAssignments;
				m_ctrlConflictResolutions.DataSource = m_tmaxRegOptions.ConflictResolutions;
				m_ctrlMediaIdAdjustments.DataSource = m_tmaxRegOptions.MediaIdAdjustments;
				m_ctrlForeignBarcodeAdjustments.DataSource = m_tmaxRegOptions.ForeignBarcodeAdjustments;
				m_ctrlFlags.DataSource = m_tmaxRegOptions.Flags;
			
				//	Initialize the controls
				SetSelections();
			}
		
		}//	OnLoad()
		
		/// <summary>This method will set the list box selections using the local registration options object</summary>
		private void SetSelections()
		{
			//	Set the list box selections
			SetSelections(m_ctrlMediaCreations);
			SetSelections(m_ctrlFileTransfers);
			SetSelections(m_ctrlMorphMethods);
			SetSelections(m_ctrlConflictResolutions);
			SetSelections(m_ctrlFolderAssignments);
			SetSelections(m_ctrlMediaIdAdjustments);	
			SetSelections(m_ctrlForeignBarcodeAdjustments);	
			SetSelections(m_ctrlFlags);	
			
			m_ctrlMorphText.Text = m_tmaxRegOptions.MorphMethodText;
			m_ctrlConflictText.Text = m_tmaxRegOptions.ConflictResolutionText;		
		
			//OnMorphSelChanged(null, null);
			//OnConflictSelChanged(null, null);
		}
		
		/// <summary>This method will set the check state of all items in the specified list box</summary>
		/// <param name="ctrlListBox">List box containing the items to be checked</param>
		private void SetSelections(CheckedListBox ctrlListBox)
		{
			int				iIndex;
			CTmaxOption		tmaxRegOption;
			
			if((ctrlListBox != null) && (ctrlListBox.Items != null))
			{
				for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
				{
					if((tmaxRegOption = (CTmaxOption)ctrlListBox.Items[iIndex]) != null)
					{
						ctrlListBox.SetItemChecked(iIndex, (tmaxRegOption.Selected == true));
						if(tmaxRegOption.Selected == true)
							ctrlListBox.SelectedIndex = iIndex;
					}
				
				}// for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
			
			}// if((ctrlListBox != null) && (ctrlListBox.Items != null))
			
		}// SetSelections()
		
		/// <summary>This method will use the selections in the list box to set the Selected property of all registration options</summary>
		private void GetSelections()
		{
			//	Get the list box selections
			GetSelections(m_ctrlMediaCreations);
			GetSelections(m_ctrlFileTransfers);
			GetSelections(m_ctrlMorphMethods);
			GetSelections(m_ctrlConflictResolutions);
			GetSelections(m_ctrlFolderAssignments);
			GetSelections(m_ctrlMediaIdAdjustments);
			GetSelections(m_ctrlForeignBarcodeAdjustments);
			GetSelections(m_ctrlFlags);
		
			m_tmaxRegOptions.MorphMethodText = m_ctrlMorphText.Text;
			m_tmaxRegOptions.ConflictResolutionText = m_ctrlConflictText.Text;

            m_tmaxRegOptions.OutputType = GetOutputType();

            m_tmaxRegOptions.UseCustomDPI = m_ctrlCustomDPICheck.Checked;
            if (m_tmaxRegOptions.UseCustomDPI)
                m_tmaxRegOptions.CustomDPI = GetCustomDPIValue();

            m_tmaxRegOptions.DisableCustomDither = m_ctrlDisableCustomDither.Checked;
		}

        /// <summary>This method will return Output Type (Auto,Color,BW) </summary>
        private TmaxPDFOutputType GetOutputType()
        {
            if (m_ctrlBWRadio.Checked)
                return TmaxPDFOutputType.ForceBW;
            else if (m_ctrlColorRadio.Checked)
                return TmaxPDFOutputType.ForceColor;
            return TmaxPDFOutputType.Autodetect;
        }

        /// <summary>This method will return Output Type (Auto,Color,BW) </summary>
        private short GetCustomDPIValue()
        {
            try
            {
                return Convert.ToInt16(m_ctrlCustomDPIMask.Text);
            }
            catch (FormatException)
            {
                return 200;
            }
        }

		/// <summary>This method will validate the user selections</summary>
		private bool Verify()
		{
			object	O = null;
			bool	bError = false;
			string	strMsg = "";
			
			//	Check the morphing text supplied by the user
			if((O = GetSelection(m_ctrlMorphMethods)) != null)
			{
				switch((RegMorphMethods)O)
				{
					case RegMorphMethods.Prefix:
					case RegMorphMethods.Suffix:
					
						if(m_ctrlMorphText.Text.Length == 0)
						{
							strMsg = ("You must supply morphing text when the selected method is " + O.ToString());
							bError = true;
						}	
						break;
						
					case RegMorphMethods.Offset:
					
						if(m_ctrlMorphText.Text.Length == 0)
						{
							strMsg = "You must supply morphing text when the selected method is Offset";
							bError = true;
						}
						else
						{
							try
							{
								System.Convert.ToInt64(m_ctrlMorphText.Text);
							}
							catch
							{
								strMsg = "You must supplya valid number when using Offset morphing";
								bError = true;
							}
						}
						break;
						
					case RegMorphMethods.None:
					default:
					
						break;
					
				}
				
			}
			
			//	Error with morph text?
			if(bError == true)
			{
				MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				m_ctrlMorphText.Focus();
				m_ctrlMorphText.SelectAll();
				return false;
			}
			
			//	Check the conflict resolution text supplied by the user
			if((O = GetSelection(m_ctrlConflictResolutions)) != null)
			{
				switch((RegConflictResolutions)O)
				{
					case RegConflictResolutions.Prefix:
					case RegConflictResolutions.Suffix:
					
						if(m_ctrlConflictText.Text.Length == 0)
						{
							strMsg = ("You must supply conflict resolution text when the selected method is " + O.ToString());
							bError = true;
						}
							
						break;
						
					case RegConflictResolutions.Automatic:
					case RegConflictResolutions.Prompt:
					default:
					
						break;
					
				}
				
			}
			
			//	Error with conflict resolution text?
			if(bError == true)
			{
				MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				m_ctrlConflictText.Focus();
				m_ctrlConflictText.SelectAll();
				return false;
			}

            //	Check if Custom DPI checked and Custom DPI value not set
            if (m_ctrlCustomDPICheck.Checked && m_ctrlCustomDPIMask.Text.Length == 0)
            {
                bError = true;
                strMsg = "Custom DPI cannot be empty when \"Export Out Custom DPI\" is checked";
            }

            //	Error in Custom DPI
            if (bError == true)
            {
                MessageBox.Show(strMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                m_ctrlCustomDPIMask.Focus();
                return false;
            }

			//	All is well ...
			return true;		

		}

		/// <summary>Traps events fired when the user changes the conflict resolution selection<\summary>
		/// <param name="sender">The object that fired the event</param>
		/// <param name="e">Event arguments</param>
		private void OnConflictSelChanged(object sender, System.EventArgs e)
		{
			int			iIndex;
			CTmaxOption	tmaxRegOption;
			string		strText = "Not Used:";
			bool		bEnabled = false;
			
			Debug.Assert(m_ctrlConflictResolutions != null);
			Debug.Assert(m_ctrlConflictResolutions.Items != null);
			if((m_ctrlConflictResolutions == null) || (m_ctrlConflictResolutions.Items == null)) return;

			for(iIndex = 0; iIndex < m_ctrlConflictResolutions.Items.Count; iIndex++)
			{
				if((tmaxRegOption = (CTmaxOption)m_ctrlConflictResolutions.Items[iIndex]) != null)
				{
					if(m_ctrlConflictResolutions.GetItemChecked(iIndex) == true)
					{
						switch((RegConflictResolutions)tmaxRegOption.Value)
						{
							case RegConflictResolutions.Suffix:
							
								strText = "Suffix:";
								bEnabled = true;
								break;
								
							case RegConflictResolutions.Prefix:
							
								strText = "Prefix:";
								bEnabled = true;
								break;
								
							default:
							
								break;
						}
								
						break;
					}
				}
			
			}// for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
			
				
			m_ctrlConflictTextLabel.Text = strText;
			m_ctrlConflictTextLabel.Enabled = bEnabled;
			m_ctrlConflictText.Enabled = bEnabled;
		}

		/// <summary>Traps events fired when the user changes the morph method selection<\summary>
		/// <param name="sender">The object that fired the event</param>
		/// <param name="e">Event arguments</param>
		private void OnMorphSelChanged(object sender, System.EventArgs e)
		{
			int			iIndex;
			CTmaxOption	tmaxRegOption;
			string		strText = "Not Used:";
			bool		bEnabled = false;
			
			Debug.Assert(m_ctrlMorphMethods != null);
			Debug.Assert(m_ctrlMorphMethods.Items != null);
			if((m_ctrlMorphMethods == null) || (m_ctrlMorphMethods.Items == null)) return;

			for(iIndex = 0; iIndex < m_ctrlMorphMethods.Items.Count; iIndex++)
			{
				if((tmaxRegOption = (CTmaxOption)m_ctrlMorphMethods.Items[iIndex]) != null)
				{
					if(m_ctrlMorphMethods.GetItemChecked(iIndex) == true)
					{
						switch((RegMorphMethods)tmaxRegOption.Value)
						{
							case RegMorphMethods.Offset:
							
								strText = "Offset:";
								bEnabled = true;
								break;
								
							case RegMorphMethods.Suffix:
							
								strText = "Suffix:";
								bEnabled = true;
								break;
								
							case RegMorphMethods.Prefix:
							
								strText = "Prefix:";
								bEnabled = true;
								break;
								
							default:
							
								break;
						}
								
						break;
					}
				}
			
			}// for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
				
			m_ctrlMorphTextLabel.Text = strText;
			m_ctrlMorphTextLabel.Enabled = bEnabled;
			m_ctrlMorphText.Enabled = bEnabled;
		}

		/// <summary>
		/// This method handles events fired when the user clicks on the OK button
		/// </summary>
		/// <param name="sender">Object firing the event</param>
		/// <param name="e">System event arguments</param>
		private void OnClickOk(object sender, System.EventArgs e)
		{
			//	Are the user specified values OK?
			if(Verify())
			{
				//	Get the current selections
				GetSelections();
				
				//	Close the dialog
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			
		}// OnClickOk()
		
		/// <summary>This method will use the selections in the list box to set the Selected property of all registration options</summary>
		/// <param name="ctrlListBox">List box containing the items to be queried</param>
		private void GetSelections(CheckedListBox ctrlListBox)
		{
			int			iIndex;
			CTmaxOption	tmaxRegOption;
			
			//	Set the file transfer selection
			if((ctrlListBox != null) && (ctrlListBox.Items != null))
			{
				for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
				{
					if((tmaxRegOption = (CTmaxOption)ctrlListBox.Items[iIndex]) != null)
					{
						tmaxRegOption.Selected = (ctrlListBox.GetItemChecked(iIndex) == true);
					}
				
				}// for(iIndex = 0; iIndex < ctrlListBox.Items.Count; iIndex++)
			
			}// if((ctrlListBox != null) && (ctrlListBox.Items != null))
			
		}// GetSelections()
		
		/// <summary>This method will retrieve the value of the current selection in the specified list box</summary>
		/// <param name="ctrlRadioList">Radio list box containing the items to be queried</param>
		/// <returns>The Value associated with the current selection</returns>
		private object GetSelection(CRadioListCtrl ctrlRadioList)
		{
			int			iIndex;
			CTmaxOption	tmaxRegOption;
			
			//	Set the file transfer selection
			if((ctrlRadioList != null) && (ctrlRadioList.Items != null))
			{
				for(iIndex = 0; iIndex < ctrlRadioList.Items.Count; iIndex++)
				{
					if(ctrlRadioList.GetItemChecked(iIndex) == true)
					{
						if((tmaxRegOption = (CTmaxOption)ctrlRadioList.Items[iIndex]) != null)
						{
							return tmaxRegOption.Value;
						}
					}
				
				}// for(iIndex = 0; iIndex < ctrlRadioList.Items.Count; iIndex++)
			
			}// if((ctrlRadioList != null) && (ctrlRadioList.Items != null))
			
			return null;
			
		}// private object GetSelection(CRadioListCtrl ctrlRadioList)

        /// <summary>This method will enable/disable CustomDPI Textbox when CustomDPI is Checked/Unchecked</summary>
        private void m_ctrlCustomDPICheck_CheckedChanged(object sender, EventArgs e)
        {
            m_ctrlCustomDPIMask.Enabled = !m_ctrlCustomDPIMask.Enabled;
            if (m_ctrlCustomDPIMask.Enabled)
            {
                m_ctrlCustomDPIMask.Focus();
                m_ctrlCustomDPIMask.SelectAll();
            }
        }

		#endregion Private Methods

		#region Properties
		
		/// <summary>Registration options associated with the form controls</summary>
		public CTmaxRegOptions Options
		{
			get { return m_tmaxRegOptions; }
			set { m_tmaxRegOptions = value; }
		}
		
		#endregion Properties

        private void m_ctrlBWRadio_Click(object sender, EventArgs e)
        {
            m_ctrlCustomDPIMask.Text = "300";
            m_ctrlDisableCustomDither.Enabled = true;
        }

        private void m_ctrlColorRadio_Click(object sender, EventArgs e)
        {
            m_ctrlCustomDPIMask.Text = "200";
            m_ctrlDisableCustomDither.Checked = false;
            m_ctrlDisableCustomDither.Enabled = false;
        }

        private void m_ctrlAutoDetectRadio_CheckedChanged(object sender, EventArgs e)
        {
            m_ctrlCustomDPIMask.Text = "300";
            m_ctrlDisableCustomDither.Enabled = true;
        }

        private void m_ctrlCustomDPIMask_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Int16 value = Convert.ToInt16(m_ctrlCustomDPIMask.Text);
                if (value < 0)
                {
                    m_ctrlCustomDPIMask.Text = "0";
                    m_ctrlCustomDPIMask.SelectAll();
                }
                else if (value > 500)
                {
                    m_ctrlCustomDPIMask.Text = "500";
                    m_ctrlCustomDPIMask.SelectAll();
                }
            }
            catch
            {

            }
        }


	}// CTmaxRegOptionsForm

}//	namespace FTI.Trialmax.Forms
