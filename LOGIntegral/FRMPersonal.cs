using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LOGIntegral
{
    public partial class FRMPersonal : Form
    {
        private LOGIMetodos metodos = new LOGIMetodos();
        private string sqlPersonal;
        private Int16 sexo;

        public FRMPersonal()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarLVPersonal(string query)
        {
            string nombre_apellido;

            try
            {
                metodos.LeerDatosBaseDatos(query);
                LVPersonal.Items.Clear();
                while (metodos.MyLectura.Read())
                {
                    if (metodos.MyLectura["sexo"].ToString() == "M")
                    {
                        sexo = 0;
                    }
                    else if (metodos.MyLectura["sexo"].ToString() == "F")
                    {
                        sexo = 1;
                    }
                    nombre_apellido = "";
                    if (metodos.MyLectura["prim_nombre"].ToString() != null)
                    {
                        nombre_apellido += metodos.MyLectura["prim_nombre"].ToString();
                    }
                    if (metodos.MyLectura["segu_nombre"].ToString() != null)
                    {
                        nombre_apellido += " " + metodos.MyLectura["segu_nombre"].ToString();
                    }

                    if (metodos.MyLectura["prim_apellido"].ToString() != null)
                    {
                        nombre_apellido += " " + metodos.MyLectura["prim_apellido"].ToString();
                    }

                    if (metodos.MyLectura["segu_apellido"].ToString() != null)
                    {
                        nombre_apellido += " " + metodos.MyLectura["segu_apellido"].ToString();
                    }
                    ListViewItem listView = new ListViewItem(nombre_apellido, sexo);
                    listView.SubItems.Add(metodos.MyLectura["tipo_documento"].ToString());
                    listView.SubItems.Add(metodos.MyLectura["documento"].ToString());
                    listView.SubItems.Add(metodos.MyLectura["area_trabajo"].ToString());
                    listView.SubItems.Add(metodos.MyLectura["cargo"].ToString());
                    listView.SubItems.Add(metodos.MyLectura["categoria"].ToString());
                    LVPersonal.Items.AddRange(new ListViewItem[] { listView });
                }
                metodos.MyConexion.Close();
                CHCargo.Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Capturado: " + ex.ToString(), "LOGIntegral", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LVPersonal_Click(object sender, EventArgs e)
        {
            string texto;
            string[] epp = new string[4];
            string[] kardex = new string[4];
            Int32 indice = LVPersonal.FocusedItem.Index;
            if (indice >= 0)
            {
                metodos.DocumentoPersonal = LVPersonal.Items[LVPersonal.FocusedItem.Index].SubItems[2].Text.ToString();
                sqlPersonal = "SELECT t_camisa, t_casaca, t_pantalon, t_calzado,laptop, celular_t, radio, herramientas, sexo, foto FROM personal WHERE documento = " + LVPersonal.Items[LVPersonal.FocusedItem.Index].SubItems[2].Text;
                metodos.LeerDatosBaseDatos(sqlPersonal);
                while (metodos.MyLectura.Read())
                {
                    if (metodos.MyLectura["t_camisa"].ToString() != null)
                    {
                        epp[0] = metodos.MyLectura["t_camisa"].ToString();
                    }
                    else
                    {
                        epp[0] = "N/A";
                    }
                    if (metodos.MyLectura["t_casaca"].ToString() != null)
                    {
                        epp[1] = metodos.MyLectura["t_casaca"].ToString();
                    }
                    else
                    {
                        epp[1] = "N/A";
                    }
                    if (metodos.MyLectura["t_pantalon"].ToString() != null)
                    {
                        epp[2] = metodos.MyLectura["t_pantalon"].ToString();
                    }
                    else
                    {
                        epp[2] = "N/A";
                    }
                    if (metodos.MyLectura["t_calzado"].ToString() != null)
                    {
                        epp[3] = metodos.MyLectura["t_calzado"].ToString();
                    }
                    else
                    {
                        epp[3] = "N/A";
                    }
                    if (metodos.MyLectura["laptop"].ToString() != null)
                    {
                        if (metodos.MyLectura["laptop"].ToString() == "True")
                        {
                            kardex[0] = "Si";
                        }
                        else
                        {
                            kardex[0] = "No";
                        }
                    }
                    else
                    {
                        kardex[0] = "No";
                    }
                    if (metodos.MyLectura["celular_t"].ToString() != null)
                    {
                        if (metodos.MyLectura["celular_t"].ToString() == "True")
                        {
                            kardex[1] = "Si";
                        }
                        else
                        {
                            kardex[1] = "No";
                        }
                    }
                    else
                    {
                        kardex[1] = "No";
                    }
                    if (metodos.MyLectura["radio"].ToString() != null)
                    {
                        if (metodos.MyLectura["radio"].ToString() == "True")
                        {
                            kardex[2] = "Si";
                        }
                        else
                        {
                            kardex[2] = "No";
                        }
                    }
                    else
                    {
                        kardex[2] = "No";
                    }
                    if (metodos.MyLectura["herramientas"].ToString() != null)
                    {
                        if (metodos.MyLectura["herramientas"].ToString() == "True")
                        {
                            kardex[3] = "Si";
                        }
                        else
                        {
                            kardex[3] = "No";
                        }
                    }
                    else
                    {
                        kardex[3] = "No";
                    }
                    if (metodos.MyLectura["sexo"].ToString() != null)
                    {
                        if (metodos.MyLectura["sexo"].ToString() == "M")
                        {
                            sexo = 0;
                        }
                        else if (metodos.MyLectura["sexo"].ToString() == "F")
                        {
                            sexo = 1;
                        }
                    }
                    else
                    {
                        sexo = 0;
                    }
                    if (metodos.MyLectura["foto"] is DBNull)
                    {
                        PBFoto.Image = (Bitmap)LOGIntegral.Properties.Resources.fondo;
                        PBFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                        PBFoto.Image = LOGIMetodos.ByteArrayToImage((byte[])metodos.MyLectura["foto"]);
                }
                metodos.MyConexion.Close();

                TVPersonal.BeginUpdate();
                TVPersonal.Nodes.Clear();
                texto = LVPersonal.Items[indice].SubItems[2].ToString();
                TreeNode tree = new TreeNode
                {
                    Text = LVPersonal.Items[indice].SubItems[0].Text,
                    ImageIndex = sexo,
                    SelectedImageIndex = sexo
                };
                TVPersonal.Nodes.Add(tree);
                TreeNode treeEPP = new TreeNode
                {
                    Text = "Tallas de EPPs",
                    ImageIndex = 10,
                    SelectedImageIndex = 10
                };
                TVPersonal.Nodes[0].Nodes.Add(treeEPP);
                TreeNode[] treeEPPs = new TreeNode[4];
                treeEPPs[0] = new TreeNode("Camisa: " + epp[0].ToString(), 2, 2);
                treeEPPs[1] = new TreeNode("Casaca: " + epp[1].ToString(), 3, 3);
                treeEPPs[2] = new TreeNode("Pantalon: " + epp[2].ToString(), 4, 4);
                treeEPPs[3] = new TreeNode("Botin: " + epp[3].ToString(), 5, 5);
                TVPersonal.Nodes[0].Nodes[0].Nodes.AddRange(treeEPPs);
                TreeNode treeKardex = new TreeNode
                {
                    Text = "KARDEX",
                    ImageIndex = 11,
                    SelectedImageIndex = 11
                };
                TVPersonal.Nodes[0].Nodes.Add(treeKardex);
                TreeNode[] treeEquipos = new TreeNode[4];
                treeEquipos[0] = new TreeNode("Laptop: " + kardex[0].ToString(), 6, 6);
                treeEquipos[1] = new TreeNode("Celular: " + kardex[1].ToString(), 7, 7);
                treeEquipos[2] = new TreeNode("Radio Portatil: " + kardex[2].ToString(), 8, 8);
                treeEquipos[3] = new TreeNode("Herramientas: " + kardex[3].ToString(), 9, 9);
                TVPersonal.Nodes[0].Nodes[1].Nodes.AddRange(treeEquipos);
                TVPersonal.EndUpdate();
                TVPersonal.ExpandAll();
                TVPersonal.SelectedNode = TVPersonal.Nodes[0];
                metodos.MyConexion.Close();
            }
        }

        private void TB_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (TB_buscar.Text.Length > 0)
                {
                    string buscar = TB_buscar.Text.Replace(" ", "*");
                    buscar = "*" + buscar.ToUpper() + "*";
                    CargarLVPersonal($"Select tipo_documento,documento,prim_nombre,segu_nombre,prim_apellido,segu_apellido,area_trabajo,cargo,sexo,categoria FROM personal WHERE MATCH(documento,prim_nombre,segu_nombre,prim_apellido,segu_apellido) AGAINST('{buscar}' IN BOOLEAN MODE)");
                }
                else
                    CargarLVPersonal("Select tipo_documento,documento,prim_nombre,segu_nombre,prim_apellido,segu_apellido,area_trabajo,cargo,sexo,categoria FROM personal");
            }
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            FRMEditarPersonal editarPersonal = new FRMEditarPersonal();
            editarPersonal.MdiParent = this.MdiParent;
            editarPersonal.Show();
        }

        private void FRMPersonal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void LVPersonal_DoubleClick(object sender, EventArgs e)
        {
            if (LVPersonal.Items[LVPersonal.FocusedItem.Index].SubItems[2].Text != "")
            {
                String NombreApellido;
                NombreApellido = LVPersonal.Items[LVPersonal.FocusedItem.Index].SubItems[2].Text + " " + LVPersonal.Items[LVPersonal.FocusedItem.Index].SubItems[0].Text;
                NombreApellido = NombreApellido.Replace("  ", " ").Trim();
                Clipboard.SetDataObject(NombreApellido);
            }
        }

        private void BActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            sqlPersonal = "Select tipo_documento, documento, prim_nombre, segu_nombre, prim_apellido, segu_apellido, area_trabajo, cargo, sexo, categoria FROM personal ORDER BY prim_nombre";
            if (metodos.ContarRegistro(sqlPersonal) > 0)
            {
                CargarLVPersonal(sqlPersonal);
            }
        }

        private void TB_buscar_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TB_buscar.Text))
            {
                TB_buscar.SelectionStart = 0;
                TB_buscar.SelectionLength = TB_buscar.Text.Length;
            }
        }

        private void FRMPersonal_Activated(object sender, EventArgs e)
        {
            ActualizarLista();
            FRMPrincipal fRMPrincipal = new FRMPrincipal();
            fRMPrincipal.TSSLMensaje.Text = Application.OpenForms.Count.ToString();
        }

        private void BConsumo_Click(object sender, EventArgs e)
        {
            FRMListConsumo listConsumo = new FRMListConsumo();
            listConsumo.MdiParent = this.MdiParent;
            listConsumo.Show();
        }
    }
}

