namespace PersonaDB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gdPersona = new DataGridView();
            btnMostrar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            tbId = new TextBox();
            tbName = new TextBox();
            tbLName = new TextBox();
            tbArcana = new TextBox();
            tbPersona = new TextBox();
            tbGrupo = new TextBox();
            ID = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdPersona).BeginInit();
            SuspendLayout();
            // 
            // gdPersona
            // 
            gdPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdPersona.Location = new Point(12, 12);
            gdPersona.Name = "gdPersona";
            gdPersona.Size = new Size(743, 221);
            gdPersona.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(12, 254);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 294);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 335);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tbId
            // 
            tbId.Location = new Point(93, 294);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(93, 336);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 5;
            // 
            // tbLName
            // 
            tbLName.Location = new Point(199, 336);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(100, 23);
            tbLName.TabIndex = 6;
            // 
            // tbArcana
            // 
            tbArcana.Location = new Point(305, 335);
            tbArcana.Name = "tbArcana";
            tbArcana.Size = new Size(100, 23);
            tbArcana.TabIndex = 7;
            // 
            // tbPersona
            // 
            tbPersona.Location = new Point(411, 335);
            tbPersona.Name = "tbPersona";
            tbPersona.Size = new Size(100, 23);
            tbPersona.TabIndex = 8;
            // 
            // tbGrupo
            // 
            tbGrupo.Location = new Point(517, 335);
            tbGrupo.Name = "tbGrupo";
            tbGrupo.Size = new Size(100, 23);
            tbGrupo.TabIndex = 9;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(93, 276);
            ID.Name = "ID";
            ID.Size = new Size(19, 15);
            ID.TabIndex = 10;
            ID.Text = "}D";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 318);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 318);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 12;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 317);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 13;
            label4.Text = "Arcana";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(411, 317);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 14;
            label5.Text = "Persona";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 317);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 15;
            label6.Text = "Grupo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ID);
            Controls.Add(tbGrupo);
            Controls.Add(tbPersona);
            Controls.Add(tbArcana);
            Controls.Add(tbLName);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(btnMostrar);
            Controls.Add(gdPersona);
            Name = "Form1";
            Text = "ID";
            ((System.ComponentModel.ISupportInitialize)gdPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gdPersona;
        private Button btnMostrar;
        private Button btnEliminar;
        private Button btnAgregar;
        private TextBox tbId;
        private TextBox tbName;
        private TextBox tbLName;
        private TextBox tbArcana;
        private TextBox tbPersona;
        private TextBox tbGrupo;
        private Label ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
