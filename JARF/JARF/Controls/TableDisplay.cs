using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using JARF.TableClasses;

namespace JARF.Controls
{
    public partial class TableDisplay : UserControl
    {
        public TableDef Table { get; set; }
        public TableDisplay(TableDef table)
        {
            
            InitializeComponent();
            
            this.Table = table;
            var cols = this.Table.Columns.Select(c => new ColumnDisplay(c)).ToList();
            this.lblTableName.Text = this.Table.Name;
            //this.Height = 30 + this.Table.Columns.Count > 5 ? 150 : this.Table.Columns.Count * 30;
            this.Height = 30 + (this.Table.Columns.Count * 20);

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Height = this.Height - 30;
            foreach (var col in cols)
            {
                switch (cols.IndexOf(col) % 2)
                {
                    case 1:
                        col.BackColor = Color.LightSkyBlue;
                        break;
                    case 2:
                        col.BackColor = Color.Wheat;
                        break;
                    default:
                        col.BackColor = Color.White;
                        break;
                }
                flowLayoutPanel1.Controls.Add(col);
            }
        }
    }
}
