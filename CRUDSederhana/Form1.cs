using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {
        private string ConnectionString = "Data Source = MSI\\KEVINNADR;" + "Initial Catalog =OrganisasiMahasiswa;" + "Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

 