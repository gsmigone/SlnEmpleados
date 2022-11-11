namespace PresentacionWindows
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
            this.gridEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregarDto = new System.Windows.Forms.Button();
            this.btnMostrarEmpleados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdDpto = new System.Windows.Forms.TextBox();
            this.txtNombDpto = new System.Windows.Forms.TextBox();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.txtIdEmpl = new System.Windows.Forms.TextBox();
            this.txtNomEmpl = new System.Windows.Forms.TextBox();
            this.txtApeEmpl = new System.Windows.Forms.TextBox();
            this.txtLegEmpl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleados.Location = new System.Drawing.Point(254, 249);
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(265, 150);
            this.gridEmpleados.TabIndex = 0;
            // 
            // btnAgregarDto
            // 
            this.btnAgregarDto.Location = new System.Drawing.Point(131, 180);
            this.btnAgregarDto.Name = "btnAgregarDto";
            this.btnAgregarDto.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarDto.TabIndex = 1;
            this.btnAgregarDto.Text = "Agregar Departamento";
            this.btnAgregarDto.UseVisualStyleBackColor = true;
            this.btnAgregarDto.Click += new System.EventHandler(this.btnAgregarDto_Click);
            // 
            // btnMostrarEmpleados
            // 
            this.btnMostrarEmpleados.Location = new System.Drawing.Point(85, 307);
            this.btnMostrarEmpleados.Name = "btnMostrarEmpleados";
            this.btnMostrarEmpleados.Size = new System.Drawing.Size(114, 23);
            this.btnMostrarEmpleados.TabIndex = 2;
            this.btnMostrarEmpleados.Text = "Mostrar Empleados";
            this.btnMostrarEmpleados.UseVisualStyleBackColor = true;
            this.btnMostrarEmpleados.Click += new System.EventHandler(this.btnMostrarEmpleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Departamento:";
            // 
            // txtIdDpto
            // 
            this.txtIdDpto.Location = new System.Drawing.Point(165, 56);
            this.txtIdDpto.Name = "txtIdDpto";
            this.txtIdDpto.Size = new System.Drawing.Size(100, 20);
            this.txtIdDpto.TabIndex = 5;
            // 
            // txtNombDpto
            // 
            this.txtNombDpto.Location = new System.Drawing.Point(165, 82);
            this.txtNombDpto.Name = "txtNombDpto";
            this.txtNombDpto.Size = new System.Drawing.Size(100, 20);
            this.txtNombDpto.TabIndex = 6;
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Location = new System.Drawing.Point(403, 180);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(125, 23);
            this.btnAgregarEmp.TabIndex = 7;
            this.btnAgregarEmp.Text = "Agregar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // txtIdEmpl
            // 
            this.txtIdEmpl.Location = new System.Drawing.Point(409, 56);
            this.txtIdEmpl.Name = "txtIdEmpl";
            this.txtIdEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpl.TabIndex = 8;
            // 
            // txtNomEmpl
            // 
            this.txtNomEmpl.Location = new System.Drawing.Point(409, 87);
            this.txtNomEmpl.Name = "txtNomEmpl";
            this.txtNomEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtNomEmpl.TabIndex = 9;
            // 
            // txtApeEmpl
            // 
            this.txtApeEmpl.Location = new System.Drawing.Point(409, 113);
            this.txtApeEmpl.Name = "txtApeEmpl";
            this.txtApeEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtApeEmpl.TabIndex = 10;
            // 
            // txtLegEmpl
            // 
            this.txtLegEmpl.Location = new System.Drawing.Point(409, 139);
            this.txtLegEmpl.Name = "txtLegEmpl";
            this.txtLegEmpl.Size = new System.Drawing.Size(100, 20);
            this.txtLegEmpl.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre Empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Apellido Empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Legajo Empleado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLegEmpl);
            this.Controls.Add(this.txtApeEmpl);
            this.Controls.Add(this.txtNomEmpl);
            this.Controls.Add(this.txtIdEmpl);
            this.Controls.Add(this.btnAgregarEmp);
            this.Controls.Add(this.txtNombDpto);
            this.Controls.Add(this.txtIdDpto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrarEmpleados);
            this.Controls.Add(this.btnAgregarDto);
            this.Controls.Add(this.gridEmpleados);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEmpleados;
        private System.Windows.Forms.Button btnAgregarDto;
        private System.Windows.Forms.Button btnMostrarEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdDpto;
        private System.Windows.Forms.TextBox txtNombDpto;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.TextBox txtIdEmpl;
        private System.Windows.Forms.TextBox txtNomEmpl;
        private System.Windows.Forms.TextBox txtApeEmpl;
        private System.Windows.Forms.TextBox txtLegEmpl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

