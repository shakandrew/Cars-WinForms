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
    public partial class ParentView : Form
    {
        public List<Car> cars { get; set; }

        public Car getCarByIndex(int index)
        {
            foreach(Car c in cars)
            {
                if (c.ID == index)
                {
                    return c;
                }
            }
            throw new NoSuchIndex();
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


        public ParentView()
        {
            InitializeComponent();
            cars = new List<Car>();
            cars.Add(new PAIN_Forms.Car(1, "Mazda", 180, 1999, CarType.Personal));
            cars.Add(new Car(2, "Tesla", 300, 2017, CarType.Truck));
            cars.Add(new Car(3, "Rower miejski", 15, 2017, CarType.Bike));
            CarView f = new CarView(this);
            f.MdiParent = this;
            f.ReloadData(cars);
            f.Show();
        }

        public void AddCar(Car c)
        {
            c.ID = cars.Count+1;
            cars.Add(c);
            foreach(CarView cv in MdiChildren)
            {
                cv.AddCar(c);
            }

        }

        public void EditCar(Car c)
        {
            foreach(Car uc in cars)
            {
                if(uc.ID == c.ID)
                {
                    uc.Brand = c.Brand;
                    uc.Type = c.Type;
                    uc.ProdYear = c.ProdYear;
                    uc.MaxVelocity = c.MaxVelocity;
                    break;
                }
            }
            foreach (CarView cv in MdiChildren)
            {
                cv.EditCar(c);
            }
        }

        public void DeleteCar(Car c)
        {
            foreach(Car uc in cars)
            {
                if(uc.ID == c.ID)
                {
                    cars.Remove(uc);
                    break;
                }
            }
            
            foreach(CarView cv in MdiChildren)
            {
                cv.DeleteCar(c);
            }
        }

        public void ReloadData(List<Car> c)
        {
            cars = c;
            foreach(CarView cv in MdiChildren)
            {
                cv.ReloadData(c);
            }
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarView f = new CarView(this);
            f.MdiParent = this;
            f.ReloadData(cars);
            f.Show();
        }

        private void ParentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ParentView_MdiChildActivate(object sender, EventArgs e)
        {
            ToolStripText = ((CarView)ActiveMdiChild).ToolStripText;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarView f = new CarView(this);
            f.MdiParent = this;
            f.ReloadData(cars);
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CarView f = (CarView)ActiveMdiChild;
            f.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            CarView f = (CarView)ActiveMdiChild;
            f.ShowAddDialog(CarType.Personal);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CarView f = (CarView)ActiveMdiChild;
            f.ShowAddDialog(CarType.Truck);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            CarView f = (CarView)ActiveMdiChild;
            f.ShowAddDialog(CarType.Bike);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            CarView f = (CarView)ActiveMdiChild;
            if(f.selectedCarIndex != null)
            {
                DeleteCar(new PAIN_Forms.Car((int)f.selectedCarIndex, String.Empty, 0, 0, CarType.Personal));
            }
            
        }
    }
    class NoSuchIndex : Exception { }
}
