namespace IA_RONAL_2026
{
    partial class FRMOchoPuzzle
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
            components = new System.ComponentModel.Container();
            LBL00 = new Label();
            LBL01 = new Label();
            LBL02 = new Label();
            LBL10 = new Label();
            LBL11 = new Label();
            LBL12 = new Label();
            LBL20 = new Label();
            LBL21 = new Label();
            LBL22 = new Label();
            LBLContador = new Label();
            TRMReloj = new System.Windows.Forms.Timer(components);
            BTNDesordenar = new Button();
            BTNGenerarHijos = new Button();
            BTNesFinal = new Button();
            BTNAnchuraPrioritaria = new Button();
            TRMcontador = new System.Windows.Forms.Timer(components);
            TRMProfundidadLimit = new System.Windows.Forms.Timer(components);
            BTNProfundidadLimitada = new Button();
            NUDLimite = new NumericUpDown();
            BTNProfundidadIterativa = new Button();
            NUDLimiteIterativo = new NumericUpDown();
            BTNH1 = new Button();
            BTNH2 = new Button();
            BTNH3 = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDLimite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDLimiteIterativo).BeginInit();
            SuspendLayout();
            // 
            // LBL00
            // 
            LBL00.BackColor = Color.LightSkyBlue;
            LBL00.BorderStyle = BorderStyle.FixedSingle;
            LBL00.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL00.Location = new Point(12, 41);
            LBL00.Name = "LBL00";
            LBL00.Size = new Size(100, 84);
            LBL00.TabIndex = 0;
            LBL00.Text = "1";
            LBL00.TextAlign = ContentAlignment.MiddleCenter;
            LBL00.Click += LBL00_Click;
            // 
            // LBL01
            // 
            LBL01.BackColor = Color.LightSkyBlue;
            LBL01.BorderStyle = BorderStyle.FixedSingle;
            LBL01.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL01.Location = new Point(118, 41);
            LBL01.Name = "LBL01";
            LBL01.Size = new Size(100, 84);
            LBL01.TabIndex = 1;
            LBL01.Text = "2";
            LBL01.TextAlign = ContentAlignment.MiddleCenter;
            LBL01.Click += LBL01_Click;
            // 
            // LBL02
            // 
            LBL02.BackColor = Color.LightSkyBlue;
            LBL02.BorderStyle = BorderStyle.FixedSingle;
            LBL02.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL02.Location = new Point(224, 41);
            LBL02.Name = "LBL02";
            LBL02.Size = new Size(100, 84);
            LBL02.TabIndex = 2;
            LBL02.Text = "3";
            LBL02.TextAlign = ContentAlignment.MiddleCenter;
            LBL02.Click += LBL02_Click;
            // 
            // LBL10
            // 
            LBL10.BackColor = Color.LightSkyBlue;
            LBL10.BorderStyle = BorderStyle.FixedSingle;
            LBL10.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL10.Location = new Point(12, 134);
            LBL10.Name = "LBL10";
            LBL10.Size = new Size(100, 84);
            LBL10.TabIndex = 3;
            LBL10.Text = "8";
            LBL10.TextAlign = ContentAlignment.MiddleCenter;
            LBL10.Click += LBL10_Click;
            // 
            // LBL11
            // 
            LBL11.BackColor = Color.LightSkyBlue;
            LBL11.BorderStyle = BorderStyle.FixedSingle;
            LBL11.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL11.Location = new Point(118, 134);
            LBL11.Name = "LBL11";
            LBL11.Size = new Size(100, 84);
            LBL11.TabIndex = 4;
            LBL11.Text = "0";
            LBL11.TextAlign = ContentAlignment.MiddleCenter;
            LBL11.Click += LBL11_Click;
            // 
            // LBL12
            // 
            LBL12.BackColor = Color.LightSkyBlue;
            LBL12.BorderStyle = BorderStyle.FixedSingle;
            LBL12.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL12.Location = new Point(224, 134);
            LBL12.Name = "LBL12";
            LBL12.Size = new Size(100, 84);
            LBL12.TabIndex = 5;
            LBL12.Text = "4";
            LBL12.TextAlign = ContentAlignment.MiddleCenter;
            LBL12.Click += LBL12_Click;
            // 
            // LBL20
            // 
            LBL20.BackColor = Color.LightSkyBlue;
            LBL20.BorderStyle = BorderStyle.FixedSingle;
            LBL20.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL20.Location = new Point(12, 229);
            LBL20.Name = "LBL20";
            LBL20.Size = new Size(100, 84);
            LBL20.TabIndex = 6;
            LBL20.Text = "7";
            LBL20.TextAlign = ContentAlignment.MiddleCenter;
            LBL20.Click += LBL20_Click;
            // 
            // LBL21
            // 
            LBL21.BackColor = Color.LightSkyBlue;
            LBL21.BorderStyle = BorderStyle.FixedSingle;
            LBL21.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL21.Location = new Point(118, 229);
            LBL21.Name = "LBL21";
            LBL21.Size = new Size(100, 84);
            LBL21.TabIndex = 7;
            LBL21.Text = "6";
            LBL21.TextAlign = ContentAlignment.MiddleCenter;
            LBL21.Click += LBL21_Click;
            // 
            // LBL22
            // 
            LBL22.BackColor = Color.LightSkyBlue;
            LBL22.BorderStyle = BorderStyle.FixedSingle;
            LBL22.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL22.Location = new Point(224, 229);
            LBL22.Name = "LBL22";
            LBL22.Size = new Size(100, 84);
            LBL22.TabIndex = 8;
            LBL22.Text = "5";
            LBL22.TextAlign = ContentAlignment.MiddleCenter;
            LBL22.Click += LBL22_Click;
            // 
            // LBLContador
            // 
            LBLContador.BackColor = Color.LightSkyBlue;
            LBLContador.BorderStyle = BorderStyle.FixedSingle;
            LBLContador.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBLContador.Location = new Point(356, 106);
            LBLContador.Name = "LBLContador";
            LBLContador.Size = new Size(128, 112);
            LBLContador.TabIndex = 9;
            LBLContador.TextAlign = ContentAlignment.MiddleCenter;
            LBLContador.Click += LBLContador_Click;
            // 
            // TRMReloj
            // 
            TRMReloj.Tick += TRMReloj_Tick;
            // 
            // BTNDesordenar
            // 
            BTNDesordenar.Location = new Point(356, 41);
            BTNDesordenar.Name = "BTNDesordenar";
            BTNDesordenar.Size = new Size(113, 53);
            BTNDesordenar.TabIndex = 10;
            BTNDesordenar.Text = "Desordenar";
            BTNDesordenar.UseVisualStyleBackColor = true;
            BTNDesordenar.Click += BTNDesordenar_Click;
            // 
            // BTNGenerarHijos
            // 
            BTNGenerarHijos.Location = new Point(594, 41);
            BTNGenerarHijos.Name = "BTNGenerarHijos";
            BTNGenerarHijos.Size = new Size(113, 53);
            BTNGenerarHijos.TabIndex = 11;
            BTNGenerarHijos.Text = "Generar Hijos";
            BTNGenerarHijos.UseVisualStyleBackColor = true;
            BTNGenerarHijos.Click += BTNGenerarHijos_Click;
            // 
            // BTNesFinal
            // 
            BTNesFinal.Location = new Point(475, 41);
            BTNesFinal.Name = "BTNesFinal";
            BTNesFinal.Size = new Size(113, 53);
            BTNesFinal.TabIndex = 12;
            BTNesFinal.Text = "Es Final";
            BTNesFinal.UseVisualStyleBackColor = true;
            BTNesFinal.Click += BTNesFinal_Click;
            // 
            // BTNAnchuraPrioritaria
            // 
            BTNAnchuraPrioritaria.Location = new Point(356, 359);
            BTNAnchuraPrioritaria.Name = "BTNAnchuraPrioritaria";
            BTNAnchuraPrioritaria.Size = new Size(128, 53);
            BTNAnchuraPrioritaria.TabIndex = 13;
            BTNAnchuraPrioritaria.Text = "Anchura Prioritaria";
            BTNAnchuraPrioritaria.UseVisualStyleBackColor = true;
            BTNAnchuraPrioritaria.Click += BTNAnchuraPrioritaria_Click_1;
            // 
            // TRMcontador
            // 
            TRMcontador.Tick += TRMcontador_Tick_1;
            // 
            // TRMProfundidadLimit
            // 
            TRMProfundidadLimit.Tick += TRMProfundidadLimit_Tick;
            // 
            // BTNProfundidadLimitada
            // 
            BTNProfundidadLimitada.Location = new Point(356, 241);
            BTNProfundidadLimitada.Name = "BTNProfundidadLimitada";
            BTNProfundidadLimitada.Size = new Size(128, 53);
            BTNProfundidadLimitada.TabIndex = 14;
            BTNProfundidadLimitada.Text = "Profundidad";
            BTNProfundidadLimitada.UseVisualStyleBackColor = true;
            BTNProfundidadLimitada.Click += BTNProfundidadLimitada_Click;
            // 
            // NUDLimite
            // 
            NUDLimite.Location = new Point(490, 258);
            NUDLimite.Name = "NUDLimite";
            NUDLimite.Size = new Size(83, 23);
            NUDLimite.TabIndex = 16;
            // 
            // BTNProfundidadIterativa
            // 
            BTNProfundidadIterativa.Location = new Point(356, 300);
            BTNProfundidadIterativa.Name = "BTNProfundidadIterativa";
            BTNProfundidadIterativa.Size = new Size(128, 53);
            BTNProfundidadIterativa.TabIndex = 17;
            BTNProfundidadIterativa.Text = "Profundidad Iterativa";
            BTNProfundidadIterativa.UseVisualStyleBackColor = true;
            BTNProfundidadIterativa.Click += BTNProfundidadIterativa_Click;
            // 
            // NUDLimiteIterativo
            // 
            NUDLimiteIterativo.Location = new Point(490, 317);
            NUDLimiteIterativo.Name = "NUDLimiteIterativo";
            NUDLimiteIterativo.Size = new Size(83, 23);
            NUDLimiteIterativo.TabIndex = 18;
            // 
            // BTNH1
            // 
            BTNH1.Location = new Point(616, 106);
            BTNH1.Name = "BTNH1";
            BTNH1.Size = new Size(57, 53);
            BTNH1.TabIndex = 19;
            BTNH1.Text = "H1";
            BTNH1.UseVisualStyleBackColor = true;
            BTNH1.Click += BTNH1_Click;
            // 
            // BTNH2
            // 
            BTNH2.Location = new Point(616, 165);
            BTNH2.Name = "BTNH2";
            BTNH2.Size = new Size(57, 53);
            BTNH2.TabIndex = 20;
            BTNH2.Text = "H2";
            BTNH2.UseVisualStyleBackColor = true;
            BTNH2.Click += BTNH2_Click;
            // 
            // BTNH3
            // 
            BTNH3.Location = new Point(616, 224);
            BTNH3.Name = "BTNH3";
            BTNH3.Size = new Size(57, 53);
            BTNH3.TabIndex = 21;
            BTNH3.Text = "H3";
            BTNH3.UseVisualStyleBackColor = true;
            BTNH3.Click += BTNH3_Click;
            // 
            // FRMOchoPuzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 418);
            Controls.Add(BTNH3);
            Controls.Add(BTNH2);
            Controls.Add(BTNH1);
            Controls.Add(NUDLimiteIterativo);
            Controls.Add(BTNProfundidadIterativa);
            Controls.Add(NUDLimite);
            Controls.Add(BTNProfundidadLimitada);
            Controls.Add(BTNAnchuraPrioritaria);
            Controls.Add(BTNesFinal);
            Controls.Add(BTNGenerarHijos);
            Controls.Add(BTNDesordenar);
            Controls.Add(LBLContador);
            Controls.Add(LBL22);
            Controls.Add(LBL21);
            Controls.Add(LBL20);
            Controls.Add(LBL12);
            Controls.Add(LBL11);
            Controls.Add(LBL10);
            Controls.Add(LBL02);
            Controls.Add(LBL01);
            Controls.Add(LBL00);
            Name = "FRMOchoPuzzle";
            Text = "FRMOchoPuzzle";
            ((System.ComponentModel.ISupportInitialize)NUDLimite).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDLimiteIterativo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LBL00;
        private Label LBL01;
        private Label LBL02;
        private Label LBL10;
        private Label LBL11;
        private Label LBL12;
        private Label LBL20;
        private Label LBL21;
        private Label LBL22;
        private Label LBLContador;
        private System.Windows.Forms.Timer TRMReloj;
        private Button BTNDesordenar;
        private Button BTNGenerarHijos;
        private Button BTNesFinal;
        private Button BTNAnchuraPrioritaria;
        private System.Windows.Forms.Timer TRMcontador;
        private System.Windows.Forms.Timer TRMProfundidadLimit;
        private Button BTNProfundidadLimitada;
        private NumericUpDown NUDLimite;
        private Button BTNProfundidadIterativa;
        private NumericUpDown NUDLimiteIterativo;
        private Button BTNH1;
        private Button BTNH2;
        private Button BTNH3;
    }
}