using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Forms
{
    public partial class CarView : Form, ICarViewer
    {
        ParentView parent;
        public CarsFilter currentFilter { get; set; }

        int CarImageIndex(Car c)
        {
            if(c.Type == CarType.Personal)
            {
                return 0;
            }
            else if(c.Type == CarType.Truck)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        bool before100(Car c)
        {
            return c.MaxVelocity < 100;
        }

        bool after100(Car c)
        {
            return !before100(c);
        }


        public CarView(ParentView parent_)
        {
            InitializeComponent();
            parent = parent_;
            currentFilter = IdentityFilter.get();
        }

        public String ToolStripText
        {
            get
            {
                return toolStripStatusLabel1.Text;
            }

            set
            {
                toolStripStatusLabel1.Text = value;
            }
        }

        public int? selectedCarIndex
        {
            get
            {
                if (listView1.SelectedItems.Count == 0)
                    return null;
                else
                    return int.Parse(listView1.SelectedItems[0].Name);
            }
        }

        public void ReloadData(List<Car> lc)
        {
            int count = 0;
            listView1.Items.Clear();
            listView1.SmallImageList = CarTypesImages;
            listView1.StateImageList = CarTypesImages;
            listView1.LargeImageList = CarTypesImages;
            foreach (Car c in lc)
            {
                if(currentFilter(c))
                {
                    listView1.Items.Add(c.ID.ToString(), c.ToString(), CarImageIndex(c));
                    count++;
                }
                
            }
            toolStripStatusLabel1.Text = count.ToString();
        }

        public void ShowAddDialog(CarType init)
        {
            CarAdd addDialog = new CarAdd(parent, (int)init);
            addDialog.ShowDialog();
        }

        public void ShowEditDialog()
        {
            CarEdit editDialog = new CarEdit(
                parent,
                parent.getCarByIndex(
                    int.Parse(listView1.SelectedItems[0].Name)
                )
            );
            editDialog.ShowDialog();
        }

        public void ShowDeleteDialog()
        {
            ShowEditDialog();
        }

        public void AddCar(Car c)
        {
            listView1.Items.Add(c.ID.ToString(), c.ToString(), CarImageIndex(c));
            if(currentFilter != IdentityFilter.get())
            {
                ReloadData(parent.cars);
            }
            else
            {
                int count = int.Parse(toolStripStatusLabel1.Text);
                toolStripStatusLabel1.Text = (++count).ToString();
            }
        }

        public void EditCar(Car c)
        {
            foreach(ListViewItem i in listView1.Items)
            {
                if(i.Name == c.ID.ToString())
                {
                    i.Text = c.ToString();
                    i.ImageIndex = CarImageIndex(c);
                }
            }
            if (currentFilter != IdentityFilter.get())
            {
                ReloadData(parent.cars);
            }
        }

        public void DeleteCar(Car c)
        {
            foreach (ListViewItem i in listView1.Items)
            {
                if (i.Name == c.ID.ToString())
                {
                    listView1.Items.Remove(i);
                }
            }
            if (currentFilter != IdentityFilter.get())
            {
                ReloadData(parent.cars);
            }
            else
            {
                int count = int.Parse(toolStripStatusLabel1.Text);
                toolStripStatusLabel1.Text = (--count).ToString();
            }
        }

        private void CarView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.ParentForm.MdiChildren.Count() == 1 && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                currentFilter = IdentityFilter.get();
                ReloadData(parent.cars);

            }
            else if(comboBox1.SelectedIndex == 1)
            {
                currentFilter = before100;
                ReloadData(parent.cars);
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                currentFilter = after100;
                ReloadData(parent.cars);
            }
            else { }
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            CarEdit editDialog = new CarEdit(
                parent, 
                parent.getCarByIndex(
                    int.Parse(listView1.SelectedItems[0].Name)
                )
            );
            editDialog.ShowDialog();

        }


        private void toolStripStatusLabel1_TextChanged(object sender, EventArgs e)
        {
            parent.ToolStripText = ToolStripText;
        }


        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                EditContextMenu.Show(Cursor.Position);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            CarEdit editDialog = new CarEdit(
                parent,
                parent.getCarByIndex(
                    int.Parse(listView1.SelectedItems[0].Name)
                )
            );
            editDialog.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Car c = new PAIN_Forms.Car(
                int.Parse(listView1.SelectedItems[0].Name),
                String.Empty,
                0,
                0,
                CarType.Personal
                );
            parent.DeleteCar(c);
        }


        private void PersonalCarStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent, 0);
            editDialog.ShowDialog();
        }

        private void TruckCarStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent, 1);
            editDialog.ShowDialog();
        }

        private void BikeStripMenuItem_Click(object sender, EventArgs e)
        {
            CarAdd editDialog = new CarAdd(parent, 2);
            editDialog.ShowDialog();
        }
    }
}
