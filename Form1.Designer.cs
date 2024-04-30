
namespace Eyeshot.ActionMode
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            devDept.Eyeshot.Control.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.Control.CancelToolBarButton("Cancel", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ProgressBar progressBar1 = new devDept.Eyeshot.Control.ProgressBar(devDept.Eyeshot.Control.ProgressBar.styleType.Speedometer, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, 0.333D, true);
            devDept.Eyeshot.Control.BackgroundSettings backgroundSettings1 = new devDept.Eyeshot.Control.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), 0.75D, null, devDept.Eyeshot.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Eyeshot.projectionType.Perspective, 40D, 4.94000002527272D, false, 0.001D);
            devDept.Eyeshot.Control.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.Control.HomeToolBarButton("Home", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.Control.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.Control.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.Control.ZoomToolBarButton("Zoom", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.Control.PanToolBarButton("Pan", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.Control.RotateToolBarButton("Rotate", devDept.Eyeshot.Control.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.Control.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.Control.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.Control.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.Control.ToolBar toolBar1 = new devDept.Eyeshot.Control.ToolBar(devDept.Eyeshot.Control.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.Control.ToolBarButton[] {
            ((devDept.Eyeshot.Control.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.Control.ToolBarButton)(zoomFitToolBarButton1))}, 5, 0, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 0D);
            devDept.Eyeshot.Control.Legend legend1 = new devDept.Eyeshot.Control.Legend(0D, 100D, "Title", "Subtitle", new System.Drawing.Point(24, 24), new System.Drawing.Size(10, 30), true, false, false, "{0:+0.###;-0.###;0}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, null, null, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(127))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))}, true, false);
            devDept.Eyeshot.Control.Histogram histogram1 = new devDept.Eyeshot.Control.Histogram(30, 80, "Title", System.Drawing.Color.Blue, System.Drawing.Color.Gray, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.LightYellow, false, true, false, "{0:+0.###;-0.###;0}");
            devDept.Eyeshot.Control.Grid grid1 = new devDept.Eyeshot.Control.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.Control.OriginSymbol originSymbol1 = new devDept.Eyeshot.Control.OriginSymbol(10, devDept.Eyeshot.Control.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.Control.RotateSettings rotateSettings1 = new devDept.Eyeshot.Control.RotateSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.Control.ZoomSettings zoomSettings1 = new devDept.Eyeshot.Control.ZoomSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.Control.PanSettings panSettings1 = new devDept.Eyeshot.Control.PanSettings(new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Middle, devDept.Eyeshot.Control.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.Control.NavigationSettings navigationSettings1 = new devDept.Eyeshot.Control.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.Control.MouseButton(devDept.Eyeshot.Control.mouseButtonsZPR.Left, devDept.Eyeshot.Control.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Control.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.Control.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.Control.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.Control.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.Control.ViewCubeIcon(devDept.Eyeshot.Control.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D), true);
            devDept.Eyeshot.Control.Viewport viewport1 = new devDept.Eyeshot.Control.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(517, 494), backgroundSettings1, camera1, new devDept.Eyeshot.Control.ToolBar[] {
            toolBar1}, new devDept.Eyeshot.Control.Legend[] {
            legend1}, histogram1, devDept.Eyeshot.displayType.Rendered, true, false, false, new devDept.Eyeshot.Control.Grid[] {
            grid1}, new devDept.Eyeshot.Control.OriginSymbol[] {
            originSymbol1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, coordinateSystemIcon1, viewCubeIcon1, devDept.Eyeshot.viewType.Trimetric);
            this.design1 = new devDept.Eyeshot.Control.Design();
            this.btnMagnifyingGlass = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnSelectByBox = new System.Windows.Forms.Button();
            this.btnSelectByBoxEnclosed = new System.Windows.Forms.Button();
            this.btnSelectByPick = new System.Windows.Forms.Button();
            this.btnSelectByPolygon = new System.Windows.Forms.Button();
            this.btnSelectByPolygonEnclosed = new System.Windows.Forms.Button();
            this.btnSelectVisibleByBox = new System.Windows.Forms.Button();
            this.btnSelectVisibleByPick = new System.Windows.Forms.Button();
            this.btnSelectVisibleByPickDynamic = new System.Windows.Forms.Button();
            this.btnSelectVisibleByPickLabel = new System.Windows.Forms.Button();
            this.btnSelectVisibleByPolygon = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnZoomWindow = new System.Windows.Forms.Button();
            this.lbActionMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.design1)).BeginInit();
            this.SuspendLayout();
            // 
            // design1
            // 
            this.design1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.design1.Cursor = System.Windows.Forms.Cursors.Default;
            this.design1.Location = new System.Drawing.Point(12, 12);
            this.design1.Name = "design1";
            this.design1.ProgressBar = progressBar1;
            this.design1.Size = new System.Drawing.Size(517, 494);
            this.design1.TabIndex = 0;
            this.design1.Text = "design1";
            this.design1.Viewports.Add(viewport1);
            // 
            // btnMagnifyingGlass
            // 
            this.btnMagnifyingGlass.Location = new System.Drawing.Point(535, 41);
            this.btnMagnifyingGlass.Name = "btnMagnifyingGlass";
            this.btnMagnifyingGlass.Size = new System.Drawing.Size(253, 23);
            this.btnMagnifyingGlass.TabIndex = 1;
            this.btnMagnifyingGlass.Text = "MagnifyingGlass";
            this.btnMagnifyingGlass.UseVisualStyleBackColor = true;
            this.btnMagnifyingGlass.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(535, 12);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(253, 23);
            this.btnNone.TabIndex = 2;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(535, 70);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(253, 23);
            this.btnPan.TabIndex = 3;
            this.btnPan.Text = "Pan";
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(535, 99);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(253, 23);
            this.btnRotate.TabIndex = 4;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectByBox
            // 
            this.btnSelectByBox.Location = new System.Drawing.Point(535, 128);
            this.btnSelectByBox.Name = "btnSelectByBox";
            this.btnSelectByBox.Size = new System.Drawing.Size(253, 23);
            this.btnSelectByBox.TabIndex = 5;
            this.btnSelectByBox.Text = "SelectByBox";
            this.btnSelectByBox.UseVisualStyleBackColor = true;
            this.btnSelectByBox.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectByBoxEnclosed
            // 
            this.btnSelectByBoxEnclosed.Location = new System.Drawing.Point(535, 157);
            this.btnSelectByBoxEnclosed.Name = "btnSelectByBoxEnclosed";
            this.btnSelectByBoxEnclosed.Size = new System.Drawing.Size(253, 23);
            this.btnSelectByBoxEnclosed.TabIndex = 6;
            this.btnSelectByBoxEnclosed.Text = "SelectByBoxEnclosed";
            this.btnSelectByBoxEnclosed.UseVisualStyleBackColor = true;
            this.btnSelectByBoxEnclosed.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectByPick
            // 
            this.btnSelectByPick.Location = new System.Drawing.Point(535, 186);
            this.btnSelectByPick.Name = "btnSelectByPick";
            this.btnSelectByPick.Size = new System.Drawing.Size(253, 23);
            this.btnSelectByPick.TabIndex = 7;
            this.btnSelectByPick.Text = "SelectByPick";
            this.btnSelectByPick.UseVisualStyleBackColor = true;
            this.btnSelectByPick.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectByPolygon
            // 
            this.btnSelectByPolygon.Location = new System.Drawing.Point(535, 215);
            this.btnSelectByPolygon.Name = "btnSelectByPolygon";
            this.btnSelectByPolygon.Size = new System.Drawing.Size(253, 23);
            this.btnSelectByPolygon.TabIndex = 8;
            this.btnSelectByPolygon.Text = "SelectByPolygon";
            this.btnSelectByPolygon.UseVisualStyleBackColor = true;
            this.btnSelectByPolygon.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectByPolygonEnclosed
            // 
            this.btnSelectByPolygonEnclosed.Location = new System.Drawing.Point(535, 244);
            this.btnSelectByPolygonEnclosed.Name = "btnSelectByPolygonEnclosed";
            this.btnSelectByPolygonEnclosed.Size = new System.Drawing.Size(253, 23);
            this.btnSelectByPolygonEnclosed.TabIndex = 9;
            this.btnSelectByPolygonEnclosed.Text = "SelectByPolygonEnclosed";
            this.btnSelectByPolygonEnclosed.UseVisualStyleBackColor = true;
            this.btnSelectByPolygonEnclosed.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectVisibleByBox
            // 
            this.btnSelectVisibleByBox.Location = new System.Drawing.Point(535, 273);
            this.btnSelectVisibleByBox.Name = "btnSelectVisibleByBox";
            this.btnSelectVisibleByBox.Size = new System.Drawing.Size(253, 23);
            this.btnSelectVisibleByBox.TabIndex = 10;
            this.btnSelectVisibleByBox.Text = "SelectVisibleByBox";
            this.btnSelectVisibleByBox.UseVisualStyleBackColor = true;
            this.btnSelectVisibleByBox.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectVisibleByPick
            // 
            this.btnSelectVisibleByPick.Location = new System.Drawing.Point(535, 302);
            this.btnSelectVisibleByPick.Name = "btnSelectVisibleByPick";
            this.btnSelectVisibleByPick.Size = new System.Drawing.Size(253, 23);
            this.btnSelectVisibleByPick.TabIndex = 11;
            this.btnSelectVisibleByPick.Text = "SelectVisibleByPick";
            this.btnSelectVisibleByPick.UseVisualStyleBackColor = true;
            this.btnSelectVisibleByPick.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectVisibleByPickDynamic
            // 
            this.btnSelectVisibleByPickDynamic.Location = new System.Drawing.Point(535, 331);
            this.btnSelectVisibleByPickDynamic.Name = "btnSelectVisibleByPickDynamic";
            this.btnSelectVisibleByPickDynamic.Size = new System.Drawing.Size(253, 23);
            this.btnSelectVisibleByPickDynamic.TabIndex = 12;
            this.btnSelectVisibleByPickDynamic.Text = "SelectVisibleByPickDynamic";
            this.btnSelectVisibleByPickDynamic.UseVisualStyleBackColor = true;
            this.btnSelectVisibleByPickDynamic.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectVisibleByPickLabel
            // 
            this.btnSelectVisibleByPickLabel.Location = new System.Drawing.Point(535, 360);
            this.btnSelectVisibleByPickLabel.Name = "btnSelectVisibleByPickLabel";
            this.btnSelectVisibleByPickLabel.Size = new System.Drawing.Size(253, 23);
            this.btnSelectVisibleByPickLabel.TabIndex = 13;
            this.btnSelectVisibleByPickLabel.Text = "SelectVisibleByPickLabel";
            this.btnSelectVisibleByPickLabel.UseVisualStyleBackColor = true;
            this.btnSelectVisibleByPickLabel.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnSelectVisibleByPolygon
            // 
            this.btnSelectVisibleByPolygon.Location = new System.Drawing.Point(535, 389);
            this.btnSelectVisibleByPolygon.Name = "btnSelectVisibleByPolygon";
            this.btnSelectVisibleByPolygon.Size = new System.Drawing.Size(253, 23);
            this.btnSelectVisibleByPolygon.TabIndex = 14;
            this.btnSelectVisibleByPolygon.Text = "SelectVisibleByPolygon";
            this.btnSelectVisibleByPolygon.UseVisualStyleBackColor = true;
            this.btnSelectVisibleByPolygon.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(535, 418);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(253, 23);
            this.btnZoom.TabIndex = 15;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // btnZoomWindow
            // 
            this.btnZoomWindow.Location = new System.Drawing.Point(535, 447);
            this.btnZoomWindow.Name = "btnZoomWindow";
            this.btnZoomWindow.Size = new System.Drawing.Size(253, 23);
            this.btnZoomWindow.TabIndex = 16;
            this.btnZoomWindow.Text = "ZoomWindow";
            this.btnZoomWindow.UseVisualStyleBackColor = true;
            this.btnZoomWindow.Click += new System.EventHandler(this.btnActionMode_Click);
            // 
            // lbActionMode
            // 
            this.lbActionMode.AutoSize = true;
            this.lbActionMode.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbActionMode.Location = new System.Drawing.Point(535, 491);
            this.lbActionMode.Name = "lbActionMode";
            this.lbActionMode.Size = new System.Drawing.Size(44, 15);
            this.lbActionMode.TabIndex = 17;
            this.lbActionMode.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lbActionMode);
            this.Controls.Add(this.btnZoomWindow);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnSelectVisibleByPolygon);
            this.Controls.Add(this.btnSelectVisibleByPickLabel);
            this.Controls.Add(this.btnSelectVisibleByPickDynamic);
            this.Controls.Add(this.btnSelectVisibleByPick);
            this.Controls.Add(this.btnSelectVisibleByBox);
            this.Controls.Add(this.btnSelectByPolygonEnclosed);
            this.Controls.Add(this.btnSelectByPolygon);
            this.Controls.Add(this.btnSelectByPick);
            this.Controls.Add(this.btnSelectByBoxEnclosed);
            this.Controls.Add(this.btnSelectByBox);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnPan);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.btnMagnifyingGlass);
            this.Controls.Add(this.design1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.design1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private devDept.Eyeshot.Control.Design design1;
        private System.Windows.Forms.Button btnMagnifyingGlass;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnSelectByBox;
        private System.Windows.Forms.Button btnSelectByBoxEnclosed;
        private System.Windows.Forms.Button btnSelectByPick;
        private System.Windows.Forms.Button btnSelectByPolygon;
        private System.Windows.Forms.Button btnSelectByPolygonEnclosed;
        private System.Windows.Forms.Button btnSelectVisibleByBox;
        private System.Windows.Forms.Button btnSelectVisibleByPick;
        private System.Windows.Forms.Button btnSelectVisibleByPickDynamic;
        private System.Windows.Forms.Button btnSelectVisibleByPickLabel;
        private System.Windows.Forms.Button btnSelectVisibleByPolygon;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnZoomWindow;
        private System.Windows.Forms.Label lbActionMode;
    }
}

