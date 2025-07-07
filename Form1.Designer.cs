namespace WinFormsApp6
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
            btnRemover = new Button();
            btnAdcionar = new Button();
            label1 = new Label();
            lstTarefa = new ListBox();
            txtTarefa = new TextBox();
            SuspendLayout();
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(146, 216);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(94, 29);
            btnRemover.TabIndex = 0;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdcionar
            // 
            btnAdcionar.Location = new Point(24, 216);
            btnAdcionar.Name = "btnAdcionar";
            btnAdcionar.Size = new Size(94, 29);
            btnAdcionar.TabIndex = 1;
            btnAdcionar.Text = "Adicionar";
            btnAdcionar.UseVisualStyleBackColor = true;
            btnAdcionar.Click += btnAdcionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 47);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 2;
            label1.Text = "Tarefa";
            // 
            // lstTarefa
            // 
            lstTarefa.FormattingEnabled = true;
            lstTarefa.Location = new Point(24, 97);
            lstTarefa.Name = "lstTarefa";
            lstTarefa.Size = new Size(150, 104);
            lstTarefa.TabIndex = 3;
            lstTarefa.DoubleClick += lstTarefa_DoubleClick;
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(90, 44);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(150, 27);
            txtTarefa.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 292);
            Controls.Add(txtTarefa);
            Controls.Add(lstTarefa);
            Controls.Add(label1);
            Controls.Add(btnAdcionar);
            Controls.Add(btnRemover);
            Name = "Form1";
            Text = "Gerenciador de Tarefas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemover;
        private Button btnAdcionar;
        private Label label1;
        private ListBox lstTarefa;
        private TextBox txtTarefa;
    }
}
