using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonManagment.Pages.Sections
{
    public partial class supplier_form : Form
    {
        private DataTable _supplierTable;
        private BindingSource _bs;
        public supplier_form()
        {
            InitializeComponent();
            this.Load += supplier_form_Load;
            dataGridView1.AutoGenerateColumns = true;
        }
    
    private void supplier_form_Load(object sender, EventArgs e)
        {

            // 1) SQL’den veriyi çek
            _supplierTable = Database.GetAllSuppliers();

            // 2) BindingSource hazırla
            _bs = new BindingSource { DataSource = _supplierTable };

            // 3) DataGridView’e bağla
            dataGridView1.DataSource = _bs;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
