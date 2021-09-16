using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JARF.Controls;
using JARF.TableClasses;

namespace JARF
{
    public partial class frmDesigner : Form
    {
        Form parent;
        public frmDesigner(Form parentForm)
        {
            InitializeComponent();
            this.parent = parentForm;
        }

        private void frmDesigner_Load(object sender, EventArgs e)
        {
            frmDesigner_Resize(sender, e);
            tvTables.Nodes.Add("root");
            populateListBox();

        }

        private void populateListBox()
        {
            lstTables.Items.Clear();
            JARFData.Tables.Where(t => t.ShowInList == true).ToList().ForEach(t => lstTables.Items.Add(t.Name));
            JARFData.Views.ForEach(v => lstViews.Items.Add(v.Name));
        }

        private void frmDesigner_Resize(object sender, EventArgs e)
        {
            tabControlDBObjects.Height = this.Height - this.Padding.Top - this.Padding.Bottom;
            lstTables.Height = tabTables.Height - tabTables.Padding.Top - tabTables.Padding.Bottom;
            lstTables.Width = tabTables.Width - tabTables.Padding.Left - tabTables.Padding.Right;
            lstViews.Height = tabViews.Height - tabViews.Padding.Top - tabViews.Padding.Bottom;
            lstViews.Width = tabViews.Width - tabViews.Padding.Right - tabViews.Padding.Left;

            viewContainer.Width = this.Width - tabControlDBObjects.Width - this.Padding.Left - this.Padding.Right;
            viewContainer.Height = this.Height - this.Padding.Top - this.Padding.Bottom;

            tvTables.Width = viewContainer.Panel1.Width - 6;
            tvTables.Height = viewContainer.Height - 6;
        }

        private void tabControlDBObjects_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            TabPage tabPage = tabControlDBObjects.TabPages[e.Index];
            Rectangle _tabBounds = tabControlDBObjects.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }


            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(tabPage.Text, e.Font, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void frmDesigner_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.Show();
        }

        private void lstTables_DoubleClick(object sender, EventArgs e)
        {
            var tableName = lstTables.SelectedItem.ToString();
            var myTable = JARFData.Tables.FirstOrDefault(t => t.Name == tableName);
            var tableControl = new TableDisplay(myTable);
            tvTables.BeginUpdate();
            var selectedNode = tvTables.SelectedNode;
            if (selectedNode == null)
            {
                selectedNode = tvTables.Nodes[0];
            }

            TreeNode tableNode = new TreeNode(myTable.Name)
            {
                Name = myTable.ObjectId,
                Tag = myTable
            };
            tableNode.Nodes.AddRange(myTable.Columns.Select(c => new TreeNode(c.Name)
            {
                Name = c.ObjectId,
                Tag = c
            }).ToArray());

            selectedNode.Nodes.Add(tableNode);
            tableNode.Parent.Expand();
            tableNode.Expand();
            tvTables.EndUpdate();

            Helpers.ControlMover.Init(tableControl);
        }

        private void tvTables_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = e.Node;
            tvTables.SelectedNode = selectedNode;
            ctxTvTables.Enabled = true;
            if (e.Button == MouseButtons.Right)
            {
                if (selectedNode == null || selectedNode.Text == "root" || selectedNode.Tag.GetType() == typeof(Column))
                {
                    ctxTvTables.Enabled = false;
                    return;
                }

                if (selectedNode.Parent.Text == "root" && selectedNode.Parent.Nodes.IndexOf(selectedNode) == 0)
                {
                    ctxTvTables.Items["tsmMoveUp"].Enabled = false;
                    return;
                }
            }
        }

        private void tvTables_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    node.Checked = e.Node.Checked;
                }
            }
        }

        private void tsmMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void tsmMoveDown_Click(object sender, EventArgs e)
        {

        }

        private void tvTables_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            var selectedNode = tvTables.SelectedNode;

            tvTables.BeginUpdate();
            tvTables.Nodes.Remove(selectedNode);
            tvTables.EndUpdate();

            populateListBox();
        }
    }
}
