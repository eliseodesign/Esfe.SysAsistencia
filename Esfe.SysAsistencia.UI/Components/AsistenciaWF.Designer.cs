﻿namespace Esfe.SysAsistencia.UI.Components
{
    partial class AsistenciaWF
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
            PanelAsistencia = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            cbxGrupo = new ComboBox();
            gridAsistencia = new DataGridView();
            txtTitle = new Label();
            PanelAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAsistencia).BeginInit();
            SuspendLayout();
            // 
            // PanelAsistencia
            // 
            PanelAsistencia.Controls.Add(flowLayoutPanel1);
            PanelAsistencia.Controls.Add(label2);
            PanelAsistencia.Controls.Add(cbxGrupo);
            PanelAsistencia.Controls.Add(gridAsistencia);
            PanelAsistencia.Controls.Add(txtTitle);
            PanelAsistencia.Dock = DockStyle.Fill;
            PanelAsistencia.ForeColor = Color.Black;
            PanelAsistencia.Location = new Point(0, 0);
            PanelAsistencia.Margin = new Padding(3, 2, 3, 2);
            PanelAsistencia.Name = "PanelAsistencia";
            PanelAsistencia.Size = new Size(719, 451);
            PanelAsistencia.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Green;
            flowLayoutPanel1.Location = new Point(382, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(330, 430);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Grupo:";
            // 
            // cbxGrupo
            // 
            cbxGrupo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbxGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGrupo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxGrupo.FormattingEnabled = true;
            cbxGrupo.Location = new Point(83, 92);
            cbxGrupo.Name = "cbxGrupo";
            cbxGrupo.Size = new Size(202, 29);
            cbxGrupo.TabIndex = 2;
            cbxGrupo.SelectedIndexChanged += cbxGrupo_SelectedIndexChanged;
            // 
            // gridAsistencia
            // 
            gridAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAsistencia.Location = new Point(12, 138);
            gridAsistencia.Name = "gridAsistencia";
            gridAsistencia.RowTemplate.Height = 25;
            gridAsistencia.Size = new Size(365, 301);
            gridAsistencia.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(12, 9);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(318, 37);
            txtTitle.TabIndex = 0;
            txtTitle.Text = "Formulario de Asistencia";
            // 
            // AsistenciaWF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 451);
            Controls.Add(PanelAsistencia);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AsistenciaWF";
            Text = "AsistenciaWF";
            PanelAsistencia.ResumeLayout(false);
            PanelAsistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridAsistencia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAsistencia;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox cbxGrupo;
        private DataGridView gridAsistencia;
        private Label txtTitle;
    }
}