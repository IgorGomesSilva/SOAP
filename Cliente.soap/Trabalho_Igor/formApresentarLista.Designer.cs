namespace TrabalhoDudu
{
    partial class formApresentarLista
    {
        private System.ComponentModel.IContainer components = null;

        
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
            this.btnApresentarLista = new System.Windows.Forms.Button();
            this.lbItens = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnApresentarLista
            // 
            this.btnApresentarLista.Location = new System.Drawing.Point(230, 20);
            this.btnApresentarLista.Name = "btnApresentarLista";
            this.btnApresentarLista.Size = new System.Drawing.Size(137, 23);
            this.btnApresentarLista.TabIndex = 1;
            this.btnApresentarLista.Text = "Apresentar Combo";
            this.btnApresentarLista.UseVisualStyleBackColor = true;
            this.btnApresentarLista.Click += new System.EventHandler(this.btnApresentarLista_Click);
            // 
            // lbItens
            // 
            this.lbItens.FormattingEnabled = true;
            this.lbItens.Location = new System.Drawing.Point(21, 72);
            this.lbItens.Name = "lbItens";
            this.lbItens.Size = new System.Drawing.Size(147, 199);
            this.lbItens.TabIndex = 2;
            // 
            // formApresentarLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 324);
            this.Controls.Add(this.lbItens);
            this.Controls.Add(this.btnApresentarLista);
            this.Name = "formApresentarLista";
            this.Text = "ApresentarLista";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApresentarLista;
        private System.Windows.Forms.ListBox lbItens;
    }
}