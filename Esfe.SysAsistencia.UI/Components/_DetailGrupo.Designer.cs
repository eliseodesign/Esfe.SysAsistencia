﻿namespace Esfe.SysAsistencia.UI.Components
{
    partial class _DetailGrupo
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
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            cbxTurno = new ComboBox();
            label2 = new Label();
            numEstudiantes = new NumericUpDown();
            label1 = new Label();
            cbxAño = new ComboBox();
            label7 = new Label();
            cbxCarrera = new ComboBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(168, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "_____  ______";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbxTurno);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numEstudiantes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbxAño);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbxCarrera);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.AppWorkspace;
            groupBox1.Location = new Point(12, 74);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(460, 288);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del grupo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(244, 123);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 25;
            label3.Text = "Turno";
            // 
            // cbxTurno
            // 
            cbxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTurno.FormattingEnabled = true;
            cbxTurno.Location = new Point(244, 153);
            cbxTurno.Margin = new Padding(3, 2, 3, 2);
            cbxTurno.Name = "cbxTurno";
            cbxTurno.Size = new Size(186, 26);
            cbxTurno.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(244, 43);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 23;
            label2.Text = "Estudiantes max.";
            // 
            // numEstudiantes
            // 
            numEstudiantes.Font = new Font("Lucida Sans Unicode", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numEstudiantes.Location = new Point(244, 78);
            numEstudiantes.Name = "numEstudiantes";
            numEstudiantes.Size = new Size(186, 27);
            numEstudiantes.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(18, 118);
            label1.Name = "label1";
            label1.Size = new Size(37, 18);
            label1.TabIndex = 21;
            label1.Text = "Año";
            // 
            // cbxAño
            // 
            cbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAño.FormattingEnabled = true;
            cbxAño.Location = new Point(18, 153);
            cbxAño.Margin = new Padding(3, 2, 3, 2);
            cbxAño.Name = "cbxAño";
            cbxAño.Size = new Size(186, 26);
            cbxAño.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(18, 43);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 17;
            label7.Text = "Carrera";
            // 
            // cbxCarrera
            // 
            cbxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarrera.FormattingEnabled = true;
            cbxCarrera.Location = new Point(18, 78);
            cbxCarrera.Margin = new Padding(3, 2, 3, 2);
            cbxCarrera.Name = "cbxCarrera";
            cbxCarrera.Size = new Size(186, 26);
            cbxCarrera.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = SystemColors.ControlDarkDark;
            btnGuardar.Location = new Point(115, 217);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 32);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = SystemColors.ControlDarkDark;
            btnEliminar.Location = new Point(18, 217);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 32);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // _DetailGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 400);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "_DetailGrupo";
            Text = "_DetailGrupo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private Label label2;
        private NumericUpDown numEstudiantes;
        private Label label1;
        private ComboBox cbxAño;
        private Label label7;
        private ComboBox cbxCarrera;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label3;
        private ComboBox cbxTurno;
    }
}