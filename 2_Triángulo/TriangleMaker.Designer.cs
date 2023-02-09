
namespace _2_Triángulo
{
    partial class mainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.msgLabel1 = new System.Windows.Forms.Label();
            this.msgLabel2 = new System.Windows.Forms.Label();
            this.msgLabel3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.msgLabel7 = new System.Windows.Forms.Label();
            this.msgLabel6 = new System.Windows.Forms.Label();
            this.msgLabel5 = new System.Windows.Forms.Label();
            this.msgLabel4 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.leaveButton = new System.Windows.Forms.Button();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.ayudaValorA = new System.Windows.Forms.ToolTip(this.components);
            this.ayudaValorB = new System.Windows.Forms.ToolTip(this.components);
            this.ayudaValorC = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // msgLabel1
            // 
            this.msgLabel1.AutoSize = true;
            this.msgLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel1.Location = new System.Drawing.Point(104, 70);
            this.msgLabel1.Name = "msgLabel1";
            this.msgLabel1.Size = new System.Drawing.Size(77, 20);
            this.msgLabel1.TabIndex = 0;
            this.msgLabel1.Text = "Lado (a):";
            // 
            // msgLabel2
            // 
            this.msgLabel2.AutoSize = true;
            this.msgLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel2.Location = new System.Drawing.Point(104, 142);
            this.msgLabel2.Name = "msgLabel2";
            this.msgLabel2.Size = new System.Drawing.Size(77, 20);
            this.msgLabel2.TabIndex = 1;
            this.msgLabel2.Text = "Lado (b):";
            // 
            // msgLabel3
            // 
            this.msgLabel3.AutoSize = true;
            this.msgLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel3.Location = new System.Drawing.Point(104, 208);
            this.msgLabel3.Name = "msgLabel3";
            this.msgLabel3.Size = new System.Drawing.Size(77, 20);
            this.msgLabel3.TabIndex = 2;
            this.msgLabel3.Text = "Lado (c):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 3;
            this.ayudaValorA.SetToolTip(this.textBox1, "Solo se permite valores mayores a 0");
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 4;
            this.ayudaValorB.SetToolTip(this.textBox2, "Solo se permite valores mayores a 0");
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 208);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(271, 22);
            this.textBox3.TabIndex = 5;
            this.ayudaValorC.SetToolTip(this.textBox3, "Solo se permite valores mayores a 0");
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(308, 267);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Mostrar";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(409, 267);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 7;
            this.cleanButton.Text = "Limpiar";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(213, 530);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(271, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(213, 464);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(271, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(213, 392);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(271, 22);
            this.textBox6.TabIndex = 11;
            // 
            // msgLabel7
            // 
            this.msgLabel7.AutoSize = true;
            this.msgLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel7.Location = new System.Drawing.Point(104, 530);
            this.msgLabel7.Name = "msgLabel7";
            this.msgLabel7.Size = new System.Drawing.Size(87, 20);
            this.msgLabel7.TabIndex = 10;
            this.msgLabel7.Text = "Perímetro:";
            // 
            // msgLabel6
            // 
            this.msgLabel6.AutoSize = true;
            this.msgLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel6.Location = new System.Drawing.Point(104, 464);
            this.msgLabel6.Name = "msgLabel6";
            this.msgLabel6.Size = new System.Drawing.Size(49, 20);
            this.msgLabel6.TabIndex = 9;
            this.msgLabel6.Text = "Área:";
            // 
            // msgLabel5
            // 
            this.msgLabel5.AutoSize = true;
            this.msgLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel5.Location = new System.Drawing.Point(104, 392);
            this.msgLabel5.Name = "msgLabel5";
            this.msgLabel5.Size = new System.Drawing.Size(61, 20);
            this.msgLabel5.TabIndex = 8;
            this.msgLabel5.Text = "Figura:";
            // 
            // msgLabel4
            // 
            this.msgLabel4.AutoSize = true;
            this.msgLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel4.Location = new System.Drawing.Point(104, 327);
            this.msgLabel4.Name = "msgLabel4";
            this.msgLabel4.Size = new System.Drawing.Size(121, 20);
            this.msgLabel4.TabIndex = 14;
            this.msgLabel4.Text = "Es un triángulo";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(252, 331);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 15;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // leaveButton
            // 
            this.leaveButton.Location = new System.Drawing.Point(524, 558);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(75, 23);
            this.leaveButton.TabIndex = 16;
            this.leaveButton.Text = "Salir";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // groupData
            // 
            this.groupData.Location = new System.Drawing.Point(70, 34);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(477, 275);
            this.groupData.TabIndex = 17;
            this.groupData.TabStop = false;
            this.groupData.Text = "Triángulo";
            // 
            // ayudaValorA
            // 
            this.ayudaValorA.IsBalloon = true;
            this.ayudaValorA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ayudaValorA.ToolTipTitle = "Lado (a)";
            // 
            // ayudaValorB
            // 
            this.ayudaValorB.IsBalloon = true;
            this.ayudaValorB.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ayudaValorB.ToolTipTitle = "Lado (b)";
            // 
            // ayudaValorC
            // 
            this.ayudaValorC.IsBalloon = true;
            this.ayudaValorC.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ayudaValorC.ToolTipTitle = "Lado (c)";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 593);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.msgLabel4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.msgLabel7);
            this.Controls.Add(this.msgLabel6);
            this.Controls.Add(this.msgLabel5);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.msgLabel3);
            this.Controls.Add(this.msgLabel2);
            this.Controls.Add(this.msgLabel1);
            this.Controls.Add(this.groupData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 640);
            this.MinimumSize = new System.Drawing.Size(640, 640);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLabel1;
        private System.Windows.Forms.Label msgLabel2;
        private System.Windows.Forms.Label msgLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label msgLabel7;
        private System.Windows.Forms.Label msgLabel6;
        private System.Windows.Forms.Label msgLabel5;
        private System.Windows.Forms.Label msgLabel4;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.ToolTip ayudaValorA;
        private System.Windows.Forms.ToolTip ayudaValorB;
        private System.Windows.Forms.ToolTip ayudaValorC;
    }
}

