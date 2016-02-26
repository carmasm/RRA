using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace MyDXApplication
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        #region Funciones
        private void Cargar()
        {
            try
            {
                servidorTxt.Text = Properties.Settings.Default.Servidor;
                bDText.Text = Properties.Settings.Default.BD;
                usuarioTxt.Text = Properties.Settings.Default.Usuario;
                contrasenaTxt.Text = Properties.Settings.Default.Contrasena;
                WindowsAutenticationChk.CheckState = GetCheckState(Properties.Settings.Default.IsAutenticacionWindows);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Cargar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Salvar()
        {
            try
            {
                if (ValidarCampos())
                {
                    DialogResult result = XtraMessageBox.Show("Esta seguro que desea guardar los datos ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        Properties.Settings.Default.Servidor = servidorTxt.Text;
                        Properties.Settings.Default.BD = bDText.Text;
                        Properties.Settings.Default.Usuario = usuarioTxt.Text;
                        Properties.Settings.Default.Contrasena = contrasenaTxt.Text;
                        Properties.Settings.Default.IsAutenticacionWindows = WindowsAutenticationChk.CheckState.ToString();

                        Properties.Settings.Default.Save();
                        XtraMessageBox.Show("Datos guardados satisfactoriamente!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clean();
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Salvar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Clean()
        {
            servidorTxt.Text = string.Empty;
            bDText.Text = string.Empty;
            usuarioTxt.Text = string.Empty;
            contrasenaTxt.Text = string.Empty;
            WindowsAutenticationChk.CheckState = CheckState.Unchecked;
        }
        private void TestConnection()
        {
            try
            {
                if (ValidarCampos())
                {
                    string localConnectionString = "Data Source={0}; Initial Catalog={1}; {2}";
                    string strWindowsAutentication = (WindowsAutenticationChk.CheckState.ToString() == "Unchecked") ? "User ID=" + usuarioTxt.Text + "; Password=" + contrasenaTxt.Text + ";" : string.Empty;

                    localConnectionString = string.Format(localConnectionString,
                                            servidorTxt.Text, bDText.Text, strWindowsAutentication);


                    SqlConnection localConnection = new SqlConnection(localConnectionString);
                    localConnection.Open();

                    if (localConnection.State == ConnectionState.Open)
                        XtraMessageBox.Show("Conexion exitosa !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("No se pudo conectar con el servidor, la conexion no esta abierta !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("No se pudo conectar con el servidor: " + ex.Message, "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private CheckState GetCheckState(string checkState)
        {
            switch(checkState)
            {
                case "Checked":
                    return CheckState.Checked;
                case "Unchecked":
                    return CheckState.Unchecked;
            }

            return CheckState.Unchecked;
        }

        private bool ValidarCampos()
        {
            try
            {
                if (servidorTxt.Text == string.Empty)
                {
                    XtraMessageBox.Show("Servidor no puede ir vacio!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (bDText.Text == string.Empty)
                {
                    XtraMessageBox.Show("Base de Datos no puede ir vacio!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (usuarioTxt.Text == string.Empty && WindowsAutenticationChk.CheckState == CheckState.Unchecked)
                {
                    XtraMessageBox.Show("Usuario no puede ir vacio!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (contrasenaTxt.Text == string.Empty && WindowsAutenticationChk.CheckState == CheckState.Unchecked)
                {
                    XtraMessageBox.Show("Contraseña no puede ir vacia!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion ValidarCampos()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eventos
        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void WindowsAutenticationChk_CheckedChanged(object sender, EventArgs e)
        {
            switch (WindowsAutenticationChk.CheckState)
            {
                case CheckState.Checked:
                    usuarioTxt.Text = string.Empty;
                    contrasenaTxt.Text = string.Empty;
                    usuarioTxt.Enabled = false;
                    contrasenaTxt.Enabled = false;
                    break;
                case CheckState.Unchecked:
                    usuarioTxt.Enabled = true;
                    contrasenaTxt.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Eventos Botones
        private void CancelarBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        private void TestBtn_Click(object sender, EventArgs e)
        {
            TestConnection();
        }
        #endregion
    }
}
