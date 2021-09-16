using System.Windows.Forms;
using JARF.TableClasses;

namespace JARF.Controls
{
    public partial class ColumnDisplay : UserControl
    {
        public Column Column { get; set; }
        public ColumnDisplay(Column col)
        {
            InitializeComponent();
            this.Column = col;
            this.lblInfo.Text = col.Name;
        }

        public bool Selected => this.chkSelected.Checked;
    }
}
