namespace CorreiosMonitor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCod = new MetroFramework.Controls.MetroTextBox();
            this.btnVerificar = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.gridDatas = new MetroFramework.Controls.MetroGrid();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorarCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.monitorador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            // 
            // 
            // 
            this.txtCod.CustomButton.Image = null;
            this.txtCod.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtCod.CustomButton.Name = "";
            this.txtCod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCod.CustomButton.TabIndex = 1;
            this.txtCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCod.CustomButton.UseSelectable = true;
            this.txtCod.CustomButton.Visible = false;
            this.txtCod.Lines = new string[0];
            this.txtCod.Location = new System.Drawing.Point(23, 63);
            this.txtCod.MaxLength = 32767;
            this.txtCod.Name = "txtCod";
            this.txtCod.PasswordChar = '\0';
            this.txtCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCod.SelectedText = "";
            this.txtCod.SelectionLength = 0;
            this.txtCod.SelectionStart = 0;
            this.txtCod.Size = new System.Drawing.Size(262, 23);
            this.txtCod.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtCod.TabIndex = 0;
            this.txtCod.UseSelectable = true;
            this.txtCod.WaterMark = "Cod Rastreio";
            this.txtCod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = null;
            this.btnVerificar.Location = new System.Drawing.Point(291, 63);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseSelectable = true;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // gridDatas
            // 
            this.gridDatas.AllowUserToResizeRows = false;
            this.gridDatas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDatas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDatas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDatas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDatas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Local,
            this.Situacao,
            this.Info});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDatas.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridDatas.EnableHeadersVisualStyles = false;
            this.gridDatas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDatas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDatas.Location = new System.Drawing.Point(23, 92);
            this.gridDatas.MultiSelect = false;
            this.gridDatas.Name = "gridDatas";
            this.gridDatas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDatas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridDatas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDatas.Size = new System.Drawing.Size(348, 150);
            this.gridDatas.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gridDatas.TabIndex = 2;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 54;
            // 
            // Local
            // 
            this.Local.HeaderText = "Local";
            this.Local.Name = "Local";
            this.Local.ReadOnly = true;
            this.Local.Width = 56;
            // 
            // Situacao
            // 
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 74;
            // 
            // spinner
            // 
            this.spinner.Location = new System.Drawing.Point(194, 31);
            this.spinner.Maximum = 100;
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(16, 16);
            this.spinner.Style = MetroFramework.MetroColorStyle.Yellow;
            this.spinner.TabIndex = 3;
            this.spinner.UseSelectable = true;
            this.spinner.Visible = false;
            // 
            // Info
            // 
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Width = 51;
            // 
            // monitorarCheckBox
            // 
            this.monitorarCheckBox.AutoSize = true;
            this.monitorarCheckBox.Location = new System.Drawing.Point(291, 42);
            this.monitorarCheckBox.Name = "monitorarCheckBox";
            this.monitorarCheckBox.Size = new System.Drawing.Size(76, 15);
            this.monitorarCheckBox.Style = MetroFramework.MetroColorStyle.Yellow;
            this.monitorarCheckBox.TabIndex = 4;
            this.monitorarCheckBox.Text = "Monitorar";
            this.monitorarCheckBox.UseSelectable = true;
            this.monitorarCheckBox.CheckedChanged += new System.EventHandler(this.monitorarCheckBox_CheckedChanged);
            // 
            // monitorador
            // 
            this.monitorador.Interval = 5000;
            this.monitorador.Tick += new System.EventHandler(this.monitorador_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 268);
            this.Controls.Add(this.monitorarCheckBox);
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.gridDatas);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Correios Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtCod;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnVerificar;
        private MetroFramework.Controls.MetroGrid gridDatas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Local;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private MetroFramework.Controls.MetroProgressSpinner spinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private MetroFramework.Controls.MetroCheckBox monitorarCheckBox;
        private System.Windows.Forms.Timer monitorador;
    }
}

