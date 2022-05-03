namespace Calculadora_Rd
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
            this.textPRUEBA = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNSIETE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTNCUATRO = new System.Windows.Forms.Button();
            this.BTNUNO = new System.Windows.Forms.Button();
            this.BTNOCHO = new System.Windows.Forms.Button();
            this.BTNCINCO = new System.Windows.Forms.Button();
            this.BTNDIVIDIR = new System.Windows.Forms.Button();
            this.BTNDOS = new System.Windows.Forms.Button();
            this.BTNCERO = new System.Windows.Forms.Button();
            this.BTNRESULTADODETODO = new System.Windows.Forms.Button();
            this.BTNMULTIPLICAR = new System.Windows.Forms.Button();
            this.BTNELEVADO = new System.Windows.Forms.Button();
            this.BTNRAIZCUADRADA = new System.Windows.Forms.Button();
            this.BTNSUMAR = new System.Windows.Forms.Button();
            this.BTNRESTAR = new System.Windows.Forms.Button();
            this.BTNBORRARTODO = new System.Windows.Forms.Button();
            this.BTNNUEVE = new System.Windows.Forms.Button();
            this.BTNSEIS = new System.Windows.Forms.Button();
            this.BTNTRES = new System.Windows.Forms.Button();
            this.BTNPUTNO = new System.Windows.Forms.Button();
            this.BTNBORRAR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calculadora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textPRUEBA
            // 
            this.textPRUEBA.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPRUEBA.Location = new System.Drawing.Point(29, 58);
            this.textPRUEBA.MaxLength = 22;
            this.textPRUEBA.Multiline = true;
            this.textPRUEBA.Name = "textPRUEBA";
            this.textPRUEBA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textPRUEBA.Size = new System.Drawing.Size(369, 39);
            this.textPRUEBA.TabIndex = 0;
            this.textPRUEBA.Tag = "";
            this.textPRUEBA.Text = "0";
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.Location = new System.Drawing.Point(44, 154);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(45, 45);
            this.BTNELIMINAR.TabIndex = 1;
            this.BTNELIMINAR.Text = "CE";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNSIETE
            // 
            this.BTNSIETE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNSIETE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNSIETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNSIETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSIETE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSIETE.Location = new System.Drawing.Point(44, 218);
            this.BTNSIETE.Name = "BTNSIETE";
            this.BTNSIETE.Size = new System.Drawing.Size(45, 45);
            this.BTNSIETE.TabIndex = 2;
            this.BTNSIETE.Text = "7";
            this.BTNSIETE.UseVisualStyleBackColor = false;
            this.BTNSIETE.Click += new System.EventHandler(this.agregarnumero);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(44, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "+/-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BTNCUATRO
            // 
            this.BTNCUATRO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCUATRO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNCUATRO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNCUATRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCUATRO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCUATRO.Location = new System.Drawing.Point(44, 278);
            this.BTNCUATRO.Name = "BTNCUATRO";
            this.BTNCUATRO.Size = new System.Drawing.Size(45, 45);
            this.BTNCUATRO.TabIndex = 4;
            this.BTNCUATRO.Text = "4";
            this.BTNCUATRO.UseVisualStyleBackColor = false;
            this.BTNCUATRO.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNUNO
            // 
            this.BTNUNO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNUNO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNUNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNUNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUNO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUNO.Location = new System.Drawing.Point(44, 336);
            this.BTNUNO.Name = "BTNUNO";
            this.BTNUNO.Size = new System.Drawing.Size(45, 45);
            this.BTNUNO.TabIndex = 5;
            this.BTNUNO.Text = "1";
            this.BTNUNO.UseVisualStyleBackColor = false;
            this.BTNUNO.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNOCHO
            // 
            this.BTNOCHO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNOCHO.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNOCHO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTNOCHO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNOCHO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNOCHO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOCHO.Location = new System.Drawing.Point(109, 218);
            this.BTNOCHO.Name = "BTNOCHO";
            this.BTNOCHO.Size = new System.Drawing.Size(45, 45);
            this.BTNOCHO.TabIndex = 6;
            this.BTNOCHO.Text = "8";
            this.BTNOCHO.UseVisualStyleBackColor = false;
            this.BTNOCHO.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNCINCO
            // 
            this.BTNCINCO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCINCO.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNCINCO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTNCINCO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNCINCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCINCO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCINCO.Location = new System.Drawing.Point(109, 278);
            this.BTNCINCO.Name = "BTNCINCO";
            this.BTNCINCO.Size = new System.Drawing.Size(45, 45);
            this.BTNCINCO.TabIndex = 7;
            this.BTNCINCO.Text = "5";
            this.BTNCINCO.UseVisualStyleBackColor = false;
            this.BTNCINCO.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNDIVIDIR
            // 
            this.BTNDIVIDIR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNDIVIDIR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNDIVIDIR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNDIVIDIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNDIVIDIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNDIVIDIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDIVIDIR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDIVIDIR.Location = new System.Drawing.Point(275, 241);
            this.BTNDIVIDIR.Name = "BTNDIVIDIR";
            this.BTNDIVIDIR.Size = new System.Drawing.Size(45, 45);
            this.BTNDIVIDIR.TabIndex = 8;
            this.BTNDIVIDIR.Tag = "÷";
            this.BTNDIVIDIR.Text = "÷";
            this.BTNDIVIDIR.UseVisualStyleBackColor = false;
            this.BTNDIVIDIR.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNDOS
            // 
            this.BTNDOS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNDOS.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNDOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTNDOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNDOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDOS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDOS.Location = new System.Drawing.Point(109, 336);
            this.BTNDOS.Name = "BTNDOS";
            this.BTNDOS.Size = new System.Drawing.Size(45, 45);
            this.BTNDOS.TabIndex = 9;
            this.BTNDOS.Text = "2";
            this.BTNDOS.UseVisualStyleBackColor = false;
            this.BTNDOS.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNCERO
            // 
            this.BTNCERO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCERO.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNCERO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BTNCERO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BTNCERO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCERO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCERO.Location = new System.Drawing.Point(109, 393);
            this.BTNCERO.Name = "BTNCERO";
            this.BTNCERO.Size = new System.Drawing.Size(45, 45);
            this.BTNCERO.TabIndex = 10;
            this.BTNCERO.Text = "0";
            this.BTNCERO.UseVisualStyleBackColor = false;
            this.BTNCERO.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNRESULTADODETODO
            // 
            this.BTNRESULTADODETODO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNRESULTADODETODO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNRESULTADODETODO.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNRESULTADODETODO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNRESULTADODETODO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNRESULTADODETODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRESULTADODETODO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESULTADODETODO.Location = new System.Drawing.Point(259, 393);
            this.BTNRESULTADODETODO.Name = "BTNRESULTADODETODO";
            this.BTNRESULTADODETODO.Size = new System.Drawing.Size(157, 45);
            this.BTNRESULTADODETODO.TabIndex = 11;
            this.BTNRESULTADODETODO.Tag = "=";
            this.BTNRESULTADODETODO.Text = "=";
            this.BTNRESULTADODETODO.UseVisualStyleBackColor = false;
            this.BTNRESULTADODETODO.Click += new System.EventHandler(this.BTNRESULTADODETODO_Click);
            // 
            // BTNMULTIPLICAR
            // 
            this.BTNMULTIPLICAR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNMULTIPLICAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNMULTIPLICAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNMULTIPLICAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNMULTIPLICAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNMULTIPLICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMULTIPLICAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNMULTIPLICAR.Location = new System.Drawing.Point(353, 241);
            this.BTNMULTIPLICAR.Name = "BTNMULTIPLICAR";
            this.BTNMULTIPLICAR.Size = new System.Drawing.Size(45, 45);
            this.BTNMULTIPLICAR.TabIndex = 12;
            this.BTNMULTIPLICAR.Tag = "x";
            this.BTNMULTIPLICAR.Text = "x";
            this.BTNMULTIPLICAR.UseVisualStyleBackColor = false;
            this.BTNMULTIPLICAR.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNELEVADO
            // 
            this.BTNELEVADO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNELEVADO.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNELEVADO.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNELEVADO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNELEVADO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNELEVADO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELEVADO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELEVADO.Location = new System.Drawing.Point(353, 165);
            this.BTNELEVADO.Name = "BTNELEVADO";
            this.BTNELEVADO.Size = new System.Drawing.Size(45, 45);
            this.BTNELEVADO.TabIndex = 13;
            this.BTNELEVADO.Tag = "²";
            this.BTNELEVADO.Text = "x²";
            this.BTNELEVADO.UseVisualStyleBackColor = false;
            this.BTNELEVADO.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNRAIZCUADRADA
            // 
            this.BTNRAIZCUADRADA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNRAIZCUADRADA.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNRAIZCUADRADA.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNRAIZCUADRADA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNRAIZCUADRADA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNRAIZCUADRADA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRAIZCUADRADA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRAIZCUADRADA.Location = new System.Drawing.Point(275, 165);
            this.BTNRAIZCUADRADA.Name = "BTNRAIZCUADRADA";
            this.BTNRAIZCUADRADA.Size = new System.Drawing.Size(45, 45);
            this.BTNRAIZCUADRADA.TabIndex = 14;
            this.BTNRAIZCUADRADA.Tag = "√";
            this.BTNRAIZCUADRADA.Text = "√";
            this.BTNRAIZCUADRADA.UseVisualStyleBackColor = false;
            this.BTNRAIZCUADRADA.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNSUMAR
            // 
            this.BTNSUMAR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNSUMAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNSUMAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNSUMAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNSUMAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNSUMAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSUMAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSUMAR.Location = new System.Drawing.Point(275, 323);
            this.BTNSUMAR.Name = "BTNSUMAR";
            this.BTNSUMAR.Size = new System.Drawing.Size(45, 45);
            this.BTNSUMAR.TabIndex = 15;
            this.BTNSUMAR.Tag = "+";
            this.BTNSUMAR.Text = "+";
            this.BTNSUMAR.UseVisualStyleBackColor = false;
            this.BTNSUMAR.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNRESTAR
            // 
            this.BTNRESTAR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BTNRESTAR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTNRESTAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTNRESTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BTNRESTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BTNRESTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRESTAR.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRESTAR.Location = new System.Drawing.Point(353, 323);
            this.BTNRESTAR.Name = "BTNRESTAR";
            this.BTNRESTAR.Size = new System.Drawing.Size(45, 45);
            this.BTNRESTAR.TabIndex = 16;
            this.BTNRESTAR.Tag = "-";
            this.BTNRESTAR.Text = "-";
            this.BTNRESTAR.UseVisualStyleBackColor = false;
            this.BTNRESTAR.Click += new System.EventHandler(this.Clickoperador);
            // 
            // BTNBORRARTODO
            // 
            this.BTNBORRARTODO.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNBORRARTODO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBORRARTODO.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBORRARTODO.Location = new System.Drawing.Point(109, 154);
            this.BTNBORRARTODO.Name = "BTNBORRARTODO";
            this.BTNBORRARTODO.Size = new System.Drawing.Size(45, 45);
            this.BTNBORRARTODO.TabIndex = 17;
            this.BTNBORRARTODO.Text = "C";
            this.BTNBORRARTODO.UseVisualStyleBackColor = false;
            this.BTNBORRARTODO.Click += new System.EventHandler(this.BTNBORRARTODO_Click);
            // 
            // BTNNUEVE
            // 
            this.BTNNUEVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNNUEVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BTNNUEVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVE.Location = new System.Drawing.Point(177, 218);
            this.BTNNUEVE.Name = "BTNNUEVE";
            this.BTNNUEVE.Size = new System.Drawing.Size(45, 45);
            this.BTNNUEVE.TabIndex = 18;
            this.BTNNUEVE.Text = "9";
            this.BTNNUEVE.UseVisualStyleBackColor = false;
            this.BTNNUEVE.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNSEIS
            // 
            this.BTNSEIS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNSEIS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BTNSEIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSEIS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSEIS.Location = new System.Drawing.Point(177, 278);
            this.BTNSEIS.Name = "BTNSEIS";
            this.BTNSEIS.Size = new System.Drawing.Size(45, 45);
            this.BTNSEIS.TabIndex = 19;
            this.BTNSEIS.Text = "6";
            this.BTNSEIS.UseVisualStyleBackColor = false;
            this.BTNSEIS.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNTRES
            // 
            this.BTNTRES.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNTRES.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BTNTRES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTRES.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTRES.Location = new System.Drawing.Point(177, 336);
            this.BTNTRES.Name = "BTNTRES";
            this.BTNTRES.Size = new System.Drawing.Size(45, 45);
            this.BTNTRES.TabIndex = 20;
            this.BTNTRES.Text = "3";
            this.BTNTRES.UseVisualStyleBackColor = false;
            this.BTNTRES.Click += new System.EventHandler(this.agregarnumero);
            // 
            // BTNPUTNO
            // 
            this.BTNPUTNO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNPUTNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BTNPUTNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPUTNO.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPUTNO.Location = new System.Drawing.Point(177, 393);
            this.BTNPUTNO.Name = "BTNPUTNO";
            this.BTNPUTNO.Size = new System.Drawing.Size(45, 45);
            this.BTNPUTNO.TabIndex = 21;
            this.BTNPUTNO.Text = ".";
            this.BTNPUTNO.UseVisualStyleBackColor = false;
            this.BTNPUTNO.Click += new System.EventHandler(this.BTNPUTNO_Click);
            // 
            // BTNBORRAR
            // 
            this.BTNBORRAR.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTNBORRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBORRAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBORRAR.Location = new System.Drawing.Point(177, 154);
            this.BTNBORRAR.Name = "BTNBORRAR";
            this.BTNBORRAR.Size = new System.Drawing.Size(45, 45);
            this.BTNBORRAR.TabIndex = 22;
            this.BTNBORRAR.Text = "←";
            this.BTNBORRAR.UseVisualStyleBackColor = false;
            this.BTNBORRAR.Click += new System.EventHandler(this.BTNBORRAR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Calculadora
            // 
            this.Calculadora.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Calculadora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Calculadora.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.ForeColor = System.Drawing.SystemColors.Info;
            this.Calculadora.Location = new System.Drawing.Point(143, 12);
            this.Calculadora.Multiline = true;
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(140, 27);
            this.Calculadora.TabIndex = 24;
            this.Calculadora.Text = "Calculadora  (Dios te Ama)";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 515);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNBORRAR);
            this.Controls.Add(this.BTNPUTNO);
            this.Controls.Add(this.BTNTRES);
            this.Controls.Add(this.BTNSEIS);
            this.Controls.Add(this.BTNNUEVE);
            this.Controls.Add(this.BTNBORRARTODO);
            this.Controls.Add(this.BTNRESTAR);
            this.Controls.Add(this.BTNSUMAR);
            this.Controls.Add(this.BTNRAIZCUADRADA);
            this.Controls.Add(this.BTNELEVADO);
            this.Controls.Add(this.BTNMULTIPLICAR);
            this.Controls.Add(this.BTNRESULTADODETODO);
            this.Controls.Add(this.BTNCERO);
            this.Controls.Add(this.BTNDOS);
            this.Controls.Add(this.BTNDIVIDIR);
            this.Controls.Add(this.BTNCINCO);
            this.Controls.Add(this.BTNOCHO);
            this.Controls.Add(this.BTNUNO);
            this.Controls.Add(this.BTNCUATRO);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTNSIETE);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.textPRUEBA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPRUEBA;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNSIETE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTNCUATRO;
        private System.Windows.Forms.Button BTNUNO;
        private System.Windows.Forms.Button BTNOCHO;
        private System.Windows.Forms.Button BTNCINCO;
        private System.Windows.Forms.Button BTNDIVIDIR;
        private System.Windows.Forms.Button BTNDOS;
        private System.Windows.Forms.Button BTNCERO;
        private System.Windows.Forms.Button BTNRESULTADODETODO;
        private System.Windows.Forms.Button BTNMULTIPLICAR;
        private System.Windows.Forms.Button BTNELEVADO;
        private System.Windows.Forms.Button BTNRAIZCUADRADA;
        private System.Windows.Forms.Button BTNSUMAR;
        private System.Windows.Forms.Button BTNRESTAR;
        private System.Windows.Forms.Button BTNBORRARTODO;
        private System.Windows.Forms.Button BTNNUEVE;
        private System.Windows.Forms.Button BTNSEIS;
        private System.Windows.Forms.Button BTNTRES;
        private System.Windows.Forms.Button BTNPUTNO;
        private System.Windows.Forms.Button BTNBORRAR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Calculadora;
    }
}

