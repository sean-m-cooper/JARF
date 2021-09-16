using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using JARF.TableClasses;

namespace JARF
{
    public partial class frmConnection : Form
    {
        public frmConnection()
        {
            InitializeComponent();
            setConnectionString();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            using (var cn = new SqlConnection(lblConnectionString.Text))
            {
                try
                {
                    lblConnectionStatus.Text = "";
                    Application.DoEvents();
                    cn.Open();
                    lblConnectionStatus.Text = "Database connected";
                    Application.DoEvents();
                    var cmd = new SqlCommand(JARFData.TableQuery, cn);
                    var reader = cmd.ExecuteXmlReader();
                    JARFData.TableDoc = XDocument.Load(reader);
                    JARFData.Tables = JARFData.TableDoc.Element("tables").Elements("table").Select(t => new TableDef(t)).ToList();
                    lblConnectionStatus.Text += Environment.NewLine + "Tables loaded.";

                    cmd.CommandText = JARFData.ViewQuery;
                    reader = cmd.ExecuteXmlReader();
                    JARFData.ViewDoc = XDocument.Load(reader);
                    JARFData.Views = JARFData.ViewDoc.Element("views").Elements("view").Select(v => new ViewDef(v)).ToList();
                    lblConnectionStatus.Text += Environment.NewLine + "Views loaded.";

                    cmdShowDesigner.Visible = true;
                }
                catch (Exception ex)
                {
                    lblConnectionStatus.Text = ex.Message;
                }

            }
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            setConnectionString();
        }

        private void txtDatabase_TextChanged(object sender, EventArgs e)
        {
            setConnectionString();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            setConnectionString();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            setConnectionString();
        }

        private void setConnectionString()
        {
            lblConnectionString.Text = string.Format(JARFData.ConStringFormat, txtServer.Text, txtDatabase.Text, txtUserName.Text, txtPassword.Text);
        }

        private void cmdShowDesigner_Click(object sender, EventArgs e)
        {
            var frmDesigner = new frmDesigner(this);
            frmDesigner.Show();
            this.Hide();
        }
    }
}
