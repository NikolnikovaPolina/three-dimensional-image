namespace _2eab
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.figureRepresentation = new System.Windows.Forms.PictureBox();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.camera = new System.Windows.Forms.GroupBox();
            this.textViewingAngle = new System.Windows.Forms.NumericUpDown();
            this.viewingAngle = new System.Windows.Forms.Label();
            this.textCameraDirection = new System.Windows.Forms.TextBox();
            this.textCameraPosition = new System.Windows.Forms.TextBox();
            this.cameraDirection = new System.Windows.Forms.Label();
            this.cameraPosition = new System.Windows.Forms.Label();
            this.cone = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.lightingSource = new System.Windows.Forms.GroupBox();
            this.lightingCoordinates = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.figureRepresentation)).BeginInit();
            this.camera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textViewingAngle)).BeginInit();
            this.cone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            this.lightingSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // figureRepresentation
            // 
            this.figureRepresentation.BackColor = System.Drawing.Color.White;
            this.figureRepresentation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.figureRepresentation.Location = new System.Drawing.Point(0, 0);
            this.figureRepresentation.Margin = new System.Windows.Forms.Padding(4);
            this.figureRepresentation.Name = "figureRepresentation";
            this.figureRepresentation.Size = new System.Drawing.Size(876, 578);
            this.figureRepresentation.TabIndex = 0;
            this.figureRepresentation.TabStop = false;
            // 
            // buttonPaint
            // 
            this.buttonPaint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPaint.Location = new System.Drawing.Point(16, 435);
            this.buttonPaint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(85, 28);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.Text = "Рисовать";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // camera
            // 
            this.camera.Controls.Add(this.textViewingAngle);
            this.camera.Controls.Add(this.viewingAngle);
            this.camera.Controls.Add(this.textCameraDirection);
            this.camera.Controls.Add(this.textCameraPosition);
            this.camera.Controls.Add(this.cameraDirection);
            this.camera.Controls.Add(this.cameraPosition);
            this.camera.Location = new System.Drawing.Point(16, 15);
            this.camera.Margin = new System.Windows.Forms.Padding(4);
            this.camera.Name = "camera";
            this.camera.Padding = new System.Windows.Forms.Padding(4);
            this.camera.Size = new System.Drawing.Size(187, 174);
            this.camera.TabIndex = 2;
            this.camera.TabStop = false;
            this.camera.Text = "Камера";
            // 
            // textViewingAngle
            // 
            this.textViewingAngle.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textViewingAngle.Location = new System.Drawing.Point(12, 142);
            this.textViewingAngle.Margin = new System.Windows.Forms.Padding(4);
            this.textViewingAngle.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.textViewingAngle.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textViewingAngle.Name = "textViewingAngle";
            this.textViewingAngle.Size = new System.Drawing.Size(160, 22);
            this.textViewingAngle.TabIndex = 5;
            this.textViewingAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // viewingAngle
            // 
            this.viewingAngle.AutoSize = true;
            this.viewingAngle.Location = new System.Drawing.Point(8, 123);
            this.viewingAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewingAngle.Name = "viewingAngle";
            this.viewingAngle.Size = new System.Drawing.Size(89, 16);
            this.viewingAngle.TabIndex = 4;
            this.viewingAngle.Text = "Угол обзора";
            // 
            // textCameraDirection
            // 
            this.textCameraDirection.Location = new System.Drawing.Point(12, 87);
            this.textCameraDirection.Margin = new System.Windows.Forms.Padding(4);
            this.textCameraDirection.Name = "textCameraDirection";
            this.textCameraDirection.Size = new System.Drawing.Size(160, 22);
            this.textCameraDirection.TabIndex = 3;
            this.textCameraDirection.Text = "0 0 0";
            // 
            // textCameraPosition
            // 
            this.textCameraPosition.Location = new System.Drawing.Point(12, 39);
            this.textCameraPosition.Margin = new System.Windows.Forms.Padding(4);
            this.textCameraPosition.Name = "textCameraPosition";
            this.textCameraPosition.Size = new System.Drawing.Size(160, 22);
            this.textCameraPosition.TabIndex = 2;
            this.textCameraPosition.Text = "0 0 0";
            // 
            // cameraDirection
            // 
            this.cameraDirection.AutoSize = true;
            this.cameraDirection.Location = new System.Drawing.Point(8, 68);
            this.cameraDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cameraDirection.Name = "cameraDirection";
            this.cameraDirection.Size = new System.Drawing.Size(97, 16);
            this.cameraDirection.TabIndex = 1;
            this.cameraDirection.Text = "Направление";
            // 
            // cameraPosition
            // 
            this.cameraPosition.AutoSize = true;
            this.cameraPosition.Location = new System.Drawing.Point(8, 20);
            this.cameraPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cameraPosition.Name = "cameraPosition";
            this.cameraPosition.Size = new System.Drawing.Size(82, 16);
            this.cameraPosition.TabIndex = 0;
            this.cameraPosition.Text = "Положение";
            // 
            // cone
            // 
            this.cone.Controls.Add(this.label5);
            this.cone.Controls.Add(this.label4);
            this.cone.Controls.Add(this.height);
            this.cone.Controls.Add(this.radius);
            this.cone.Location = new System.Drawing.Point(16, 196);
            this.cone.Margin = new System.Windows.Forms.Padding(4);
            this.cone.Name = "cone";
            this.cone.Padding = new System.Windows.Forms.Padding(4);
            this.cone.Size = new System.Drawing.Size(187, 136);
            this.cone.TabIndex = 3;
            this.cone.TabStop = false;
            this.cone.Text = "Конус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Высота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Радиус основания";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(12, 102);
            this.height.Margin = new System.Windows.Forms.Padding(4);
            this.height.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(160, 22);
            this.height.TabIndex = 7;
            this.height.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(11, 46);
            this.radius.Margin = new System.Windows.Forms.Padding(4);
            this.radius.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(160, 22);
            this.radius.TabIndex = 6;
            this.radius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lightingSource
            // 
            this.lightingSource.Controls.Add(this.lightingCoordinates);
            this.lightingSource.Location = new System.Drawing.Point(16, 344);
            this.lightingSource.Margin = new System.Windows.Forms.Padding(4);
            this.lightingSource.Name = "lightingSource";
            this.lightingSource.Padding = new System.Windows.Forms.Padding(4);
            this.lightingSource.Size = new System.Drawing.Size(187, 64);
            this.lightingSource.TabIndex = 4;
            this.lightingSource.TabStop = false;
            this.lightingSource.Text = "Источник освещения";
            // 
            // lightingCoordinates
            // 
            this.lightingCoordinates.Location = new System.Drawing.Point(8, 23);
            this.lightingCoordinates.Margin = new System.Windows.Forms.Padding(4);
            this.lightingCoordinates.Name = "lightingCoordinates";
            this.lightingCoordinates.Size = new System.Drawing.Size(164, 22);
            this.lightingCoordinates.TabIndex = 4;
            this.lightingCoordinates.Text = "0 0 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cone);
            this.splitContainer1.Panel1.Controls.Add(this.buttonPaint);
            this.splitContainer1.Panel1.Controls.Add(this.buttonColor);
            this.splitContainer1.Panel1.Controls.Add(this.lightingSource);
            this.splitContainer1.Panel1.Controls.Add(this.camera);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.figureRepresentation);
            this.splitContainer1.Size = new System.Drawing.Size(1105, 578);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 6;
            // 
            // buttonColor
            // 
            this.buttonColor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonColor.Location = new System.Drawing.Point(132, 435);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(71, 28);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "Цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.RoyalBlue;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonPaint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 578);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конус";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.figureRepresentation)).EndInit();
            this.camera.ResumeLayout(false);
            this.camera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textViewingAngle)).EndInit();
            this.cone.ResumeLayout(false);
            this.cone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            this.lightingSource.ResumeLayout(false);
            this.lightingSource.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox figureRepresentation;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.GroupBox camera;
        private System.Windows.Forms.TextBox textCameraDirection;
        private System.Windows.Forms.TextBox textCameraPosition;
        private System.Windows.Forms.Label cameraDirection;
        private System.Windows.Forms.Label cameraPosition;
        private System.Windows.Forms.GroupBox cone;
        private System.Windows.Forms.GroupBox lightingSource;
        private System.Windows.Forms.TextBox lightingCoordinates;
        private System.Windows.Forms.NumericUpDown textViewingAngle;
        private System.Windows.Forms.Label viewingAngle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}