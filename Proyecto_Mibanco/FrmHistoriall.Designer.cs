namespace Proyecto_Mibanco
{
    partial class FrmHistoriall
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
            dtgHistorial = new DataGridView();
            TIPOdeTRANSACCION = new DataGridViewTextBoxColumn();
            MONTO = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgHistorial).BeginInit();
            SuspendLayout();
            // 
            // dtgHistorial
            // 
            dtgHistorial.BackgroundColor = SystemColors.Control;
            dtgHistorial.BorderStyle = BorderStyle.None;
            dtgHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHistorial.Columns.AddRange(new DataGridViewColumn[] { TIPOdeTRANSACCION, MONTO, FECHA });
            dtgHistorial.Location = new Point(35, 109);
            dtgHistorial.Name = "dtgHistorial";
            dtgHistorial.Size = new Size(617, 360);
            dtgHistorial.TabIndex = 0;
            // 
            // TIPOdeTRANSACCION
            // 
            TIPOdeTRANSACCION.FillWeight = 190F;
            TIPOdeTRANSACCION.HeaderText = "Tipo de Transacción";
            TIPOdeTRANSACCION.Name = "TIPOdeTRANSACCION";
            TIPOdeTRANSACCION.Width = 190;
            // 
            // MONTO
            // 
            MONTO.FillWeight = 190F;
            MONTO.HeaderText = "Monto";
            MONTO.Name = "MONTO";
            MONTO.Width = 190;
            // 
            // FECHA
            // 
            FECHA.FillWeight = 190F;
            FECHA.HeaderText = "Fecha";
            FECHA.Name = "FECHA";
            FECHA.Width = 190;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 33);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Historial Transacciones";
            // 
            // FrmHistoriall
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 561);
            Controls.Add(label1);
            Controls.Add(dtgHistorial);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(692, 561);
            Name = "FrmHistoriall";
            Text = "FrmHistoriall";
            ((System.ComponentModel.ISupportInitialize)dtgHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgHistorial;
        private DataGridViewTextBoxColumn TIPOdeTRANSACCION;
        private DataGridViewTextBoxColumn MONTO;
        private DataGridViewTextBoxColumn FECHA;
        private Label label1;
    }
}