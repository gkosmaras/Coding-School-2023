using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static DevExpress.Utils.Svg.CommonSvgImages;

namespace Session_11 {
    public partial class EntryPoint : Form {

        /*DevExpress.XtraGrid.GridControl gridControl;
        DevExpress.XtraGrid.Views.Grid.GridView gridView;*/


        
        public CoffeeShopData Data { get; set; }
        private CoffeeShopData _CoffeeShopData = new CoffeeShopData();
        Serializer serializer = new Serializer();

        public EntryPoint() {
            InitializeComponent();

        }

        public object LoadJson(string file)
        {
            object employees = serializer.DeserializeFromFile<CoffeeShopData>(file);
            return employees;

        }
        private void btnManager_Click(object sender, EventArgs e) {
            this.Hide();
            Form1 form1 = new Form1(_CoffeeShopData);
            form1.Show(); 

        }

        private void btnCustomer_Click(object sender, EventArgs e) {
            
            this.Hide();

            CustomerForm customer = new CustomerForm(_CoffeeShopData);
            customer.Show();

            
        }

        public void btnLoadJson(object sender, EventArgs e)
        {
            if (File.Exists("test1.json"))
            {
                _CoffeeShopData = (CoffeeShopData)LoadJson("test1.json");
            }


        }
        private void EntryPoint_Load(object sender, EventArgs e) {
            if (File.Exists("test1.json"))
            {
                _CoffeeShopData = (CoffeeShopData)LoadJson("test1.json");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
