using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Threading;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Globalization;
using DevExpress.Utils;
using System.IO;


namespace MyDXApplication
{
    public partial class FormPrincipal : XtraForm
    {
        #region Variables Globales
        private volatile bool _shouldStop;
        private string _myConnectionString;
        private SqlConnection _myConnection;
        private List<Thread> _lstThreads = new List<Thread>();
        BindingList<BoletaEntidad> gridDataList = new BindingList<BoletaEntidad>();
        BindingList<PingResult> gridDataListPingResult = new BindingList<PingResult>();
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Funciones
        private void CargarThreats()
        {
            try
            {
                foreach(DataRow row in DsBasculas.Tables[0].Rows)
                {
                    if (row != null)
                    {
                        int idBascula = Convert.ToInt32(row["SipBecamo_BasculasId"]);
                        Bascula myBascula = ObtenerBascula(idBascula);
                        Thread scaleThread = new Thread(() => CallTcpClient(myBascula));

                        _lstThreads.Add(scaleThread);
                    }
                }

                StartMyThreads();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CargarThreats()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar()
        {
            try
            {
                GridViewMaestroBasculas.AddNewRow();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Agregar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Salvar()
        {
            try
            {
                DialogResult resultAdded = XtraMessageBox.Show("Esta seguro que desea salvar los datos ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                bool isNewScale = false;
                bool ifSaved = false;

                if (resultAdded == DialogResult.Yes)
                {
                    for (int i = 0; i < GridViewMaestroBasculas.RowCount; i++)
                    {
                        DataRow row = GridViewMaestroBasculas.GetDataRow(i);

                        if (row != null)
                        {
                            if (CheckRow(row, i + 1))
                            {
                                switch (row.RowState)
                                {
                                    case DataRowState.Added:
                                        
                                        OpenConnection();

                                        if (_myConnection.State == ConnectionState.Open)
                                        {
                                            string query = @" INSERT INTO SIPBECAMO_BASCULAS (Descripcion, DireccionIp, Ubicacion, Blt_Proceso, Blt_Periodo, 
                                                                                                    Blt_Bodega, Blt_Orden, Blt_Procede, Blt_Bloque, Blt_Calidad, Blt_Calidad_Interna, Marca) 
                                                              VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}') ";
                                            query = string.Format(query, MyStringConv(row["DESCRIPCION"]), MyStringConv(row["DIRECCIONIP"]), MyStringConv(row["Ubicacion"]), 
                                                                          MyStringConv(row["Blt_Proceso"]), MyStringConv(row["Blt_Periodo"]), 
                                                                           MyStringConv(row["Blt_Bodega"]), MyStringConv(row["Blt_Orden"]), 
                                                                            MyStringConv(row["Blt_Procede"]), MyStringConv(row["Blt_Bloque"]), 
                                                                             MyStringConv(row["Blt_Calidad"]), MyStringConv(row["Blt_Calidad_Interna"]),
                                                                              MyStringConv(row["Marca"]));

                                            SqlCommand command = new SqlCommand(query, _myConnection);
                                            command.ExecuteNonQuery();
                                        }

                                        ifSaved = true;
                                        isNewScale = true;
                                        _myConnection.Close();

                                        break;
                                    case DataRowState.Modified:
                                        
                                        OpenConnection();

                                        if (_myConnection.State == ConnectionState.Open)
                                        {
                                            string query = @" UPDATE SIPBECAMO_BASCULAS SET DESCRIPCION = '{0}', DIRECCIONIP = '{1}', UBICACION = '{2}', Blt_Proceso = '{3}', Blt_Periodo = '{4}', 
                                                                                                    Blt_Bodega = '{5}', Blt_Orden = '{6}', Blt_Procede = '{7}', Blt_Bloque = '{8}', Blt_Calidad = '{9}', 
                                                                                                     Blt_Calidad_Interna = '{10}', Marca = '{11}'
                                                              WHERE SIPBECAMO_BASCULASID = {12} ";
                                            query = string.Format(query, MyStringConv(row["DESCRIPCION"]), MyStringConv(row["DIRECCIONIP"]), 
                                                                          MyStringConv(row["Ubicacion"]), MyStringConv(row["Blt_Proceso"]), 
                                                                           MyStringConv(row["Blt_Periodo"]), MyStringConv(row["Blt_Bodega"]),
                                                                            MyStringConv(row["Blt_Orden"]), MyStringConv(row["Blt_Procede"]), 
                                                                             MyStringConv(row["Blt_Bloque"]), MyStringConv(row["Blt_Calidad"]), 
                                                                              MyStringConv(row["Blt_Calidad_Interna"]), MyStringConv(row["Marca"]),
                                                                               MyStringConv(row["SipBecamo_BasculasId"]));

                                            SqlCommand command = new SqlCommand(query, _myConnection);
                                            command.ExecuteNonQuery();
                                        }

                                        ifSaved = true;
                                        _myConnection.Close();

                                        break;
                                }
                            }
                        }
                    }

                    if (ifSaved)
                        XtraMessageBox.Show("Datos salvados satisfactoriamente!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(isNewScale)
                        XtraMessageBox.Show("Se han agregado nuevas basculas, por favor reinicie la aplicacion para poder monitorearlas!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarMaestroBasculas();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Salvar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Eliminar()
        {
            try
            {
                DataRow selectedRow = GridViewMaestroBasculas.GetDataRow(GridViewMaestroBasculas.FocusedRowHandle);

                if (selectedRow != null)
                {
                    DialogResult resultDeleted = XtraMessageBox.Show("Esta seguro que desea eliminar el item seleccionado ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultDeleted == DialogResult.Yes)
                    {
                        OpenConnection();

                        if (_myConnection.State == ConnectionState.Open)
                        {
                            string query = " DELETE FROM SIPBECAMO_BASCULAS WHERE SIPBECAMO_BASCULASID = {0} ";
                            query = string.Format(query, selectedRow["SIPBECAMO_BASCULASID"]);

                            SqlCommand command = new SqlCommand(query, _myConnection);
                            command.ExecuteNonQuery();
                        }

                        XtraMessageBox.Show("Registro eliminado satisfactoriamente!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _myConnection.Close();
                        CargarMaestroBasculas();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Eliminar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cancelar()
        {
            try
            {
                CargarMaestroBasculas();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion Cancelar()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarMaestroBasculas()
        {
            try
            {
                OpenConnection();

                if (_myConnection != null)
                {
                    if (_myConnection.State == ConnectionState.Open)
                    {
                        DataSet ds = new DataSet();
                        string query = @" SELECT SipBecamo_BasculasId, LTRIM(RTRIM(Descripcion)) AS Descripcion, 
                                                 LTRIM(RTRIM(DireccionIp)) AS DireccionIp, LTRIM(RTRIM(Ubicacion)) AS Ubicacion, 
                                                 LTRIM(RTRIM(Blt_Proceso)) AS Blt_Proceso, LTRIM(RTRIM(Blt_Periodo)) AS Blt_Periodo, 
                                                 LTRIM(RTRIM(Blt_Bodega)) AS Blt_Bodega, LTRIM(RTRIM(Blt_Orden)) AS Blt_Orden, 
                                                 LTRIM(RTRIM(Blt_Procede)) AS Blt_Procede, LTRIM(RTRIM(Blt_Bloque)) AS Blt_Bloque, 
                                                 LTRIM(RTRIM(Blt_Calidad)) AS Blt_Calidad, LTRIM(RTRIM(Blt_Calidad_Interna)) AS Blt_Calidad_Interna,
                                                 LTRIM(RTRIM(Marca)) AS Marca
                                          FROM SIPBECAMO_BASCULAS ";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _myConnection);

                        dataAdapter.Fill(ds);

                        DsBasculas.Clear();
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                            DsBasculas.Tables[0].Merge(ds.Tables[0]);


                        _myConnection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CargarMaestroBasculas()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarBasculas()
        {
            try
            {
                OpenConnection();

                if (_myConnection != null)
                {
                    if (_myConnection.State == ConnectionState.Open)
                    {
                        DataSet ds = new DataSet();
                        string query = @" SELECT DESCRIPCION, BLT_BODEGA FROM SIPBECAMO_BASCULAS ";
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _myConnection);

                        dataAdapter.Fill(ds);

                        //DsBasculas.Tables["TblReporte"].Clear();
                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            DataRow newRow = ds.Tables[0].NewRow();
                            newRow["DESCRIPCION"] = "TODOS";
                            newRow["BLT_BODEGA"] = "TODOS";
                            ds.Tables[0].Rows.Add(newRow);

                            basculaCmb.Properties.DataSource = ds.Tables[0];
                            basculaCmb.Properties.DisplayMember = "DESCRIPCION";

                            bodegaCmb.Properties.DataSource = ds.Tables[0];
                            bodegaCmb.Properties.DisplayMember = "BLT_BODEGA";
                        }

                        _myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CargarBasculas()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CallTcpClient(Bascula bascula)
        {
            while (!_shouldStop)
            {
                try
                {
                    // Create a TcpClient. 
                    // Note, for this client to work you need to have a TcpServer  
                    // connected to the same address as specified by the server, port 
                    // combination.                     
                    Int32 port = 4001;
                    Ping ping = new Ping();
                    string scaleIp = bascula.DireccionIp;

                    if (scaleIp != string.Empty && scaleIp != null)
                    {
                        PingReply pingResult = ping.Send(scaleIp);

                        if (pingResult.Status == IPStatus.Success)
                        {
                            TcpClient client = new TcpClient(scaleIp, port);

                            if (client.Connected)
                            {
                                // Translate the passed message into ASCII and store it as a Byte array.
                                //var data = System.Text.Encoding.ASCII.GetBytes("S");
                                // Get a client stream for reading and writing. 
                                // Stream stream = client.GetStream(); 
                                NetworkStream stream = client.GetStream();

                                // Send the message to the connected TcpServer. 
                                //stream.Write(data, 0, data.Length);

                                //MessageBox.Show("Sent: " + message);

                                // Receive the TcpServer.response. 
                                // Buffer to store the response bytes.

                                var data = new byte[128];

                                // String to store the response ASCII representation. 
                                string responseData = string.Empty;

                                // Read the first batch of the TcpServer response bytes. 
                                Int32 bytes = stream.Read(data, 0, data.Length);
                                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                                InsertScaleInfo(responseData, bascula);
                                //InsertPingResult(bascula, responseData);
                                //MessageBox.Show("Recieved: " + responseData);
                                //SetMemoText(responseData + "IP BASCULA: " + scaleIp + "   PUERTO: " + port + "   HORA: " + DateTime.Now);

                                // Close everything.
                                stream.Close();
                                client.Close();

                                
                            }
                        }
                        else
                        {
                            InsertPingResult(bascula, pingResult.Status.ToString());
                        }
                    }                    
                }
                catch (Exception ex) 
                {
                    if(!ex.Message.Contains("Ping"))
                        XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CallTcpClient()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InsertScaleInfo(string text, Bascula bs)
        {
            try
            {
                BoletaEntidad nuevaBoleta = null;

                // Conexion
                string localConnectionString = "Data Source={0}; Initial Catalog={1}; {2}";
                string user = Properties.Settings.Default.Usuario;
                string pass = Properties.Settings.Default.Contrasena;
                string isWA = Properties.Settings.Default.IsAutenticacionWindows;
                string strWindowsAutentication = (isWA == "Unchecked") ? "User ID=" + user + "; Password=" + pass + ";" : string.Empty;

                localConnectionString = string.Format(localConnectionString,
                                        Properties.Settings.Default.Servidor, Properties.Settings.Default.BD, strWindowsAutentication);


                SqlConnection localConnection = new SqlConnection(localConnectionString);
                localConnection.Open();

                if (localConnection.State == ConnectionState.Open)
                {
                    string gross = GetValorTipoPeso(bs.Marca, MyResource.Gross, text); //text.Substring(13, 7);
                    string tare = GetValorTipoPeso(bs.Marca, MyResource.Tare, text); //text.Substring(37, 6);
                    string net = GetValorTipoPeso(bs.Marca, MyResource.Net, text); //text.Substring(61, 6);
                    decimal grossDecimal = Convert.ToDecimal(gross);
                    decimal tareDecimal = Convert.ToDecimal(tare);
                    decimal netDecimal = Convert.ToDecimal(net);
                    string blt_Serie = bs.Blt_Proceso + bs.Blt_Periodo + bs.Blt_Bodega;
                    int correlativoBoleta = GetNumeroBoleta(blt_Serie);

                    // Para registrarlo en el GridView
                    nuevaBoleta = new BoletaEntidad()
                    {
                        Bascula = bs.Descripcion,
                        DireccionIp = bs.DireccionIp,
                        Fecha = DateTime.Now,
                        NumeroBoleta = correlativoBoleta,
                        SerieBoleta = blt_Serie,
                        Bruto = grossDecimal,
                        Tara = tareDecimal,
                        Neto = netDecimal
                    };

                    if (correlativoBoleta > 0)
                    {
                        string query = @" INSERT INTO SipBecamo_Boletas (Blt_Proceso, Blt_Periodo, Blt_Bodega, Blt_Serie, Blt_Numero, Blt_Fecha,
                                                                                Blt_Orden, Blt_Trilla, Blt_Procede, Blt_Bloque, Blt_Calidad, 
                                                                                    Blt_Calidad_Interna, Blt_Bruto, Blt_Tara, Blt_Neto)
                                          VALUES('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', 
                                                                                                                    {12}, {13}, {14}) ";
                        query = string.Format(query, bs.Blt_Proceso, bs.Blt_Periodo, bs.Blt_Bodega, blt_Serie, correlativoBoleta, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                    bs.Blt_Orden, "-----", bs.Blt_Procede, bs.Blt_Bloque, bs.Blt_Calidad, bs.Blt_Calidad_Interna,
                                                     Convert.ToDecimal(gross), Convert.ToDecimal(tare), Convert.ToDecimal(net));

                        SqlCommand command = new SqlCommand(query, localConnection);
                        command.ExecuteNonQuery();
                    }

                    // Inserto en el GridView
                    //lock (this)
                    //{
                    //    gridControl1.BeginInvoke(new MethodInvoker(delegate()
                    //    {
                    //        DataRow newRow = DsBasculas.Tables["TblMonitor"].NewRow();
                    //        newRow["BASCULA"] = bs.Descripcion;
                    //        newRow["DIRECCION_IP"] = bs.DireccionIp;
                    //        newRow["FECHA"] = DateTime.Now;
                    //        newRow["NUMERO_BOLETA"] = correlativoBoleta;
                    //        newRow["SERIE_BOLETA"] = blt_Serie;
                    //        newRow["BRUTO"] = grossDecimal;
                    //        newRow["TARA"] = tareDecimal;
                    //        newRow["NETO"] = netDecimal;
                    //        DsBasculas.Tables["TblMonitor"].Rows.Add(newRow);
                    //    }));
                    //}
                }

                localConnection.Close();

                // Inserto en el GridView
                lock (this)
                {
                    gridControl1.BeginInvoke(new MethodInvoker(delegate()
                    {
                        gridDataList.Add(nuevaBoleta);
                        gridControl1.DataSource = gridDataList;
                    }));
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion InsertScaleInfo()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertPingResult(Bascula bs, string pingResult)
        {
            try
            {
                // Conexion
                BoletaEntidad nuevaBoleta = null;
                string localConnectionString = "Data Source={0}; Initial Catalog={1}; {2}";
                string user = Properties.Settings.Default.Usuario;
                string pass = Properties.Settings.Default.Contrasena;
                string isWA = Properties.Settings.Default.IsAutenticacionWindows;
                string strWindowsAutentication = (isWA == "Unchecked") ? "User ID=" + user + "; Password=" + pass + ";" : string.Empty;

                localConnectionString = string.Format(localConnectionString,
                                        Properties.Settings.Default.Servidor, Properties.Settings.Default.BD, strWindowsAutentication);


                SqlConnection localConnection = new SqlConnection(localConnectionString);
                localConnection.Open();

                if (localConnection.State == ConnectionState.Open)
                {

                    int correlativoBoleta = GetNumeroBoleta("P1112B5");

                    nuevaBoleta = new BoletaEntidad()
                    {
                        Bascula = bs.Descripcion,
                        DireccionIp = bs.DireccionIp,
                        Fecha = DateTime.Now,
                        NumeroBoleta = correlativoBoleta,
                        SerieBoleta = "P1112B5",
                        Bruto = 100,
                        Tara = 11,
                        Neto = 89
                    };

                    if (correlativoBoleta > 0)
                    {
                        //SetCulture();
                        string query = @" INSERT INTO SipBecamo_Boletas (Blt_Proceso, Blt_Periodo, Blt_Bodega, Blt_Serie, Blt_Numero, Blt_Fecha,
                                                                                Blt_Orden, Blt_Trilla, Blt_Procede, Blt_Bloque, Blt_Calidad, 
                                                                                    Blt_Calidad_Interna, Blt_Bruto, Blt_Tara, Blt_Neto)
                                          VALUES('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', 
                                                                                                                    {12}, {13}, {14}) ";
                        query = string.Format(query, bs.Blt_Proceso, bs.Blt_Periodo, bs.Blt_Bodega, "P1112B5", correlativoBoleta, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                                    bs.Blt_Orden, "-----", pingResult.Trim(), bs.Blt_Bloque, bs.Blt_Calidad, bs.Blt_Calidad_Interna,
                                                     150, 11, 139);

                        SqlCommand command = new SqlCommand(query, localConnection);
                        command.ExecuteNonQuery();
                    }
                }

                localConnection.Close();

                // Inserto en el GridView
                lock (this)
                {
                    gridControl1.BeginInvoke(new MethodInvoker(delegate()
                    {
                        //SetCulture();
                        gridDataList.Add(nuevaBoleta);
                        gridControl1.DataSource = gridDataList;
                    }));
                }

                //lock (this)
                //{
                //    gridControl1.BeginInvoke(new MethodInvoker(delegate()
                //    {
                //        // Para registrarlo en el GridView
                //        DataRow newRow = DsBasculas.Tables["TblMonitor"].NewRow();
                //        newRow["BASCULA"] = bs.Descripcion;
                //        newRow["DIRECCION_IP"] = bs.DireccionIp;
                //        newRow["FECHA"] = DateTime.Now;
                //        newRow["SERIE_BOLETA"] = pingResult;
                //        newRow["BRUTO"] = Thread.CurrentThread.ManagedThreadId;
                //        DsBasculas.Tables["TblMonitor"].Rows.Add(newRow);
                //    }));

                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion InsertPingResult()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OpenConnection()
        {
            try
            {
                _myConnectionString = "Data Source={0}; Initial Catalog={1}; {2}";
                string user = Properties.Settings.Default.Usuario;
                string pass = Properties.Settings.Default.Contrasena;
                string isWA = Properties.Settings.Default.IsAutenticacionWindows;
                string strWindowsAutentication = (isWA == "Unchecked") ? "User ID=" + user + "; Password=" + pass + ";" : string.Empty;

                _myConnectionString = string.Format(_myConnectionString,
                                        Properties.Settings.Default.Servidor, Properties.Settings.Default.BD, strWindowsAutentication);

                if (Properties.Settings.Default.Servidor != string.Empty && Properties.Settings.Default.BD != string.Empty)
                {
                    _myConnection = new SqlConnection(_myConnectionString);
                    _myConnection.Open();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion OpenConnection()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void StartMyThreads()
        {
            foreach (Thread th in _lstThreads)
                th.Start();
        }
        private void AbortMyThreads()
        {
            foreach (Thread th in _lstThreads)
                th.Abort();
        }
        //private void SetCulture()
        //{
        //    try
        //    {
        //        Thread.CurrentThread.CurrentCulture = new CultureInfo("es-HN");
        //        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-HN");
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion SetCulture()", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void SetColumnsGridFormat()
        {
            try
            {
                gridViewMonitor.Columns["SerieBoleta"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["NumeroBoleta"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["Fecha"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["Bascula"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["DireccionIp"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["Bruto"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["Tara"].OptionsColumn.ReadOnly = true;
                gridViewMonitor.Columns["Neto"].OptionsColumn.ReadOnly = true;

                gridViewMonitor.Columns["Bruto"].DisplayFormat.FormatType = FormatType.Numeric;
                gridViewMonitor.Columns["Bruto"].DisplayFormat.FormatString = "n2";
                gridViewMonitor.Columns["Tara"].DisplayFormat.FormatType = FormatType.Numeric;
                gridViewMonitor.Columns["Tara"].DisplayFormat.FormatString = "n2";
                gridViewMonitor.Columns["Neto"].DisplayFormat.FormatType = FormatType.Numeric;
                gridViewMonitor.Columns["Neto"].DisplayFormat.FormatString = "n2";

                gridViewMonitor.Columns["Fecha"].DisplayFormat.FormatType = FormatType.DateTime;
                gridViewMonitor.Columns["Fecha"].DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion SetColumnsGridFormat()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarReporte()
        {
            try
            {
                if (CheckReporte())
                {
                    OpenConnection();

                    if (_myConnection != null)
                    {
                        if (_myConnection.State == ConnectionState.Open)
                        {
                            string str_bascula = string.Empty;
                            string str_bodega = string.Empty;
                            string str_desde = string.Empty;
                            string str_hasta = string.Empty;
                            DataSet ds = new DataSet();

                            string query = @" SELECT * FROM SipBecamo_Boletas BO
                                              INNER JOIN SipBecamo_Basculas BA ON (BA.Blt_Bodega = BO.Blt_Bodega)
                                              WHERE BO.BLT_FECHA BETWEEN '{0} 00:00' AND '{1} 23:59:59'
                                                    {2}
                                                    {3} 
                                              ORDER BY Blt_Fecha DESC ";

                            if (basculaCmb.Text != "TODOS")
                                str_bascula = "AND BA.DESCRIPCION = '" + basculaCmb.Text + "'";

                            if (bodegaCmb.Text != "TODOS")
                                str_bodega = "AND BO.BLT_BODEGA = '" + bodegaCmb.Text + "'";

                            //if (desdeDtp.DateTime.Date.ToString() != string.Empty && hastaDtp.DateTime.Date.ToString() != string.Empty)
                            //{
                            str_desde = desdeDtp.DateTime.ToString("yyyyMMdd");
                            str_hasta = hastaDtp.DateTime.ToString("yyyyMMdd");
                            //}

                            query = string.Format(query, str_desde, str_hasta, str_bascula, str_bodega);

                            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _myConnection);

                            dataAdapter.Fill(ds);

                            DsBasculas.Tables["TblReporte"].Clear();
                            if (ds != null && ds.Tables[0].Rows.Count > 0)
                                DsBasculas.Tables["TblReporte"].Merge(ds.Tables[0]);

                            _myConnection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CargarReporte()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarMarcas()
        {
            DataTable t = new DataTable();
            t.Columns.Add("MARCA_BASCULA");

            DataRow newRow1 = t.NewRow();
            newRow1[0] = "Revuelta";
            DataRow newRow2 = t.NewRow();
            newRow2[0] = "Mettler Toledo";

            t.Rows.Add(newRow1);
            t.Rows.Add(newRow2);

            cmbMarca.DataSource = t;
            cmbMarca.DisplayMember = "MARCA_BASCULA";
            cmbMarca.ValueMember = "MARCA_BASCULA";
        }

        private Bascula ObtenerBascula(int idBascula)
        {
            try
            {
                OpenConnection();

                if (_myConnection != null)
                {
                    if (_myConnection.State == ConnectionState.Open)
                    {
                        Bascula bs = null;
                        DataSet ds = new DataSet();
                        string query = "SELECT * FROM SIPBECAMO_BASCULAS WHERE SIPBECAMO_BASCULASID = " + idBascula;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _myConnection);

                        dataAdapter.Fill(ds);

                        if (ds != null && ds.Tables[0].Rows.Count > 0)
                        {
                            bs = new Bascula(Convert.ToInt32(ds.Tables[0].Rows[0]["SipBecamo_BasculasId"]), ds.Tables[0].Rows[0]["Descripcion"].ToString(), ds.Tables[0].Rows[0]["DireccionIp"].ToString(),
                                                ds.Tables[0].Rows[0]["Ubicacion"].ToString(), ds.Tables[0].Rows[0]["Blt_Proceso"].ToString(), ds.Tables[0].Rows[0]["Blt_Periodo"].ToString(),
                                                 ds.Tables[0].Rows[0]["Blt_Bodega"].ToString(), ds.Tables[0].Rows[0]["Blt_Orden"].ToString(), ds.Tables[0].Rows[0]["Blt_Procede"].ToString(),
                                                 ds.Tables[0].Rows[0]["Blt_Bloque"].ToString(), ds.Tables[0].Rows[0]["Blt_Calidad"].ToString(), ds.Tables[0].Rows[0]["Blt_Calidad_Interna"].ToString(),
                                                 ds.Tables[0].Rows[0]["Marca"].ToString());
                        }

                        _myConnection.Close();

                        return bs;
                    }
                }

                return new Bascula();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion ObtenerBascula()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private int GetNumeroBoleta(string blt_Serie)
        {
            try
            {
                string localConnectionString = "Data Source={0}; Initial Catalog={1}; {2}";
                string user = Properties.Settings.Default.Usuario;
                string pass = Properties.Settings.Default.Contrasena;
                string isWA = Properties.Settings.Default.IsAutenticacionWindows;
                string strWindowsAutentication = (isWA == "Unchecked") ? "User ID=" + user + "; Password=" + pass + ";" : string.Empty;

                localConnectionString = string.Format(localConnectionString,
                                        Properties.Settings.Default.Servidor, Properties.Settings.Default.BD, strWindowsAutentication);


                SqlConnection localConnection = new SqlConnection(localConnectionString);
                localConnection.Open();

                if (localConnection.State == ConnectionState.Open)
                {
                    DataSet ds = new DataSet();
                    string query = @" SELECT MAX(Blt_Numero) AS ULTIMA_BOLETA
                                      FROM SipBecamo_Boletas
                                      WHERE Blt_Serie = '" + blt_Serie + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _myConnection);

                    dataAdapter.Fill(ds);

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows[0]["ULTIMA_BOLETA"].ToString() != string.Empty)
                        return Convert.ToInt32(ds.Tables[0].Rows[0]["ULTIMA_BOLETA"]) + 1;

                    return 1; // Preguntar si este es el criterio a tomar en cuenta para el correlativo de boletas !!! OJOOOOOOOO
                }

                localConnection.Close();

                return -1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion GetNumeroBoleta()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private string MyStringConv(object obj)
        {
            return obj.ToString().Trim();
        }
        private string GetValorTipoPeso(string strMarca, string strTipoPeso, string scaleString)
        {
            try
            {
                string strValor = string.Empty;

                switch (strTipoPeso)
                {
                    case "Gross":
                        if (strMarca == MyResource.MettlerToledo)
                            strValor = scaleString.Substring(5, 5);
                        else
                            strValor = scaleString.Substring(13, 7); // Si es Revuelta
                    break;

                    case "Tare":
                        if (strMarca == MyResource.MettlerToledo)
                            strValor = scaleString.Substring(21, 5);
                        else
                            strValor = scaleString.Substring(37, 6); // Si es Revuelta
                    break;

                    case "Net":
                        if (strMarca == MyResource.MettlerToledo)
                            strValor = scaleString.Substring(37, 7);
                        else
                            strValor = scaleString.Substring(61, 6); // Si es Revuelta
                    break;
                }

                return strValor;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion GetValorTipoPeso()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private bool CheckRow(DataRow currentRow, int rowNum)
        {
            try
            {
                if (currentRow["DESCRIPCION"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("DESCRIPCION no puede ir vacio en fila [" + rowNum + "]!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (currentRow["DIRECCIONIP"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("DIRECCIONIP no puede ir vacio en fila [" + rowNum + "]!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (currentRow["UBICACION"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("UBICACION no puede ir vacio en fila [" + rowNum + "]!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (currentRow["MARCA"].ToString() == string.Empty)
                {
                    XtraMessageBox.Show("La MARCA no puede ir vacia para bascula en fila [" + rowNum + "]!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                //if (currentRow.RowState == DataRowState.Added)
                //{
                //    string query = "Descripcion = '{0}' OR DireccionIp = '{1}' OR Blt_Bodega = '{2}'";
                //    query = string.Format(query, currentRow["Descripcion"], currentRow["DireccionIp"], currentRow["Blt_Bodega"]);

                //    DataRow[] result = DsBasculas.Tables["TblBasculas"].Select(query);

                //    if (result.Length > 0)
                //    {
                //        string msj = "La bascula con Descripcion = {0}, Direccion IP = {1} y Bodega = {2} ya existe, estos campos no se pueden repetir.";
                //        msj = string.Format(msj, currentRow["Descripcion"], currentRow["DireccionIp"], currentRow["Blt_Bodega"]);

                //        XtraMessageBox.Show(msj, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //        return false;
                //    }
                //}

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CheckRow()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool CheckReporte()
        {
            try
            {
                if (basculaCmb.Text == "Seleccione una bascula...")
                {
                    XtraMessageBox.Show("Seleccione una bascula !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false; 
                }
                if (bodegaCmb.Text == "Seleccione una bodega...")
                {
                    XtraMessageBox.Show("Seleccione una bodega !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                if (desdeDtp.Text == string.Empty || hastaDtp.Text == string.Empty)
                {
                    XtraMessageBox.Show("Seleccione un rango de fecha valido !", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion CheckReporte()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Eventos Botones
        private void navBarControl_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraNavBar.NavBarControl mySender = (DevExpress.XtraNavBar.NavBarControl)sender;

                if (mySender.PressedGroup != null)
                {
                    switch (mySender.PressedGroup.Name)
                    {
                        case "monitorGroup":
                            myTabControl.SelectedTabPageIndex = 0;
                            break;

                        case "basculasGroup":
                            myTabControl.SelectedTabPageIndex = 1;
                            //CargarBasculas();
                            break;

                        case "reportesGroup":
                            myTabControl.SelectedTabPageIndex = 2;
                            CargarBasculas();
                            break;

                        case "salirGroup":
                            AbortMyThreads();
                            Application.Exit();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion navBarControl_Click()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void configuracionBtn_Click(object sender, EventArgs e)
        {
            FrmConfiguracion frm = new FrmConfiguracion();
            frm.ShowDialog();
        }        
        private void agregarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Agregar();
        }
        private void salvarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Salvar();
        }
        private void eliminarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Eliminar();
        }
        private void cancelarItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Cancelar();
        }
        private void exportarBtn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "Excel Workbook (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    gridViewReporte.ExportToXlsx(saveFileDialog1.FileName + ".xlsx");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error en funcion ExportToExcel()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarReporteBtn_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }
        #endregion

        #region Otros Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            //SetCulture();
            CargarMarcas();
            CargarMaestroBasculas();
            CargarThreats();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortMyThreads();
        }
        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            if (gridViewMonitor.Columns.Count > 0)
                SetColumnsGridFormat();
        }
        #endregion
    }
}