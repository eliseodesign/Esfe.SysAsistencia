﻿using Esfe.SysAsistencia.BL;
using Esfe.SysAsistencia.UI.Helpers;
using Esfe.SysAsistencia.EN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Esfe.SysAsistencia.DAL;
using static DPFP.Verification.Verification;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Esfe.SysAsistencia.UI.Components
{
    /// <summary>
    //  La clase "AlumnosWF" es un formulario de Windows Forms que permite registrar 
    // y gestionar estudiantes en un sistema de asistencia.El formulario contiene
    // una serie de controles como cuadros de texto(txtNombres, txtApellidos, txtDui,
    // txtNit, txtTelefono), cuadros combinados(cbxCarrera, cbxGrupo), un botón de 
    // guardar(btnGuardar) 
    /// </summary>
    public partial class AlumnosWF : Form
    {
        //  -------------------------- Variables para el lector --------------------------
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        //  -------------------------- Variables para el lector --------------------------
        //Clase para las validaciones de campos
        ErrorProvider error = new ErrorProvider();
        DialogResult result = new DialogResult();


        int ID;

        public Panel _panel_app;
        public AlumnosWF(Panel panel)
        {
            _panel_app = panel;
            InitializeComponent();
            SetGridFormat();
            RefreshGrid();

            cbxCarrera.DataSource = State.InfoCarrera.carreras;

            
        }

        //Signals
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validacion de campos
            if (string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtDui.Text))
            {
                MessageBox.Show("Los datos son obligatorios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Template == null)
            {
                MessageBox.Show("Aún no se ha registrado una huella", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Creacion del Alumno
            var estudiante = new Estudiante()
            {
                Id = ID,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Cel = txtTelefono.Text,
                Dui = txtDui.Text,
                Nit = txtNit.Text,
                IdCarrera = cbxCarrera.SelectedValue.ToString(),
                Huella = Template.Bytes,
                CodigoGrupo = cbxGrupo.SelectedValue.ToString(),

            };
            if (ID == 0)
            {

                //Agregar alumno al BL
                var result = State.estudianteBL.AgregarEstudiante(estudiante);
                if (!result)
                {
                    MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RefreshGrid();
                    MessageBox.Show("Se regitró al estudiante de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                var result = State.estudianteBL.AgregarEstudiante(estudiante);
                if (!result)
                {
                    MessageBox.Show("No se puede registrar con la misma huella!", "ERROR GRAVE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RefreshGrid();
                    MessageBox.Show("Se edito el estudiante de forma exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            ID = 0;
        }

        //Refrescar Tabla
        void RefreshGrid()
        {
            var estudiantes = State.estudianteBL.ObtenerEstudiante();
            if (estudiantes.Count == 0) return; // si es cero, se retorna
            gridEstudiantes.DataSource = null;
            gridEstudiantes.DataSource = estudiantes;
        }

        //Darle formato a la tabla
        public void SetGridFormat()
        {
            gridEstudiantes.AutoGenerateColumns = false;

            gridEstudiantes.ColumnCount = 4;

            gridEstudiantes.Columns[0].Name = "ID";
            gridEstudiantes.Columns[0].DataPropertyName = "Id";
            gridEstudiantes.Columns[0].Width = 50;

            gridEstudiantes.Columns[1].Name = "Nombre";
            gridEstudiantes.Columns[1].DataPropertyName = "Nombres";
            gridEstudiantes.Columns[1].Width = 200;

            gridEstudiantes.Columns[2].Name = "Carrera";
            gridEstudiantes.Columns[2].DataPropertyName = "IdCarrera";
            gridEstudiantes.Columns[2].Width = 200;

            gridEstudiantes.Columns[3].Name = "Grupo";
            gridEstudiantes.Columns[3].DataPropertyName = "CodigoGrupo";
            gridEstudiantes.Columns[3].Width = 200;
        }

        //Abrir form para la huella
        private void btnChangeHuella_Click_1(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();  //crea un nuevo form para capturar la huella
        }

        //OnTemplate: Señal que se emite cuando se termina la captura de la huella

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnGuardar.Enabled = (Template != null);
                if (Template != null)
                {
                    //Comprobar si la huella existe->
                    if (!MySingleton.Instance.TemplateIsNull)
                    {
                        MessageBox.Show("La huella está lista.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MySingleton.Instance.TemplateIsNull = false;
                    MessageBox.Show("La huella no es valida.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }));
        }

        private void AlumnosWF_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string phone = txtTelefono.Text.Replace("-", "");

            if (System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{0,8}"))
            {
                if (phone.Length > 4 && phone.Length <= 8)
                {
                    txtTelefono.Text = phone.Substring(0, 4) + "-" + phone.Substring(4);
                    txtTelefono.SelectionStart = txtTelefono.Text.Length;
                }
                else
                {
                    txtTelefono.Text = phone;
                    txtTelefono.SelectionStart = txtTelefono.Text.Length;
                }
            }
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            string dui = txtDui.Text.Replace("-", "");
            if (System.Text.RegularExpressions.Regex.IsMatch(dui, @"^\d{0,9}"))
            {
                if (dui.Length > 8 && dui.Length <= 9)
                {
                    txtDui.Text = dui.Substring(0, 8) + "-" + dui.Substring(8);
                    txtDui.SelectionStart = txtDui.Text.Length;
                }
                else
                {
                    txtDui.Text = dui;
                    txtDui.SelectionStart = txtDui.Text.Length;
                }
            }
        }

        private void txtNit_TextChanged(object sender, EventArgs e)
        {

            string text = txtNit.Text.Replace("-", "");

            // Verificamos que el texto solo contenga números y no exceda los 9 dígitos
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d{0,14}"))
            {
                if (text.Length > 3 && text.Length <= 9)
                {
                    txtNit.Text = text.Substring(0, 4) + "-" + text.Substring(4);
                    txtNit.SelectionStart = txtNit.Text.Length;

                }

                else if (text.Length > 9 && text.Length <= 12)
                {
                    txtNit.Text = text.Substring(0, 4) + "-" + text.Substring(4, 6) + "-" + text.Substring(10);
                    txtNit.SelectionStart = txtNit.Text.Length;

                }


                else if (text.Length > 12)
                {
                    txtNit.Text = text.Substring(0, 4) + "-" + text.Substring(4, 6) + "-" + text.Substring(10, 3) + "-" + text.Substring(13);
                    txtNit.SelectionStart = txtNit.Text.Length;

                }


                else
                {
                    txtNit.Text = text; txtNit.SelectionStart = txtNit.Text.Length;

                }

            }
            else
            {
                txtNit.SelectionStart = txtNit.Text.Length;
            }
        }

        private void textBox_Press(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txt_KeyPress(txtBox, e);
        }

        private void txt_KeyPress(TextBox txtBox, KeyPressEventArgs e)
        {

            if (txtBox == txtTelefono)
            {
                bool phone = Verificar.validarNumeros(e);
                if (!phone)
                {
                    error.SetError(txtTelefono, "¡Solo números!");
                }
                else
                {
                    error.Clear();
                }
            }
            else if (txtBox == txtNombres || txtBox == txtApellidos)
            {
                bool name = Verificar.validarLetras(e);
                if (!name)
                {
                    error.SetError(txtBox, "¡Solo letras!");
                }
                else
                {
                    error.Clear();
                }
            }
            else if (txtBox == txtDui || txtBox == txtNit)
            {
                bool num = Verificar.validarNumeros(e);
                if (!num)
                {
                    error.SetError(txtBox, "¡Solo números!");
                }
                else
                {
                    error.Clear();
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ID <= 0)
            {
                result = MessageBox.Show("Primero Seleccione un alumno", "ERROR");
                return;
            }
            result = MessageBox.Show("¿Desea Eliminar este resgistro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Eliminar registros del datagriedview

                    bool eliminado = State.estudianteBL.EliminarEstudiante(ID);
                    if (eliminado == true)
                    {
                        MessageBox.Show("El estudiante a sido eliminado");
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar estudiante");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void gridDocentes_SelectionChanged(object sender, EventArgs e)
        {
            if (gridEstudiantes != null && gridEstudiantes.SelectedRows.Count > 0)
            {

                DataGridViewRow row = gridEstudiantes.SelectedRows[0];

                if (row != null)
                {

                    int id = Convert.ToInt32(row.Cells[0].Value);

                    //if (row.Cells[0].Value != null) ID = Convert.ToInt32(row.Cells[0].Value);
                    //if (row.Cells[1].Value != null) txtNombres.Text = row.Cells[1].Value.ToString();
                    //if (row.Cells[2].Value != null) txtApellidos.Text = row.Cells[2].Value.ToString();
                    //if (row.Cells[3].Value != null) txtTelefono.Text = row.Cells[3].Value.ToString();

                    var estudiante = State.estudianteBL.ObtenerEstudiante().FirstOrDefault(x => x.Id == id);
                    if (estudiante != null)
                    {
                        ID = id;
                        txtNombres.Text = estudiante.Nombres;
                        txtApellidos.Text = estudiante.Apellidos;
                        txtTelefono.Text = estudiante.Cel;
                        txtDui.Text = estudiante.Dui;
                        txtNit.Text = estudiante.Nit;
                        cbxCarrera.Text = estudiante.IdCarrera;
                        cbxGrupo.Text = estudiante.CodigoGrupo;



                    }
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            DgvDesing.Formato(gridEstudiantes, 1, false);
        }

        private void cbxCarrera_SelectedValueChanged(object sender, EventArgs e)
        {

            int indice = cbxCarrera.SelectedIndex;
            //if (indice != -1)
            //{
            var codigo = State.InfoCarrera.idCarrera[indice];


            var grupos = (from g in State.grupoBL.ObtenerGrupos()
                          where g.Carrera == codigo
                          select g.Codigo).ToList();

            cbxGrupo.DataSource = grupos;
        }



    }

    
}
