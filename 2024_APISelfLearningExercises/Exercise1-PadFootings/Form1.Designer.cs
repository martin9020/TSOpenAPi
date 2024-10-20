using System.Windows.Forms;

namespace PadFootingCreator
{
    partial class Form1 : Form
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
            this.SpacingXInput = new System.Windows.Forms.TextBox();
            this.LabelSpacingX = new System.Windows.Forms.Label();
            this.LabelSpacingY = new System.Windows.Forms.Label();
            this.SpacingYInput = new System.Windows.Forms.TextBox();
            this.NumPadsXInput = new System.Windows.Forms.TextBox();
            this.NumPadsYInput = new System.Windows.Forms.TextBox();
            this.InsertJobDescriptionButton = new System.Windows.Forms.Button();
            this.LabelNumberPadsX = new System.Windows.Forms.Label();
            this.LabelNumberPadsY = new System.Windows.Forms.Label();
            this.PostcodeText = new System.Windows.Forms.Label();
            this.LabelJobBuilder = new System.Windows.Forms.Label();
            this.JobPostCodeText = new System.Windows.Forms.TextBox();
            this.JobBuilderText = new System.Windows.Forms.TextBox();
            this.LabelJobName = new System.Windows.Forms.Label();
            this.JobNameText = new System.Windows.Forms.TextBox();
            this.LabelJobNumber = new System.Windows.Forms.Label();
            this.JobNumberText = new System.Windows.Forms.TextBox();
            this.LabelJobDesigner = new System.Windows.Forms.Label();
            this.JobDesignerText = new System.Windows.Forms.TextBox();
            this.LabelInfo1 = new System.Windows.Forms.Label();
            this.JobInfo1 = new System.Windows.Forms.TextBox();
            this.LabelJobDescription = new System.Windows.Forms.Label();
            this.JobDescription = new System.Windows.Forms.TextBox();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CreatePadFootingButton = new System.Windows.Forms.Button();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.LoadColumnSettings = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SpacingXInput
            // 
            this.SpacingXInput.BackColor = System.Drawing.Color.White;
            this.SpacingXInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpacingXInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SpacingXInput.ForeColor = System.Drawing.Color.Black;
            this.SpacingXInput.Location = new System.Drawing.Point(223, 29);
            this.SpacingXInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpacingXInput.Name = "SpacingXInput";
            this.SpacingXInput.Size = new System.Drawing.Size(124, 32);
            this.SpacingXInput.TabIndex = 1;
            this.SpacingXInput.Text = "1500";
            // 
            // LabelSpacingX
            // 
            this.LabelSpacingX.AutoSize = true;
            this.LabelSpacingX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelSpacingX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpacingX.ForeColor = System.Drawing.Color.White;
            this.LabelSpacingX.Location = new System.Drawing.Point(38, 29);
            this.LabelSpacingX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSpacingX.Name = "LabelSpacingX";
            this.LabelSpacingX.Size = new System.Drawing.Size(115, 30);
            this.LabelSpacingX.TabIndex = 2;
            this.LabelSpacingX.Text = "Spacing X";
            // 
            // LabelSpacingY
            // 
            this.LabelSpacingY.AutoSize = true;
            this.LabelSpacingY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelSpacingY.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelSpacingY.ForeColor = System.Drawing.Color.White;
            this.LabelSpacingY.Location = new System.Drawing.Point(38, 77);
            this.LabelSpacingY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelSpacingY.Name = "LabelSpacingY";
            this.LabelSpacingY.Size = new System.Drawing.Size(114, 30);
            this.LabelSpacingY.TabIndex = 4;
            this.LabelSpacingY.Text = "Spacing Y";
            // 
            // SpacingYInput
            // 
            this.SpacingYInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.SpacingYInput.Location = new System.Drawing.Point(223, 77);
            this.SpacingYInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SpacingYInput.Name = "SpacingYInput";
            this.SpacingYInput.Size = new System.Drawing.Size(124, 32);
            this.SpacingYInput.TabIndex = 3;
            this.SpacingYInput.Text = "3000";
            // 
            // NumPadsXInput
            // 
            this.NumPadsXInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.NumPadsXInput.Location = new System.Drawing.Point(289, 173);
            this.NumPadsXInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumPadsXInput.Name = "NumPadsXInput";
            this.NumPadsXInput.Size = new System.Drawing.Size(58, 32);
            this.NumPadsXInput.TabIndex = 5;
            this.NumPadsXInput.Text = "5";
            this.NumPadsXInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NumPadsYInput
            // 
            this.NumPadsYInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.NumPadsYInput.Location = new System.Drawing.Point(289, 221);
            this.NumPadsYInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NumPadsYInput.Name = "NumPadsYInput";
            this.NumPadsYInput.Size = new System.Drawing.Size(58, 32);
            this.NumPadsYInput.TabIndex = 6;
            this.NumPadsYInput.Text = "5";
            this.NumPadsYInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InsertJobDescriptionButton
            // 
            this.InsertJobDescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.InsertJobDescriptionButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.InsertJobDescriptionButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.InsertJobDescriptionButton.Location = new System.Drawing.Point(474, 364);
            this.InsertJobDescriptionButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.InsertJobDescriptionButton.Name = "InsertJobDescriptionButton";
            this.InsertJobDescriptionButton.Size = new System.Drawing.Size(252, 64);
            this.InsertJobDescriptionButton.TabIndex = 7;
            this.InsertJobDescriptionButton.Text = "Insert Job Description";
            this.InsertJobDescriptionButton.UseVisualStyleBackColor = false;
            this.InsertJobDescriptionButton.Click += new System.EventHandler(this.InsertJobDescription);
            // 
            // LabelNumberPadsX
            // 
            this.LabelNumberPadsX.AutoSize = true;
            this.LabelNumberPadsX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelNumberPadsX.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelNumberPadsX.ForeColor = System.Drawing.Color.White;
            this.LabelNumberPadsX.Location = new System.Drawing.Point(38, 173);
            this.LabelNumberPadsX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberPadsX.Name = "LabelNumberPadsX";
            this.LabelNumberPadsX.Size = new System.Drawing.Size(173, 30);
            this.LabelNumberPadsX.TabIndex = 8;
            this.LabelNumberPadsX.Text = "Number Pads X";
            // 
            // LabelNumberPadsY
            // 
            this.LabelNumberPadsY.AutoSize = true;
            this.LabelNumberPadsY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelNumberPadsY.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelNumberPadsY.ForeColor = System.Drawing.Color.White;
            this.LabelNumberPadsY.Location = new System.Drawing.Point(38, 221);
            this.LabelNumberPadsY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelNumberPadsY.Name = "LabelNumberPadsY";
            this.LabelNumberPadsY.Size = new System.Drawing.Size(172, 30);
            this.LabelNumberPadsY.TabIndex = 9;
            this.LabelNumberPadsY.Text = "Number Pads Y";
            // 
            // PostcodeText
            // 
            this.PostcodeText.AutoSize = true;
            this.PostcodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.PostcodeText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.PostcodeText.ForeColor = System.Drawing.Color.White;
            this.PostcodeText.Location = new System.Drawing.Point(469, 230);
            this.PostcodeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostcodeText.Name = "PostcodeText";
            this.PostcodeText.Size = new System.Drawing.Size(108, 30);
            this.PostcodeText.TabIndex = 17;
            this.PostcodeText.Text = "Postcode";
            // 
            // LabelJobBuilder
            // 
            this.LabelJobBuilder.AutoSize = true;
            this.LabelJobBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobBuilder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelJobBuilder.ForeColor = System.Drawing.Color.White;
            this.LabelJobBuilder.Location = new System.Drawing.Point(469, 120);
            this.LabelJobBuilder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobBuilder.Name = "LabelJobBuilder";
            this.LabelJobBuilder.Size = new System.Drawing.Size(87, 30);
            this.LabelJobBuilder.TabIndex = 16;
            this.LabelJobBuilder.Text = "Builder";
            // 
            // JobPostCodeText
            // 
            this.JobPostCodeText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobPostCodeText.Location = new System.Drawing.Point(809, 237);
            this.JobPostCodeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobPostCodeText.Name = "JobPostCodeText";
            this.JobPostCodeText.Size = new System.Drawing.Size(102, 30);
            this.JobPostCodeText.TabIndex = 15;
            this.JobPostCodeText.Text = "PostCode";
            this.JobPostCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // JobBuilderText
            // 
            this.JobBuilderText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobBuilderText.Location = new System.Drawing.Point(697, 118);
            this.JobBuilderText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobBuilderText.Name = "JobBuilderText";
            this.JobBuilderText.Size = new System.Drawing.Size(214, 30);
            this.JobBuilderText.TabIndex = 14;
            this.JobBuilderText.Text = "ProjectName";
            // 
            // LabelJobName
            // 
            this.LabelJobName.AutoSize = true;
            this.LabelJobName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelJobName.ForeColor = System.Drawing.Color.White;
            this.LabelJobName.Location = new System.Drawing.Point(469, 72);
            this.LabelJobName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobName.Name = "LabelJobName";
            this.LabelJobName.Size = new System.Drawing.Size(74, 30);
            this.LabelJobName.TabIndex = 13;
            this.LabelJobName.Text = "Name";
            // 
            // JobNameText
            // 
            this.JobNameText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobNameText.Location = new System.Drawing.Point(697, 75);
            this.JobNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobNameText.Name = "JobNameText";
            this.JobNameText.Size = new System.Drawing.Size(214, 30);
            this.JobNameText.TabIndex = 12;
            this.JobNameText.Text = "ProjectName";
            // 
            // LabelJobNumber
            // 
            this.LabelJobNumber.AutoSize = true;
            this.LabelJobNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobNumber.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelJobNumber.ForeColor = System.Drawing.Color.White;
            this.LabelJobNumber.Location = new System.Drawing.Point(469, 27);
            this.LabelJobNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobNumber.Name = "LabelJobNumber";
            this.LabelJobNumber.Size = new System.Drawing.Size(141, 30);
            this.LabelJobNumber.TabIndex = 11;
            this.LabelJobNumber.Text = "Job Number";
            // 
            // JobNumberText
            // 
            this.JobNumberText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobNumberText.Location = new System.Drawing.Point(697, 29);
            this.JobNumberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobNumberText.Name = "JobNumberText";
            this.JobNumberText.Size = new System.Drawing.Size(119, 30);
            this.JobNumberText.TabIndex = 10;
            this.JobNumberText.Text = "70xxxxx";
            // 
            // LabelJobDesigner
            // 
            this.LabelJobDesigner.AutoSize = true;
            this.LabelJobDesigner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobDesigner.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelJobDesigner.ForeColor = System.Drawing.Color.White;
            this.LabelJobDesigner.Location = new System.Drawing.Point(469, 185);
            this.LabelJobDesigner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobDesigner.Name = "LabelJobDesigner";
            this.LabelJobDesigner.Size = new System.Drawing.Size(182, 30);
            this.LabelJobDesigner.TabIndex = 19;
            this.LabelJobDesigner.Text = "Designer-Initials";
            // 
            // JobDesignerText
            // 
            this.JobDesignerText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobDesignerText.Location = new System.Drawing.Point(839, 193);
            this.JobDesignerText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobDesignerText.Name = "JobDesignerText";
            this.JobDesignerText.Size = new System.Drawing.Size(72, 30);
            this.JobDesignerText.TabIndex = 18;
            this.JobDesignerText.Text = "DesignerName";
            // 
            // LabelInfo1
            // 
            this.LabelInfo1.AutoSize = true;
            this.LabelInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelInfo1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelInfo1.ForeColor = System.Drawing.Color.White;
            this.LabelInfo1.Location = new System.Drawing.Point(469, 274);
            this.LabelInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInfo1.Name = "LabelInfo1";
            this.LabelInfo1.Size = new System.Drawing.Size(67, 30);
            this.LabelInfo1.TabIndex = 21;
            this.LabelInfo1.Text = "Info1";
            // 
            // JobInfo1
            // 
            this.JobInfo1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobInfo1.Location = new System.Drawing.Point(697, 281);
            this.JobInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobInfo1.Name = "JobInfo1";
            this.JobInfo1.Size = new System.Drawing.Size(214, 30);
            this.JobInfo1.TabIndex = 20;
            this.JobInfo1.Text = "Some Standard 2";
            // 
            // LabelJobDescription
            // 
            this.LabelJobDescription.AutoSize = true;
            this.LabelJobDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelJobDescription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelJobDescription.ForeColor = System.Drawing.Color.White;
            this.LabelJobDescription.Location = new System.Drawing.Point(469, 150);
            this.LabelJobDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelJobDescription.Name = "LabelJobDescription";
            this.LabelJobDescription.Size = new System.Drawing.Size(169, 30);
            this.LabelJobDescription.TabIndex = 23;
            this.LabelJobDescription.Text = "JobDescription";
            // 
            // JobDescription
            // 
            this.JobDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.JobDescription.Location = new System.Drawing.Point(697, 157);
            this.JobDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Size = new System.Drawing.Size(312, 30);
            this.JobDescription.TabIndex = 24;
            this.JobDescription.Text = "JobDescription";
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.LabelHeight.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.LabelHeight.ForeColor = System.Drawing.Color.White;
            this.LabelHeight.Location = new System.Drawing.Point(38, 125);
            this.LabelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(84, 30);
            this.LabelHeight.TabIndex = 26;
            this.LabelHeight.Text = "Height";
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.HeightInput.Location = new System.Drawing.Point(223, 125);
            this.HeightInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(124, 32);
            this.HeightInput.TabIndex = 25;
            this.HeightInput.Text = "1500";
            this.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1004, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(102, 33);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // CreatePadFootingButton
            // 
            this.CreatePadFootingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(21)))), ((int)(((byte)(36)))));
            this.CreatePadFootingButton.FlatAppearance.BorderSize = 0;
            this.CreatePadFootingButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.CreatePadFootingButton.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.CreatePadFootingButton.Location = new System.Drawing.Point(43, 359);
            this.CreatePadFootingButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(205, 75);
            this.CreatePadFootingButton.TabIndex = 0;
            this.CreatePadFootingButton.Text = "Insert \n Pads Cols Beams";
            this.CreatePadFootingButton.UseVisualStyleBackColor = false;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.Execute_OnButtonclick);
            // 
            // profileCatalog1
            // 
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.profileCatalog1.ButtonText = "albl_Select__";
            this.profileCatalog1.Location = new System.Drawing.Point(990, 301);
            this.profileCatalog1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(128, 29);
            this.profileCatalog1.TabIndex = 28;
            // 
            // LoadColumnSettings
            // 
            this.LoadColumnSettings.FormattingEnabled = true;
            this.LoadColumnSettings.Location = new System.Drawing.Point(795, 364);
            this.LoadColumnSettings.Name = "LoadColumnSettings";
            this.LoadColumnSettings.Size = new System.Drawing.Size(116, 33);
            this.LoadColumnSettings.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1229, 524);
            this.Controls.Add(this.LoadColumnSettings);
            this.Controls.Add(this.profileCatalog1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelHeight);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.JobDescription);
            this.Controls.Add(this.LabelJobDescription);
            this.Controls.Add(this.LabelInfo1);
            this.Controls.Add(this.JobInfo1);
            this.Controls.Add(this.LabelJobDesigner);
            this.Controls.Add(this.JobDesignerText);
            this.Controls.Add(this.PostcodeText);
            this.Controls.Add(this.LabelJobBuilder);
            this.Controls.Add(this.JobPostCodeText);
            this.Controls.Add(this.JobBuilderText);
            this.Controls.Add(this.LabelJobName);
            this.Controls.Add(this.JobNameText);
            this.Controls.Add(this.LabelJobNumber);
            this.Controls.Add(this.JobNumberText);
            this.Controls.Add(this.LabelNumberPadsY);
            this.Controls.Add(this.LabelNumberPadsX);
            this.Controls.Add(this.InsertJobDescriptionButton);
            this.Controls.Add(this.NumPadsYInput);
            this.Controls.Add(this.NumPadsXInput);
            this.Controls.Add(this.LabelSpacingY);
            this.Controls.Add(this.SpacingYInput);
            this.Controls.Add(this.LabelSpacingX);
            this.Controls.Add(this.SpacingXInput);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "Form1";
            this.Text = "API Exercise 1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SpacingXInput;
        private System.Windows.Forms.Label LabelSpacingX;
        private System.Windows.Forms.Label LabelSpacingY;
        private System.Windows.Forms.TextBox SpacingYInput;
        private System.Windows.Forms.TextBox NumPadsXInput;
        private System.Windows.Forms.TextBox NumPadsYInput;
        private System.Windows.Forms.Button InsertJobDescriptionButton;
        private System.Windows.Forms.Label LabelNumberPadsX;
        private System.Windows.Forms.Label LabelNumberPadsY;
        private System.Windows.Forms.Label PostcodeText;
        private System.Windows.Forms.Label LabelJobBuilder;
        private System.Windows.Forms.TextBox JobPostCodeText;
        private System.Windows.Forms.TextBox JobBuilderText;
        private System.Windows.Forms.Label LabelJobName;
        private System.Windows.Forms.TextBox JobNameText;
        private System.Windows.Forms.Label LabelJobNumber;
        private System.Windows.Forms.TextBox JobNumberText;
        private System.Windows.Forms.Label LabelJobDesigner;
        private System.Windows.Forms.TextBox JobDesignerText;
        private System.Windows.Forms.Label LabelInfo1;
        private System.Windows.Forms.TextBox JobInfo1;
        private System.Windows.Forms.Label LabelJobDescription;
        private System.Windows.Forms.TextBox JobDescription;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button CreatePadFootingButton;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private ComboBox LoadColumnSettings;
    }
}

