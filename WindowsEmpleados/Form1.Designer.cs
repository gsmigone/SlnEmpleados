namespace WindowsEmpleados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLegEmpl = new System.Windows.Forms.TextBox();
            this.txtApeEmpl = new System.Windows.Forms.TextBox();
            this.txtNomEmpl = new System.Windows.Forms.TextBox();
            this.txtIdEmpl = new System.Windows.Forms.TextBox();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Legajo Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Apellido Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ID Empleado:";
            // 
            // txtLegEmpl
            // 
            this.txtLegEmpl.Location = new System.Drawing.Point(156, 132);
            this.txtLegEmpl.Name = "txtLegEmpl";
            this.txtLegEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtLegEmpl.TabIndex = 20;
            // 
            // txtApeEmpl
            // 
            this.txtApeEmpl.Location = new System.Drawing.Point(156, 106);
            this.txtApeEmpl.Name = "txtApeEmpl";
            this.txtApeEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtApeEmpl.TabIndex = 19;
            // 
            // txtNomEmpl
            // 
            this.txtNomEmpl.Location = new System.Drawing.Point(156, 80);
            this.txtNomEmpl.Name = "txtNomEmpl";
            this.txtNomEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtNomEmpl.TabIndex = 18;
            // 
            // txtIdEmpl
            // 
            this.txtIdEmpl.Location = new System.Drawing.Point(156, 49);
            this.txtIdEmpl.Name = "txtIdEmpl";
            this.txtIdEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpl.TabIndex = 17;
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Location = new System.Drawing.Point(150, 173);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarEmp.TabIndex = 16;
            this.btnAgregarEmp.Text = "Agregar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(518, 37);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(114, 23);
            this.btnMostrarEmpleados.TabIndex = 26;
            this.btnMostrarEmpleados.Text = "Mostrar Empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Location = new System.Drawing.Point(446, 66);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(265, 150);
            this.gridEmpleados.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 256);
            this.Controls.Add(this.btnMostrarEmpleados);
            this.Controls.Add(this.gridEmpleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLegEmpl);
            this.Controls.Add(this.txtApeEmpl);
            this.Controls.Add(this.txtNomEmpl);
            this.Controls.Add(this.txtIdEmpl);
            this.Controls.Add(this.btnAgregarEmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLegEmpl;
        private System.Windows.Forms.TextBox txtApeEmpl;
        private System.Windows.Forms.TextBox txtNomEmpl;
        private System.Windows.Forms.TextBox txtIdEmpl;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.DataGridView gridEmpleados;
    }
}

