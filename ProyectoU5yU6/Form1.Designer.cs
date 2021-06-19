
namespace ProyectoU5yU6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddCom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.olk = new System.Windows.Forms.Button();
            this.OF = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCom
            // 
            this.AddCom.Location = new System.Drawing.Point(618, 415);
            this.AddCom.Name = "AddCom";
            this.AddCom.Size = new System.Drawing.Size(170, 23);
            this.AddCom.TabIndex = 0;
            this.AddCom.Text = "Añadir comentario";
            this.AddCom.UseVisualStyleBackColor = true;
            this.AddCom.Click += new System.EventHandler(this.DelCom_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(30, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(582, 177);
            this.textBox1.TabIndex = 1;
            // 
            // olk
            // 
            this.olk.Location = new System.Drawing.Point(469, 415);
            this.olk.Name = "olk";
            this.olk.Size = new System.Drawing.Size(121, 23);
            this.olk.TabIndex = 2;
            this.olk.Text = "Ordenar Likes";
            this.olk.UseVisualStyleBackColor = true;
            this.olk.Click += new System.EventHandler(this.olk_Click);
            // 
            // OF
            // 
            this.OF.Location = new System.Drawing.Point(320, 415);
            this.OF.Name = "OF";
            this.OF.Size = new System.Drawing.Size(133, 23);
            this.OF.TabIndex = 3;
            this.OF.Text = "Ordenar por Fecha";
            this.OF.UseVisualStyleBackColor = true;
            this.OF.Click += new System.EventHandler(this.OF_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(30, 217);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(582, 177);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.OF);
            this.Controls.Add(this.olk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddCom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Proyecto U5yU6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button olk;
        private System.Windows.Forms.Button OF;
        private System.Windows.Forms.TextBox textBox2;
    }
}

