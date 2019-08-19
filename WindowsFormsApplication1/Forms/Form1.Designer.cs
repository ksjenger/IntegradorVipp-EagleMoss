namespace IntegradorWebService
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecione = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelProgresso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Selecione o Arquivo Para Importar";
            // 
            // btnSelecione
            // 
            this.btnSelecione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelecione.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelecione.Location = new System.Drawing.Point(29, 36);
            this.btnSelecione.Name = "btnSelecione";
            this.btnSelecione.Size = new System.Drawing.Size(186, 42);
            this.btnSelecione.TabIndex = 0;
            this.btnSelecione.Text = "Selecione o Arquivo";
            this.btnSelecione.UseVisualStyleBackColor = true;
            this.btnSelecione.UseWaitCursor = true;
            this.btnSelecione.Click += new System.EventHandler(this.BtnSelecione_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(26, 98);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(0, 15);
            this.labelPath.TabIndex = 1;
            this.labelPath.UseWaitCursor = true;
            // 
            // labelProgresso
            // 
            this.labelProgresso.AutoSize = true;
            this.labelProgresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgresso.Location = new System.Drawing.Point(277, 49);
            this.labelProgresso.Name = "labelProgresso";
            this.labelProgresso.Size = new System.Drawing.Size(0, 15);
            this.labelProgresso.TabIndex = 2;
            this.labelProgresso.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSelecione;
            this.AccessibleDescription = "Importador Visual Personalizado";
            this.AccessibleName = "Importador Visual Personalizado";
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 132);
            this.Controls.Add(this.labelProgresso);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.btnSelecione);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importador Visual Personalizado";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelecione;
        private System.Windows.Forms.Label labelPath;
        public System.Windows.Forms.Label labelProgresso;
    }
}

