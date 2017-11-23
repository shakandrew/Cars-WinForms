using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIN_Forms
{
    public partial class CarTypeChooser : UserControl
    {
        public event CarTypeChangedHandler typeChanged;

        int imageIndex_;
        public int imageIndex
        {
            get
            {
                return imageIndex_;
            }

            set
            {
                if(value != imageIndex)
                {
                    imageIndex_ = value;
                    pictureBox1.Image = imageList1.Images[imageIndex];
                    typeChanged?.Invoke(this, new CarTypeChanged(value));
                }
                
            }
        }

        public CarType choosedType
        {
            get
            {
                if (imageIndex == 0)
                {
                    return CarType.Personal;
                }
                else if (imageIndex == 1)
                {
                    return CarType.Truck;

                }
                else if (imageIndex == 2)
                {
                    return CarType.Bike;
                }
                else throw new UnknownCarType();
            }
        }
        
        public CarTypeChooser()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
            imageIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageIndex = (imageIndex + 1) % 3;
            pictureBox1.Image = imageList1.Images[imageIndex];
        }
    }

    public class CarTypeChanged : EventArgs
    {
        public int newIndex { get; set; }
        public string newType { get; set; }

        public CarTypeChanged(int newIndex_)
        {
            newIndex = newIndex_;
            newType = choosedType(newIndex_).ToString();
        }

        private CarType choosedType(int index)
        {
            if (index == 0)
            {
                return CarType.Personal;
            }
            else if (index == 1)
            {
                return CarType.Truck;

            }
            else if (index == 2)
            {
                return CarType.Bike;
            }
            else throw new UnknownCarType();
        }

    }

    public delegate void CarTypeChangedHandler(object sender, CarTypeChanged args);


    class UnknownCarType : Exception { }
}
