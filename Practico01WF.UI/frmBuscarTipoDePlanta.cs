using Practico01WF.Entities;
using Practico01WF.Services.Servicios;
using Practico01WF.Services.Servicios.Facades;
using Practico01WF.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico01WF.UI
{
    public partial class frmBuscarTipoDePlanta : Form
    {
        public frmBuscarTipoDePlanta()
        {
            InitializeComponent();
        }

        private IServicioTipoDePlanta servicio;
        private List<IGrouping<int, Planta>> grupo;

        private void frmBuscarTipoDePlanta_Load(object sender, EventArgs e)
        {
            servicio = new ServicioTipoDePlanta();
            grupo = servicio.GetGrupos();
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            TreeNode mainNode = new TreeNode();
            mainNode.Name = "mainNode";
            mainNode.Text = "Main";
            ListaTvw.Nodes.Add(mainNode);
            foreach (var g in grupo)
            {
                var tipo = servicio.GetTipoDePlantaPorId(g.Key);
                TreeNode nodoTipo = new TreeNode($"{tipo.Descripcion} - Cantidad: {g.Count()}");
                nodoTipo.Tag = tipo;
                foreach (var planta in g)
                {
                    TreeNode nodoPlanta = new TreeNode($"{planta.Descripcion} - {planta.PrecioVenta}");
                    nodoPlanta.Tag = planta;
                    nodoTipo.Nodes.Add(nodoPlanta);
                }
                mainNode.Nodes.Add(nodoTipo);
            }

        }

        private void ListaTvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            switch (node.Level)
            {
                case 0:
                    HelperGrid.LimpiarGrilla(DatosDgv);
                    break;
                case 1:
                    TipoDePlanta tipoDePlanta =(TipoDePlanta) node.Tag;
                    var listaFiltrada = grupo[e.Node.Index].ToList();
                    PopulateGrid(listaFiltrada);
                    break;
                case 2:
                    Planta planta = (Planta)node.Tag;
                    SeleccionarFila(planta);
                    break;
                default:
                    break;
            }
        }

        private void SeleccionarFila(Planta planta)
        {
            foreach (DataGridViewRow r in DatosDgv.Rows)
            {
                Planta p =(Planta) r.Tag;
                if (p.Equals(planta))
                {
                    r.Selected = true;
                    break;
                }
            }
        }

        private void PopulateGrid(List<Planta> listaFiltrada)
        {
            HelperGrid.LimpiarGrilla(DatosDgv);
            foreach (var planta in listaFiltrada)
            {
                var r = HelperGrid.CrearFila(DatosDgv);
                HelperGrid.SetearFila(r,planta);
                HelperGrid.AgregarFila(r,DatosDgv);
            }
        }

        private void DatosDgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosDgv.CurrentRow!=null)
            {
                var r = DatosDgv.Rows[e.RowIndex];
                Planta planta = (Planta)r.Tag;
                TreeNode nodoSeleccionado = BuscarNodoNivelDos(planta);
                ListaTvw.HideSelection = false;
                ListaTvw.SelectedNode = nodoSeleccionado;
            }
        }

        private TreeNode BuscarNodoNivelDos(Planta planta)
        {
            foreach (TreeNode nodoTipo in ListaTvw.Nodes[0].Nodes)
            {
                foreach (TreeNode nodoPlanta in nodoTipo.Nodes)
                {
                    var plantaNodo = (Planta)nodoPlanta.Tag;
                    if (planta.Equals(plantaNodo))
                    {
                        return nodoPlanta;
                    }
                }
            }
            return null;
        }
    }
}
