using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eyeshot.ActionMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            List<Point3D> array = new List<Point3D>
            {
                new Point3D(0,60,0),
                new Point3D(0,40,5),
                new Point3D(0,20,+15),
                new Point3D(0,0,0)
            };

            Curve first = Curve.GlobalInterpolation(array, 3);
            Surface extrude = first.ExtrudeAsSurface(0, 0, 60)[0];

            design1.Entities.Add(extrude, Color.Teal);

            base.OnLoad(e);
        }


        private void btnActionMode_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {
                case "btnMagnifyingGlass":
                    design1.ActionMode = devDept.Eyeshot.actionType.MagnifyingGlass;
                    break;
                case "btnNone":
                    design1.ActionMode = devDept.Eyeshot.actionType.None;
                    break;
                case "btnPan":
                    design1.ActionMode = devDept.Eyeshot.actionType.Pan;
                    break;
                case "btnRotate":
                    design1.ActionMode = devDept.Eyeshot.actionType.Rotate;
                    break;
                case "btnSelectByBox":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectByBox;
                    break;
                case "btnSelectByBoxEnclosed":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectByBoxEnclosed;
                    break;
                case "btnSelectByPick":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectByPick;
                    break;
                case "btnSelectByPolygon":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectByPolygon;
                    break;
                case "btnSelectByPolygonEnclosed":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectByPolygonEnclosed;
                    break;
                case "btnSelectVisibleByBox":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByBox;
                    break;
                case "btnSelectVisibleByPick":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByPick;
                    break;
                case "btnSelectVisibleByPickDynamic":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByPickDynamic;
                    break;
                case "btnSelectVisibleByPickLabel":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByPickLabel;
                    break;
                case "btnSelectVisibleByPolygon":
                    design1.ActionMode = devDept.Eyeshot.actionType.SelectVisibleByPolygon;
                    break;
                case "btnZoom":
                    design1.ActionMode = devDept.Eyeshot.actionType.Zoom;
                    break;
                case "btnZoomWindow":
                    design1.ActionMode = devDept.Eyeshot.actionType.ZoomWindow;
                    break;
            }

            lbActionMode.Text = design1.ActionMode.ToString();
        }
    }
}
