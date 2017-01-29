namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.retroceder = new System.Windows.Forms.Button();
            this.cuadro = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ALEX";
            this.aRCHIVOToolStripMenuItem.Click += new System.EventHandler(this.aRCHIVOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 40);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(346, 39);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // retroceder
            // 
            this.retroceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retroceder.Location = new System.Drawing.Point(12, 96);
            this.retroceder.Name = "retroceder";
            this.retroceder.Size = new System.Drawing.Size(131, 34);
            this.retroceder.TabIndex = 2;
            this.retroceder.Text = "←";
            this.retroceder.UseVisualStyleBackColor = true;
            this.retroceder.Click += new System.EventHandler(this.retroceder_Click);
            // 
            // cuadro
            // 
            this.cuadro.Location = new System.Drawing.Point(297, 96);
            this.cuadro.Name = "cuadro";
            this.cuadro.Size = new System.Drawing.Size(61, 34);
            this.cuadro.TabIndex = 3;
            this.cuadro.Text = "x^2";
            this.cuadro.UseVisualStyleBackColor = true;
            this.cuadro.Click += new System.EventHandler(this.cuadro_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(230, 96);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(61, 34);
            this.dividir.TabIndex = 4;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(149, 96);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 34);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 136);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(63, 34);
            this.num7.TabIndex = 6;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(81, 136);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(62, 34);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(149, 136);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 34);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(230, 136);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(61, 34);
            this.multiplicar.TabIndex = 9;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // raiz
            // 
            this.raiz.Location = new System.Drawing.Point(297, 136);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(61, 34);
            this.raiz.TabIndex = 10;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.raiz_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 176);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(63, 34);
            this.num4.TabIndex = 11;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 216);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(63, 34);
            this.num1.TabIndex = 12;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(81, 176);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(62, 34);
            this.num5.TabIndex = 13;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(81, 216);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(62, 34);
            this.num2.TabIndex = 14;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(149, 176);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 34);
            this.num6.TabIndex = 15;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(149, 216);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 34);
            this.num3.TabIndex = 16;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(230, 176);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(61, 34);
            this.restar.TabIndex = 17;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(230, 216);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(61, 74);
            this.sumar.TabIndex = 18;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(12, 256);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(131, 34);
            this.cero.TabIndex = 19;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.cero_Click);
            // 
            // punto
            // 
            this.punto.Location = new System.Drawing.Point(149, 256);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(75, 34);
            this.punto.TabIndex = 20;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(297, 176);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(61, 114);
            this.igual.TabIndex = 21;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(370, 324);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.cuadro);
            this.Controls.Add(this.retroceder);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button retroceder;
        private System.Windows.Forms.Button cuadro;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button igual;
    }
}

